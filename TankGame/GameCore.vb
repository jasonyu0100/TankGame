Public Class GameCore
    Public rows As Integer
    Public cols As Integer
    Public grid As GameGrid
    Public playerCount As Integer
    Public players As List(Of Player)
    Public turnNumber = 0
    Public gameInfo As GameInformation
    Public squareImages As SquareImages
    Public entityImages As EnvironmentalImages
    Public moveCosts As MoveCosts

    Public Sub New(gameInfo As GameInformation)
        Me.gameInfo = gameInfo
        Me.moveCosts = Me.gameInfo.moveCosts
        Me.squareImages = Me.gameInfo.squareImages
        Me.entityImages = Me.gameInfo.entityImages
        Me.rows = gameInfo.rows
        Me.cols = gameInfo.cols
        Me.playerCount = gameInfo.playerCount
        Me.players = gameInfo.players
        Me.grid = New GameGrid(Me.rows, Me.cols) '

        'Setup Game
        Me.setUpPlayers()
        Me.grid.createEnvironmentalGrid(Me.entityImages, Me.gameInfo.map)
        Me.grid.createSquareGrid(Me.squareImages)

        'Sets up first turn
        Dim currentPlayer = getCurrentPlayer()
        setSquareStyle(SquareStyleEnum.Highlight, currentPlayer.gridCoordinate)
        Me.updateHud(currentPlayer)
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
            coordinate.y = Me.rows - 1
        ElseIf playerNum = 3 Then
            coordinate.x = Me.cols - 1
            coordinate.y = Me.rows - 1
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
        Game.PlayerName.Text = "Health: " & currentPlayer.playerStats.health
        Game.ActionPointsLabel.Text = "Action Points: " & currentPlayer.playerStats.actionPoints
    End Sub

    Private Sub setSquareStyle(style As SquareStyleEnum, coordinate As Coordinate)
        Me.grid.gridSquaresGrid(coordinate.y)(coordinate.x).setImageFile(style)
    End Sub


    Public Sub startTurn()
        Me.grid.clearSelected()
        Dim previousPlayer As Player = Me.getCurrentPlayer()
        previousPlayer.playerStats.actionPoints = Me.gameInfo.actionPoints
        setSquareStyle(SquareStyleEnum.Normal, previousPlayer.gridCoordinate)
        Me.turnNumber += 1
        Dim currentPlayer = getCurrentPlayer()
        setSquareStyle(SquareStyleEnum.Highlight, currentPlayer.gridCoordinate)
        Me.updateHud(currentPlayer)
    End Sub

    Private Sub setTurretSquareStyle(style As SquareStyleEnum, currentPlayer As Player)
        For Each turret As Turret In currentPlayer.turrets
            setSquareStyle(style, turret.gridCoordinate)
        Next
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

    Public Sub displayActionPositions(range As Integer, coordinate As Coordinate)
        Me.grid.clearSelected()
        Dim availablePositions As List(Of Coordinate) = Me.availablePositions(range, coordinate)
        For Each current As Coordinate In availablePositions
            Dim square = Me.grid.gridSquaresGrid(current.y)(current.x)
            square.setImageFile(SquareStyleEnum.Selected)
        Next
    End Sub

    Public Sub displayPossibleTurrets()
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        For Each turret As Turret In currentPlayer.turrets
            Dim gridCoord = turret.gridCoordinate
            Dim square = Me.grid.gridSquaresGrid(gridCoord.y)(gridCoord.x)
            square.setImageFile(SquareStyleEnum.Selected)
        Next
    End Sub

    Private Function availablePositions(range As Integer, coordinate As Coordinate)
        Dim available = New List(Of Coordinate)
        Dim right = New Coordinate(0, 1)
        Dim left = New Coordinate(0, -1)
        Dim up = New Coordinate(-1, 0)
        Dim down = New Coordinate(1, 0)
        availableDirectionPositions(coordinate, right, range, available)
        availableDirectionPositions(coordinate, left, range, available)
        availableDirectionPositions(coordinate, up, range, available)
        availableDirectionPositions(coordinate, down, range, available)
        Return available
    End Function

    Private Function availableDirectionPositions(coordinate As Coordinate, direction As Coordinate, range As Integer, available As List(Of Coordinate))
        Dim counter = 1
        Dim valid = True
        While counter <= range And valid
            Dim newCoord = New Coordinate(coordinate.y + counter * direction.y, coordinate.x + counter * direction.x)
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
        Dim currentPlayer As Player = Me.getCurrentPlayer()
        Dim selectedEntity = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x)
        Select Case selectedEntity.entityType
            Case EntityType.Player
                Dim otherPlayer As Player = selectedEntity
                MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit player: " & otherPlayer.playerName)
                otherPlayer.playerStats.health -= currentPlayer.playerStats.attack * 5 - (otherPlayer.playerStats.armor * 0.2)
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.shoot
                Me.updateHud(currentPlayer)
            Case EntityType.Empty
                MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which is empty")
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.shoot
                Me.updateHud(currentPlayer)
            Case EntityType.Turret
                Dim turret As Turret = selectedEntity
                MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit player " & turret.playerNum & "'s turret")
                turret.turretStats.health -= currentPlayer.playerStats.attack * 5 - (turret.turretStats.armor * 0.2)
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.shoot
                Me.updateHud(currentPlayer)
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntity.entityType.ToString)
        End Select
    End Sub

    Public Sub move(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer As Player = Me.getCurrentPlayer()
        Dim selectedEntityType = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x).entityType
        Select Case selectedEntityType
            Case EntityType.Player
                MsgBox("Can't move to another players location")
            Case EntityType.Turret
                MsgBox("Can't move to a turrets location")
            Case EntityType.Empty
                setSquareStyle(SquareStyleEnum.Normal, currentPlayer.gridCoordinate)
                Me.grid.moveEntity(currentPlayer.gridCoordinate, gridCoord)
                setSquareStyle(SquareStyleEnum.Highlight, gridCoord)
                MsgBox("You have moved to x:" & gridCoord.x & " y:" & gridCoord.y)
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.move
                Me.updateHud(currentPlayer)
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntityType.ToString)
        End Select
    End Sub

    Public Sub build(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer As Player = Me.getCurrentPlayer()
        Dim selectedEntity = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x)
        Dim selectedEntityType = selectedEntity.entityType
        Select Case selectedEntityType
            Case EntityType.Player
                MsgBox("Can't build on another players location")
            Case EntityType.Turret
                MsgBox("Can't build on another turret")
            Case EntityType.Empty
                Dim newTurret As Turret = New Turret(gridCoord, selectedEntity.actualCoordinate, currentPlayer.playerNum, currentPlayer.turretImageFile, currentPlayer.turretStats)
                newTurret.createElement(Me.grid.squareSize, Game)
                newTurret.pictureElement.BringToFront()
                Me.grid.deleteGridCell(gridCoord)
                Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x) = newTurret
                currentPlayer.turrets.Add(newTurret)
                MsgBox("You have built at x:" & gridCoord.x & " y:" & gridCoord.y)
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.build
                Me.updateHud(currentPlayer)
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntityType.ToString)
        End Select
    End Sub

    Public Sub turret(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        Dim shootRange = currentPlayer.turretStats.shootRange
        currentPlayer.currentTurret = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x)
        Me.displayActionPositions(shootRange, gridCoord)
        Dim square = Me.grid.gridSquaresGrid(gridCoord.y)(gridCoord.x)
        square.setImageFile(SquareStyleEnum.Highlight)
        Game.selectedAction = Game.GameMoves.turretShoot
    End Sub

    Public Sub turretShoot(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer As Player = Me.getCurrentPlayer()
        Dim currentTurret = currentPlayer.currentTurret
        Dim selectedEntity = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x)
        Select Case selectedEntity.entityType
            Case EntityType.Player
                Dim otherPlayer As Player = selectedEntity
                MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit player: " & otherPlayer.playerName)
                otherPlayer.playerStats.health -= currentTurret.turretStats.attack * 5 - (otherPlayer.playerStats.armor * 0.2)
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.turret
                Me.updateHud(currentPlayer)
            Case EntityType.Turret
                Dim otherTurret As Turret = selectedEntity
                Dim parentPlayer = Me.players(otherTurret.playerNum)
                MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit " & parentPlayer.playerName & "' turret")
                otherTurret.turretStats.health -= currentTurret.turretStats.attack * 5 - (otherTurret.turretStats.armor * 0.2)
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.turret
                Me.updateHud(currentPlayer)
            Case EntityType.Empty
                MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which is empty")
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.shoot
                Me.updateHud(currentPlayer)
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntity.entityType.ToString)
        End Select
        setSquareStyle(SquareStyleEnum.Highlight, currentPlayer.gridCoordinate)
        setSquareStyle(SquareStyleEnum.Normal, currentTurret.gridCoordinate)
        currentPlayer.currentTurret = Nothing
    End Sub
End Class

Public Structure GameInformation
    Public players As List(Of Player)
    Public playerCount As Integer
    Public rows As Integer
    Public cols As Integer
    Public moveCosts As MoveCosts
    Public actionPoints As Integer
    Public squareImages As SquareImages
    Public entityImages As EnvironmentalImages
    Public map As List(Of List(Of Char))
End Structure

Public Structure MoveCosts
    Public shoot As Integer
    Public move As Integer
    Public turret As Integer
    Public build As Integer
End Structure

Public Enum EntityType
    Empty
    Player
    Turret
    Water
    Grass
    Road
    Mountain
End Enum
