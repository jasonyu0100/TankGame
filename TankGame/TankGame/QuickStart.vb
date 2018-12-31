Public Class QuickStart
    Public tutorialImage = Application.StartupPath() & "\resources\Images\tut.png"
    Private Sub QuickStart_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StartUp.Show()
    End Sub

    Private Sub QuickStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = tutorialImage
    End Sub
End Class