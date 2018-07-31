''' <summary>
''' Main core of game. Is where all main functions and components are stored
''' </summary>
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
        Me.grid = New GameGrid(Me.rows, Me.cols)

        Me.setUpPlayers()
        Me.grid.environmentGrid = Me.grid.createEnvironmentalGrid(Me.entityImages, Me.gameInfo.map)
        Me.grid.createSquareGrid(Me.squareImages)

        Dim currentPlayer = getCurrentPlayer()
        setSquareStyle(SquareStyleEnum.Highlight, currentPlayer.gridCoordinate)
        Me.updateHud(currentPlayer)
    End Sub

    ''' <summary>
    ''' Sets players to coordinate based on player num and adds to game
    ''' </summary>
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

    ''' <summary>
    ''' Defines starting coordinates for a player
    ''' </summary>
    ''' <param name="playerNum"></param>
    ''' <returns></returns>
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

    ''' <summary>
    ''' Gets current player that is not dead
    ''' </summary>
    ''' <returns></returns>
    Public Function getCurrentPlayer()
        Dim changeVal = 0
        Dim validPlayer = False
        Dim currentPlayer As Player = Nothing
        While validPlayer = False
            Dim turn = (Me.turnNumber + changeVal) Mod Me.playerCount
            currentPlayer = Me.players(turn)
            If currentPlayer.playerStats.health <= 0 Then
                changeVal += 1
            Else
                validPlayer = True
            End If
        End While
        Return currentPlayer
    End Function

    ''' <summary>
    ''' Updates hud where user sees personal stats
    ''' </summary>
    ''' <param name="currentPlayer"></param>
    Public Sub updateHud(currentPlayer As Player)
        Game.TurnNumLabel.Text = "Turn Number: " & Me.turnNumber
        Game.PlayerHealth.Text = "Name: " & currentPlayer.playerName
        Game.PlayerName.Text = "Health: " & currentPlayer.playerStats.health
        Game.ActionPointsLabel.Text = "Action Points: " & currentPlayer.playerStats.actionPoints
    End Sub

    ''' <summary>
    ''' Updates coordinate square style
    ''' </summary>
    ''' <param name="style"></param>
    ''' <param name="coordinate"></param>
    Private Sub setSquareStyle(style As SquareStyleEnum, coordinate As Coordinate)
        Me.grid.gridSquaresGrid(coordinate.y)(coordinate.x).setImageFile(style)
    End Sub

    ''' <summary>
    ''' Updates turn number and miscellaneous information
    ''' </summary>
    Public Sub startTurn()
        Me.grid.clearSelected()
        Dim previousPlayer As Player = Me.getCurrentPlayer()
        previousPlayer.playerStats.actionPoints = Me.gameInfo.actionPoints
        previousPlayer.traversals = 0
        setSquareStyle(SquareStyleEnum.Normal, previousPlayer.gridCoordinate)

        Me.turnNumber += 1
        Dim currentPlayer = getCurrentPlayer()
        setSquareStyle(SquareStyleEnum.Highlight, currentPlayer.gridCoordinate)
        Me.updateHud(currentPlayer)
    End Sub

    ''' <summary>
    ''' Sets current style for all player's turrets
    ''' </summary>
    ''' <param name="style"></param>
    ''' <param name="currentPlayer"></param>
    Private Sub setTurretSquareStyle(style As SquareStyleEnum, currentPlayer As Player)
        For Each turret As Turret In currentPlayer.turrets
            setSquareStyle(style, turret.gridCoordinate)
        Next
    End Sub

    ''' <summary>
    ''' Returns whether coordinate is within grid range
    ''' </summary>
    ''' <param name="coord"></param>
    ''' <returns></returns>
    Private Function validCoord(coord As Coordinate)
        Return Not (coord.x < 0 Or coord.y < 0 Or coord.x > cols - 1 Or coord.y > rows - 1)
    End Function

    ''' <summary>
    ''' Displays positions where actions can be made
    ''' </summary>
    ''' <param name="range"></param>
    ''' <param name="coordinate"></param>
    ''' <param name="move"></param>
    Public Sub displayActionPositions(range As Integer, coordinate As Coordinate, move As GameMoves)
        Me.grid.clearSelected()
        Dim availablePositions = New List(Of Coordinate)
        If move = GameMoves.move Then
            availablePositions = Me.availableMovePositions(range, coordinate)
            Dim costs As Dictionary(Of Tuple(Of Integer, Integer), Integer) = getMovementSquareCosts(coordinate, availablePositions)
            displayCosts(costs)
        Else
            availablePositions = Me.availableStraightPositions(range, coordinate)
        End If
        For Each current As Coordinate In availablePositions
            Dim square = Me.grid.gridSquaresGrid(current.y)(current.x)
            square.setImageFile(SquareStyleEnum.Selected)
        Next
    End Sub

    ''' <summary>
    ''' Displays costs of action
    ''' </summary>
    ''' <param name="costs"></param>
    Public Sub displayCosts(costs As Dictionary(Of Tuple(Of Integer, Integer), Integer))
        For Each value In costs
            Dim coordTuple = value.Key
            Dim cost = value.Value
            Dim square = Me.grid.gridSquaresGrid(coordTuple.Item1)(coordTuple.Item2)
            square.createLabel(cost, Me.grid.squareSize, Game)
        Next
    End Sub

    ''' <summary>
    ''' Gets cost of movement actions. Utilises djikstra's algorithm
    ''' </summary>
    ''' <param name="playerCoordinate"></param>
    ''' <param name="availablePositions"></param>
    ''' <returns></returns>
    Public Function getMovementSquareCosts(playerCoordinate As Coordinate, availablePositions As List(Of Coordinate))
        Dim visited = New Dictionary(Of Tuple(Of Integer, Integer), Integer)
        Dim unvisited = New Dictionary(Of Tuple(Of Integer, Integer), Integer)
        Dim infinity = 10000
        For Each position In availablePositions
            Dim coord = New Tuple(Of Integer, Integer)(position.y, position.x)
            unvisited.Add(coord, 10000)
        Next
        Dim currentCoord = New Tuple(Of Integer, Integer)(playerCoordinate.y, playerCoordinate.x)
        Dim currentCost = 0
        unvisited.Remove(currentCoord)
        visited.Add(currentCoord, currentCost)

        Dim right = New Coordinate(0, 1)
        Dim left = New Coordinate(0, -1)
        Dim up = New Coordinate(-1, 0)
        Dim down = New Coordinate(1, 0)
        Dim vectors() As Coordinate = {right, left, up, down}
        Do While (unvisited.Count > 0)
            For Each vector In vectors
                Dim neighbour = New Tuple(Of Integer, Integer)(currentCoord.Item1 + vector.y, currentCoord.Item2 + vector.x)
                If validCoord(New Coordinate(neighbour.Item1, neighbour.Item2)) And unvisited.ContainsKey(neighbour) Then
                    Dim newCost = currentCost + getSquareMovementCost(neighbour)
                    If newCost < unvisited(neighbour) Then
                        unvisited(neighbour) = newCost
                    End If
                End If
            Next
            currentCoord = getMinCoordinate(unvisited)
            currentCost = unvisited(currentCoord)
            visited.Add(currentCoord, currentCost)
            unvisited.Remove(currentCoord)
        Loop
        Return visited
    End Function

    ''' <summary>
    ''' Gets the minimum coordinate
    ''' </summary>
    ''' <param name="unvisited"></param>
    ''' <returns></returns>
    Public Function getMinCoordinate(unvisited As Dictionary(Of Tuple(Of Integer, Integer), Integer))
        Dim minCost = 100000 'Arbtitrary large value
        Dim minCoord As Tuple(Of Integer, Integer) = Nothing
        For Each kvp As KeyValuePair(Of Tuple(Of Integer, Integer), Integer) In unvisited
            Dim coordinate = kvp.Key
            Dim cost = kvp.Value
            If cost < minCost Then
                minCost = cost
                minCoord = coordinate
            End If
        Next
        Return minCoord
    End Function

    ''' <summary>
    ''' Gets cost to move to a square
    ''' </summary>
    ''' <param name="coordinate"></param>
    ''' <returns></returns>
    Private Function getSquareMovementCost(coordinate As Tuple(Of Integer, Integer))
        Dim cost = 0
        Dim environmentSquareType = grid.environmentGrid(coordinate.Item1)(coordinate.Item2).entityType
        Select Case environmentSquareType
            Case EntityType.Grass
                cost = Me.moveCosts.grassMove
            Case EntityType.Water
                cost = Me.moveCosts.waterMove
            Case EntityType.Road
                cost = Me.moveCosts.roadMove
            Case EntityType.Mountain
                cost = 10000
            Case Else
                Throw New Exception("Unidentifiable Character")
        End Select

        Dim elementType = grid.gameElementGrid(coordinate.Item1)(coordinate.Item2).entityType()
        Select Case elementType
            Case EntityType.Player
                cost = 10000
            Case EntityType.Turret
                cost = 10000
            Case Else

        End Select

        Return cost
    End Function

    ''' <summary>
    ''' Displays possible turrets that can be selected
    ''' </summary>
    Public Sub displayPossibleTurrets()
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        For Each turret As Turret In currentPlayer.turrets
            Dim gridCoord = turret.gridCoordinate
            Dim square = Me.grid.gridSquaresGrid(gridCoord.y)(gridCoord.x)
            square.setImageFile(SquareStyleEnum.Selected)
        Next
    End Sub

    ''' <summary>
    ''' Gets available positions you can move
    ''' </summary>
    ''' <param name="range"></param>
    ''' <param name="coordinate"></param>
    ''' <returns></returns>
    Private Function availableMovePositions(range As Integer, coordinate As Coordinate)
        Dim seen = New HashSet(Of Tuple(Of Integer, Integer))
        Dim available = New List(Of Coordinate)
        Dim stack = New List(Of Coordinate)
        stack.Add(coordinate)
        seen.Add(New Tuple(Of Integer, Integer)(coordinate.y, coordinate.x))

        Dim right = New Coordinate(0, 1)
        Dim left = New Coordinate(0, -1)
        Dim up = New Coordinate(-1, 0)
        Dim down = New Coordinate(1, 0)
        Dim vectors() As Coordinate = {right, left, up, down}
        For i = 1 To range
            Dim newStack = New List(Of Coordinate)
            For Each currentCoordinate In stack
                For Each vector As Coordinate In vectors
                    Dim newCoord = New Coordinate(currentCoordinate.y + vector.y, currentCoordinate.x + vector.x)
                    Dim tuple = New Tuple(Of Integer, Integer)(newCoord.y, newCoord.x)
                    If Me.validCoord(newCoord) And Not seen.Contains(tuple) Then
                        available.Add(newCoord)
                        newStack.Add(newCoord)
                        seen.Add(tuple)
                    End If
                Next
            Next
            stack = newStack
        Next
        Return available
    End Function

    ''' <summary>
    ''' Gets possible positions in straight lines u,d,l,r from origin
    ''' </summary>
    ''' <param name="range"></param>
    ''' <param name="coordinate"></param>
    ''' <returns></returns>
    Private Function availableStraightPositions(range As Integer, coordinate As Coordinate)
        Dim available = New List(Of Coordinate)
        Dim right = New Coordinate(0, 1)
        Dim left = New Coordinate(0, -1)
        Dim up = New Coordinate(-1, 0)
        Dim down = New Coordinate(1, 0)
        Dim vectors() As Coordinate = {right, left, up, down}
        For Each vector As Coordinate In vectors
            availableDirectionPositions(coordinate, vector, range, available)
        Next
        Return available
    End Function

    ''' <summary>
    ''' Gets available positions for a given direction
    ''' </summary>
    ''' <param name="coordinate"></param>
    ''' <param name="direction"></param>
    ''' <param name="range"></param>
    ''' <param name="available"></param>
    ''' <returns></returns>
    Private Function availableDirectionPositions(coordinate As Coordinate, direction As Coordinate, range As Integer, available As List(Of Coordinate))
        Dim counter = 1
        Dim valid = True
        While counter <= range And valid
            Dim newCoord = New Coordinate(coordinate.y + counter * direction.y, coordinate.x + counter * direction.x)
            valid = Me.validCoord(newCoord)
            If valid Then
                available.Add(newCoord)
                Dim destinationEnvironment = Me.grid.environmentGrid(newCoord.y)(newCoord.x)
                Dim value As Entity = Me.grid.gameElementGrid(newCoord.y)(newCoord.x)
                If value.entityType = EntityType.Player Or value.entityType = EntityType.Turret Or destinationEnvironment.entityType = EntityType.Mountain Then
                    valid = False
                End If
            End If
            counter += 1
        End While
        Return available
    End Function

    ''' <summary>
    ''' Shoot causes damage to selected entity
    ''' </summary>
    ''' <param name="gridCoord"></param>
    Public Sub shoot(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer As Player = Me.getCurrentPlayer()
        Dim selectedEntity = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x)
        Select Case selectedEntity.entityType
            Case EntityType.Player
                Dim otherPlayer As Player = selectedEntity
                'MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit player: " & otherPlayer.playerName)
                otherPlayer.playerStats.health -= currentPlayer.playerStats.attack * 5 - (otherPlayer.playerStats.armor * 0.2)
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.shoot
                otherPlayer.healthLabel.Text = otherPlayer.playerStats.health
                Me.updateHud(currentPlayer)
                My.Computer.Audio.Play(InGameOptions.shootSoundEffectLocation, AudioPlayMode.Background)
            Case EntityType.Empty
                'MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which is empty")
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.shoot
                Me.updateHud(currentPlayer)
                Me.checkMountainAttack(gridCoord, currentPlayer)
                My.Computer.Audio.Play(InGameOptions.shootSoundEffectLocation, AudioPlayMode.Background)
            Case EntityType.Turret
                Dim turret As Turret = selectedEntity
                'MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit player " & turret.playerNum & "'s turret")
                turret.turretStats.health -= currentPlayer.playerStats.attack * 5 - (turret.turretStats.armor * 0.2)
                currentPlayer.playerStats.actionPoints -= Me.moveCosts.shoot
                turret.healthLabel.Text = turret.turretStats.health
                Me.updateHud(currentPlayer)
                My.Computer.Audio.Play(InGameOptions.shootSoundEffectLocation, AudioPlayMode.Background)
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntity.entityType.ToString)
        End Select
    End Sub

    Private Sub checkMountainAttack(gridCoord As Coordinate, currentPlayer As Player)
        Dim environmentSquare = Me.grid.environmentGrid(gridCoord.y)(gridCoord.x)
        If environmentSquare.entityType = EntityType.Mountain Then
            Dim mountain As Mountain = environmentSquare
            mountain.health -= currentPlayer.playerStats.attack * 5
            If mountain.health < 0 Then
                Game.Controls.Remove(mountain.pictureElement)
                Dim newSquare = New Grass(mountain.gridCoordinate, mountain.actualCoordinate, InGameOptions.GrassImageBox.Image)
                newSquare.createElement(Me.grid.squareSize, Game)
                newSquare.pictureElement.BringToFront()
                Me.grid.environmentGrid(gridCoord.y)(gridCoord.x) = newSquare
            End If
        End If
    End Sub

    ''' <summary>
    ''' Move, moves the user to the given coordinate
    ''' </summary>
    ''' <param name="gridCoord"></param>
    Public Sub move(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer As Player = Me.getCurrentPlayer()
        Dim selectedEntityType = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x).entityType
        Dim destinationEnvironment = Me.grid.environmentGrid(gridCoord.y)(gridCoord.x)
        Dim square = Me.grid.gridSquaresGrid(gridCoord.y)(gridCoord.x)
        Select Case selectedEntityType
            Case EntityType.Player
                MsgBox("Can't move to another players location")
            Case EntityType.Turret
                MsgBox("Can't move to a turrets location")
            Case EntityType.Empty
                setSquareStyle(SquareStyleEnum.Normal, currentPlayer.gridCoordinate)
                If destinationEnvironment.entityType = EntityType.Mountain Then
                    MsgBox("Can't move tank onto a mountain")
                ElseIf square.moveCost >= 10000 Then
                    MsgBox("Unable to move to current square!")
                ElseIf (currentPlayer.playerStats.actionPoints - square.moveCost) < 0 Then
                    MsgBox("Not enough action points")
                Else
                    Me.grid.moveEntity(currentPlayer.gridCoordinate, gridCoord)
                    currentPlayer.updateHealthLabel(Me.grid.squareSize)
                    setSquareStyle(SquareStyleEnum.Highlight, gridCoord)
                    currentPlayer.playerStats.actionPoints -= square.moveCost
                    currentPlayer.traversals += 1
                    Me.updateHud(currentPlayer)
                    My.Computer.Audio.Play(InGameOptions.moveSoundEffectLocation, AudioPlayMode.Background)
                End If
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntityType.ToString)
        End Select
    End Sub

    ''' <summary>
    ''' Builds a turret, that cannot move at given coordinate
    ''' </summary>
    ''' <param name="gridCoord"></param>
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
                Dim destinationEnvironment = Me.grid.environmentGrid(gridCoord.y)(gridCoord.x)
                If destinationEnvironment.entityType = EntityType.Water Then
                    MsgBox("Can't build turret onto a water")
                ElseIf destinationEnvironment.entityType = EntityType.Mountain Then
                    MsgBox("Can't build turret onto a mountain")
                Else
                    Dim newTurret As Turret = New Turret(gridCoord, selectedEntity.actualCoordinate, currentPlayer.playerNum, currentPlayer.turretImageFile, currentPlayer.turretStats)
                    newTurret.createElement(Me.grid.squareSize, Game)
                    Me.grid.deleteGridCell(gridCoord)
                    Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x) = newTurret
                    currentPlayer.turrets.Add(newTurret)
                    'MsgBox("You have built at x:" & gridCoord.x & " y:" & gridCoord.y)
                    currentPlayer.playerStats.actionPoints -= Me.moveCosts.build
                    Me.updateHud(currentPlayer)
                End If
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntityType.ToString)
        End Select
    End Sub

    ''' <summary>
    ''' Selects turret that will execute a given action
    ''' </summary>
    ''' <param name="gridCoord"></param>
    Public Sub turret(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer = Me.getCurrentPlayer()
        Dim shootRange = currentPlayer.turretStats.shootRange
        currentPlayer.currentTurret = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x)
        Me.displayActionPositions(shootRange, gridCoord, GameMoves.turretShoot)
        Dim square = Me.grid.gridSquaresGrid(gridCoord.y)(gridCoord.x)
        square.setImageFile(SquareStyleEnum.Highlight)
        Game.selectedAction = GameMoves.turretShoot
    End Sub

    ''' <summary>
    ''' Turret shoots which causes damage to selected entity
    ''' </summary>
    ''' <param name="gridCoord"></param>
    Public Sub turretShoot(gridCoord As Coordinate)
        Me.grid.clearSelected()
        Dim currentPlayer As Player = Me.getCurrentPlayer()
        Dim currentTurret = currentPlayer.currentTurret
        Dim selectedEntity = Me.grid.gameElementGrid(gridCoord.y)(gridCoord.x)
        Select Case selectedEntity.entityType
            Case EntityType.Player
                Dim otherPlayer As Player = selectedEntity
                'MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit player: " & otherPlayer.playerName)
                otherPlayer.playerStats.health -= currentTurret.turretStats.attack * 5 - (otherPlayer.playerStats.armor * 0.2)
                otherPlayer.healthLabel.Text = otherPlayer.playerStats.health
                completeTurretShoot(currentPlayer)
            Case EntityType.Turret
                Dim otherTurret As Turret = selectedEntity
                'MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which has hit " & Me.players(otherTurret.playerNum).playerName & "' turret")
                otherTurret.turretStats.health -= currentTurret.turretStats.attack * 5 - (otherTurret.turretStats.armor * 0.2)
                otherTurret.healthLabel.Text = otherTurret.turretStats.health
                completeTurretShoot(currentPlayer)
            Case EntityType.Empty
                'MsgBox("You have shot at x:" & gridCoord.x & " y:" & gridCoord.y & " which is empty")
                completeTurretShoot(currentPlayer)
                Me.checkMountainAttack(gridCoord, currentPlayer)
            Case Else
                Throw New Exception("Entity type is invalid: " & selectedEntity.entityType.ToString)
        End Select
        setSquareStyle(SquareStyleEnum.Highlight, currentPlayer.gridCoordinate)
        setSquareStyle(SquareStyleEnum.Normal, currentTurret.gridCoordinate)
        currentPlayer.currentTurret = Nothing
    End Sub

    Private Sub completeTurretShoot(currentPlayer As Player)
        currentPlayer.playerStats.actionPoints -= Me.moveCosts.turretShoot
        Me.updateHud(currentPlayer)
        My.Computer.Audio.Play(InGameOptions.shootSoundEffectLocation, AudioPlayMode.Background)
    End Sub

    ''' <summary>
    ''' Checks if a player has won game
    ''' </summary>
    Public Sub checkWinCondition()
        Dim lost = 0
        Dim currentAlivePlayer As Player = Nothing
        For Each player In players
            Dim deleteTurrets = New List(Of Turret)
            For Each turret As Turret In player.turrets
                If turret.turretStats.health < 0 Then
                    Me.grid.deleteGridCell(turret.gridCoordinate)
                    deleteTurrets.Add(turret)
                    Game.Controls.Remove(turret.healthLabel)
                    turret.healthLabel = Nothing
                End If
            Next
            For Each turret As Turret In deleteTurrets
                player.turrets.Remove(turret)
            Next
            If player.playerStats.health <= 0 Then
                Me.grid.deleteGridCell(player.gridCoordinate)
                Game.Controls.Remove(player.healthLabel)
                player.healthLabel = Nothing
                lost += 1
            Else
                currentAlivePlayer = player
            End If
        Next
        If lost < playerCount - 1 Then
            'Do nothing
        ElseIf lost = playerCount - 1 Then
            MsgBox(currentAlivePlayer.playerName & " has won!!!")
        ElseIf lost = playerCount Then
            MsgBox("Nobody has won!")
        End If
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
    Public grassMove As Integer
    Public waterMove As Integer
    Public roadMove As Integer
    Public build As Integer
    Public turretShoot As Integer
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
