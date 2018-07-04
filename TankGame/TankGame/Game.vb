Public Class Game
    Public currentGame As GameCore
    Public selectedAction As String

    Public Sub loadGameCore(currentGame As GameCore)
        Me.currentGame = currentGame
    End Sub

    Private Sub Game_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StartUp.Show()
    End Sub

    Private Sub EndTurnButton_Click(sender As Object, e As EventArgs) Handles EndTurnButton.Click
        Me.currentGame.startTurn()
    End Sub

    Private Sub ShootButton_Click(sender As Object, e As EventArgs) Handles ShootButton.Click
        Dim range = Me.currentGame.getCurrentPlayer().shootRange
        Me.currentGame.displayActionPositions(range)
        Me.selectedAction = "shoot"
    End Sub

    Private Sub MoveButton_Click(sender As Object, e As EventArgs) Handles MoveButton.Click
        Dim range = Me.currentGame.getCurrentPlayer().moveRange
        Me.currentGame.displayActionPositions(range)
        Me.selectedAction = "move"
    End Sub

    Private Sub BuildButton_Click(sender As Object, e As EventArgs) Handles BuildButton.Click
        Dim range = Me.currentGame.getCurrentPlayer().buildRange
        Me.currentGame.displayActionPositions(range)
        Me.selectedAction = "build"
    End Sub

    Private Sub TurretButton_Click(sender As Object, e As EventArgs) Handles TurretButton.Click
        Dim range = Me.currentGame.getCurrentPlayer().turretRange
        Me.currentGame.displayActionPositions(range)
        Me.selectedAction = "turret"
    End Sub

    Public Sub executeAction(selectedCoord As Coordinate)
        Select Case Me.selectedAction
            Case "shoot"
                Me.currentGame.shoot(selectedCoord)
            Case "move"
                Me.currentGame.move(selectedCoord)
            Case "build"
                Me.currentGame.build(selectedCoord)
            Case "turret"
                Me.currentGame.turret(selectedCoord)
            Case Else
                MsgBox("Action was not selected")
        End Select

    End Sub
End Class
