Public Class Game
    Public currentGame As GameCore
    Public selectedAction As String
    Public gameKeyMapping As GameKeyMapping


    Public Sub loadGameCore(currentGame As GameCore)
        Me.currentGame = currentGame
        Me.gameKeyMapping.shoot = "q"
        Me.gameKeyMapping.move = "w"
        Me.gameKeyMapping.build = "e"
        Me.gameKeyMapping.turret = "r"
        Me.gameKeyMapping.endTurn = "t"
    End Sub

    Private Sub Game_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StartUp.Show()
    End Sub

    Private Sub EndTurnButton_Click(sender As Object, e As EventArgs) Handles EndTurnButton.Click
        Me.currentGame.startTurn()
    End Sub

    Public Sub handleMove(move As GameMoves)
        Dim currentPlayerStats = Me.currentGame.getCurrentPlayer().playerStats
        Select Case move
            Case GameMoves.shoot
                If currentPlayerStats.actionPoints < Me.currentGame.moveCosts.shoot Then
                    MsgBox("Not enough action points")
                Else
                    setUpAction(currentPlayerStats.shootRange, move)
                End If
            Case GameMoves.move
                If currentPlayerStats.actionPoints < Me.currentGame.moveCosts.move Then
                    MsgBox("Not enough action points")
                Else
                    setUpAction(currentPlayerStats.moveRange, move)
                End If
            Case GameMoves.build
                If currentPlayerStats.actionPoints < Me.currentGame.moveCosts.build Then
                    MsgBox("Not enough action points")
                Else
                    setUpAction(currentPlayerStats.buildRange, move)
                End If
            Case GameMoves.turret
                Me.currentGame.displayPossibleTurrets()
                Me.selectedAction = move
            Case Else
                MsgBox("Move is invalid")
        End Select
    End Sub

    Public Sub setUpAction(range As Integer, move As GameMoves)
        Me.currentGame.displayActionPositions(range)
        Me.selectedAction = move
    End Sub

    Private Sub ShootButton_Click(sender As Object, e As EventArgs) Handles ShootButton.Click
        Me.handleMove(GameMoves.shoot)
    End Sub

    Private Sub MoveButton_Click(sender As Object, e As EventArgs) Handles MoveButton.Click
        Me.handleMove(GameMoves.move)
    End Sub

    Private Sub BuildButton_Click(sender As Object, e As EventArgs) Handles BuildButton.Click
        Me.handleMove(GameMoves.build)
    End Sub

    Private Sub TurretButton_Click(sender As Object, e As EventArgs) Handles TurretButton.Click
        Me.handleMove(GameMoves.turret)
    End Sub

    Public Sub executeAction(selectedCoord As Coordinate)
        Select Case Me.selectedAction
            Case GameMoves.shoot
                Me.currentGame.shoot(selectedCoord)
            Case GameMoves.move
                Me.currentGame.move(selectedCoord)
            Case GameMoves.build
                Me.currentGame.build(selectedCoord)
            Case GameMoves.turret
                Me.currentGame.turret(selectedCoord) 'Displays turret actions
            Case GameMoves.turretShoot
                Me.currentGame.turretShoot(selectedCoord) 'Turret Shoots
            Case Else
                MsgBox("Action was not selected")
        End Select
    End Sub

    Private Sub Game_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "q"
                Me.handleMove(GameMoves.shoot)
            Case "w"
                Me.handleMove(GameMoves.move)
            Case "e"
                Me.handleMove(GameMoves.build)
            Case "r"
                Me.handleMove(GameMoves.turret)
            Case "t"
                Me.currentGame.startTurn()
        End Select
    End Sub

    Public Enum GameMoves
        shoot
        move
        build
        turret
        turretShoot
    End Enum
End Class

Public Structure GameKeyMapping
    Public shoot As Char
    Public move As Char
    Public build As Char
    Public turret As Char
    Public endTurn As Char
End Structure

