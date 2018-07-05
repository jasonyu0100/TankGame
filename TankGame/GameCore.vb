Public Class GameCore
    Public rows As Integer
    Public cols As Integer
    Public grid As Grid
    Public playerCount As Integer
    Public players As List(Of Player)
    Public turnNumber = 0
    Public gameInfo As GameInformation
    Public squareImages As SquareImages

    Public Sub New(gameInfo As GameInformation, squareImages As SquareImages)
        Me.gameInfo = gameInfo
        Me.squareImages = squareImages
        Me.rows = gameInfo.rows
        Me.cols = gameInfo.cols
        Me.playerCount = gameInfo.playerCount
        Me.players = gameInfo.players
        Me.grid = New Grid(Me.rows, Me.cols)
        'Setup Game
        Me.setUpPlayers()
        Me.grid.createSquareGrid(squareImages)
        Me.startTurn()
    End Sub

    Private Sub setUpPlayers()
        For playerNum = 0 To playerCount - 1
            Dim startingCoord As Coordinate = startingCoordinate(playerNum)
            Dim actualCoord As Coordinate = New Coordinate(startingCoord.y * Me.grid.squareSize, startingCoord.x * Me.grid.squareSize)
            Dim currentPlayer = Me.players(playerNum)
            currentPlayer.actualCoordinate = actualCoord
            currentPlayer.gridCoordinate = startingCoord
            Me.grid.updateGridCell(currentPlayer, startingCoord)
            currentPlayer.createElement(Me.grid.squareSize, Game)
        Next
    End Sub

    Private Function startingCoordinate(playerNum As Integer)
        Dim coordinate As Coordinate = New Coordinate(0, 0)
        If playerNum = 0 Then
            coordinate.x = 0
            coordinate.y = 0
        ElseIf playerNum = 1 Then
            coordinate.x = Me.cols - 1
            coordinate.y = 0
        ElseIf playerNum = 2 Then
            coordinate.x = 0
            coordinate.y = Me.cols - 1
        ElseIf playerNum = 3 Then
            coordinate.x = Me.cols - 1
            coordinate.y = Me.cols - 1
        Else

        End If
        Return coordinate
    End Function

    Public Function getCurrentPlayer()
        Dim turn = Me.turnNumber Mod Me.playerCount
        Dim currentPlayer = Me.players(turn)
        Return currentPlayer
    End Function

    Public Sub updateHud(currentPlayer As Player)
        Game.TurnNumLabel.Text = "Turn Number: " & Me.turnNumber
        Game.PlayerHealth.Text = "Name: " & currentPlayer.playerName
        Game.PlayerName.Text = "Health: " & currentPlayer.playerHealth
    End Sub

    Private Sub setSquareStyle(style As SquareStyleEnum, coordinate As Coordinate)
        Me.grid.squares(coordinate.y)(coordinate.x).setImageFile(style)
    End Sub


    Public Sub startTurn()
        Me.grid.clearSelected()
        setSquareStyle(SquareStyleEnum.Normal, Me.getCurrentPlayer().gridCoordinate)
        Me.turnNumber += 1
        Dim currentPlayer = getCurrentPlayer()
        setSquareStyle(SquareStyleEnum.Highlight, currentPlayer.gridCoordinate)
        Me.updateHud(currentPlayer)
    End Sub

    Private Function validCoord(coord As Coordinate)
        Dim x = coord.x
        Dim y = coord.y
        If x < 0 Or y < 0 Then
            Return False
        ElseIf x > cols - 1 Or y > rows - 1 Then
            Return False
        End If
        Return True
    End Function

    Public Sub displayActionPositions(range As Integer)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        Dim availablePositions As List(Of Coordinate) = Me.availablePositions(range)
        For Each current As Coordinate In availablePositions
            Dim row = current.y
            Dim col = current.x
            Dim square = Me.grid.squares(row)(col)
            square.setImageFile(SquareStyleEnum.Selected)
        Next
    End Sub

    Private Function availablePositions(range As Integer)
        Dim currentPlayer = Me.getCurrentPlayer()
        Dim available = New List(Of Coordinate)
        Dim x = currentPlayer.gridCoordinate.x
        Dim y = currentPlayer.gridCoordinate.y
        Dim right = New Coordinate(0, 1)
        Dim left = New Coordinate(0, -1)
        Dim up = New Coordinate(-1, 0)
        Dim down = New Coordinate(1, 0)
        availableDirectionPositions(x, y, right, range, available)
        availableDirectionPositions(x, y, left, range, available)
        availableDirectionPositions(x, y, up, range, available)
        availableDirectionPositions(x, y, down, range, available)
        Return available
    End Function

    Private Function availableDirectionPositions(x As Integer, y As Integer, direction As Coordinate, range As Integer, available As List(Of Coordinate))
        Dim counter = 1
        Dim valid = True
        While counter <= range And valid
            Dim newCoord = New Coordinate(y + counter * direction.y, x + counter * direction.x)
            valid = Me.validCoord(newCoord)
            If valid Then
                available.Add(newCoord)
            End If
            counter += 1
        End While
        Return available
    End Function

    Public Sub shoot(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        Dim selectedEntityType = Me.grid.grid(gridCoord.y)(gridCoord.x).entityType
        Select Case selectedEntityType
            Case EntityType.Player
                Dim otherPlayer As Player = currentPlayer
                MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit player: " & otherPlayer.playerName)
            Case EntityType.Empty
                MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which is empty")
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntityType.ToString)
        End Select
    End Sub

    Public Sub move(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        Dim selectedEntityType = Me.grid.grid(gridCoord.y)(gridCoord.x).entityType
        Select Case selectedEntityType
            Case EntityType.Player
                MsgBox("Can't move to another players location")
            Case EntityType.Empty
                setSquareStyle(SquareStyleEnum.Normal, currentPlayer.gridCoordinate)
                Me.grid.moveEntity(currentPlayer.gridCoordinate, gridCoord)
                setSquareStyle(SquareStyleEnum.Highlight, gridCoord)
                MsgBox("You have moved to x:" & gridCoord.x & " y:" & gridCoord.y)
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntityType.ToString)
        End Select
    End Sub

    Public Sub build(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        MsgBox("You have built at x:" & gridCoord.x & " y:" & gridCoord.y)
    End Sub

    Public Sub turret(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        MsgBox("You have shot the turret at x:" & gridCoord.x & " y:" & gridCoord.y)
    End Sub
End Class

Public Structure GameInformation
    Public players As List(Of Player)
    Public playerCount As Integer
    Public rows As Integer
    Public cols As Integer
End Structure

Public Enum EntityType
    Empty
    Player
End Enum
