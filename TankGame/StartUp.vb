Public Class StartUp
    Private Sub StartGameButton_Click(sender As Object, e As EventArgs) Handles StartGameButton.Click
        InGameOptions.Show()
        Me.Hide()
    End Sub
End Class