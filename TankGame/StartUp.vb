Public Class StartUp
    Private Sub StartGameButton_Click(sender As Object, e As EventArgs) Handles StartGameButton.Click
        InGameOptions.Show()
        Me.Hide()
    End Sub

    Private Sub StartUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Game.Size = New System.Drawing.Size(screenWidth * 0.5, screenHeight * 0.5)
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        QuickStart.Show()
        Me.Hide()
    End Sub
End Class