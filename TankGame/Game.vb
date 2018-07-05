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

    Private Sub handleMove(move As GameMoves)
        Dim range = Me.currentGame.getCurrentPlayer().shootRange
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
                Me.currentGame.turret(selectedCoord)
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

    Private Enum GameMoves
        shoot
        move
        build
        turret
    End Enum
End Class

Public Structure GameKeyMapping
    Public shoot As Char
    Public move As Char
    Public build As Char
    Public turret As Char
    Public endTurn As Char
End Structure

