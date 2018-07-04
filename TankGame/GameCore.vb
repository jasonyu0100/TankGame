Public Class GameCore
    Public rows As Integer
    Public cols As Integer
    Public grid As Grid
    Public playerCount As Integer
    Public players As List(Of Player)
    Public turnNumber = 0
    Public gameInfo As GameInformation
    Public actionPoints As ActionPoints

    Public Sub New(gameInfo As GameInformation)
        Me.gameInfo = gameInfo
        Me.rows = gameInfo.rows
        Me.cols = gameInfo.cols
        Me.playerCount = gameInfo.playerCount
        Me.players = gameInfo.players
        Me.grid = New Grid(Me.rows, Me.cols)
        'Setup Game
        Me.setUpPlayers()
        Me.grid.createSquareGrid(gameInfo.gridBoxImage, gameInfo.selectionBoxImage)
        Me.startTurn()
    End Sub

    Public Sub setUpPlayers()
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

    Public Function startingCoordinate(playerNum As Integer)
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

    Public Sub updateHud()
        Game.TurnNumLabel.Text = "Turn Number: " & Me.turnNumber
        Dim currentPlayer = getCurrentPlayer()
        Game.PlayerHealth.Text = "Name: " & currentPlayer.playerName
        Game.PlayerName.Text = "Health: " & currentPlayer.playerHealth
    End Sub

    Public Sub startTurn()
        Me.grid.clearSelected()
        Me.turnNumber += 1
        Me.updateHud()
    End Sub

    Public Function validCoord(coord As Coordinate)
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
            square.setSelectImageFile()
        Next
    End Sub

    Public Function availablePositions(range As Integer)
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

    Public Function availableDirectionPositions(x As Integer, y As Integer, direction As Coordinate, range As Integer, available As List(Of Coordinate))
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

    Public Sub shoot(coord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        MsgBox("You have shot at x:" & coord.x & " y:" & coord.y)
    End Sub

    Public Sub move(coord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        Me.grid.moveEntity(currentPlayer.gridCoordinate, coord)

        MsgBox("You have moved to x:" & coord.x & " y:" & coord.y)
    End Sub

    Public Sub build(coord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        MsgBox("You have built at x:" & coord.x & " y:" & coord.y)
    End Sub

    Public Sub turret(coord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        MsgBox("You have shot the turret at x:" & coord.x & " y:" & coord.y)
    End Sub
End Class

Public Structure ActionPoints
    'Settings can be tweaked based on gameplay
    Public actionPoints As Integer
    Public move As Integer
    Public attack As Integer
    Public build As Integer
    Public turret As Integer
End Structure
