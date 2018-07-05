Imports System.ComponentModel

Public Class InGameOptions
    Public players As New List(Of Player)
    Public currentPlayerNum = 0
    Public defaultTankLocation = Application.StartupPath() & "\resources\tank.jpg"
    Public defaultGridBoxLocation = Application.StartupPath() & "\resources\tile.jpg"
    Public defaultSelectionBoxLocation = Application.StartupPath() & "\resources\red.jpg"
    Public defaultHighLightBoxLocation = Application.StartupPath() & "\resources\green.jpg"
    Public gameInfo As GameInformation
    Public squareImages As SquareImages

    Private Sub InGameOptions_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StartUp.Close()
    End Sub

    Private Sub StartGameButton_Click(sender As Object, e As EventArgs) Handles StartGameButton.Click
        If Me.players.Count <> Me.PlayerCountInput.Value Then
            MsgBox("Not all players have been registered!")
        Else
            Me.gameInfo.players = Me.players
            Me.gameInfo.playerCount = Me.PlayerCountInput.Value
            Me.gameInfo.rows = Me.RowsInput.Value
            Me.gameInfo.cols = Me.ColumnsInput.Value
            Me.squareImages.normalImage = Image.FromFile(GridBoxImage.ImageLocation)
            Me.squareImages.selectedImage = Image.FromFile(SelectedBoxImage.ImageLocation)
            Me.squareImages.highLightedImage = Image.FromFile(HighLightImageBox.ImageLocation)
            Dim gameCore = New GameCore(Me.gameInfo, Me.squareImages)
            Game.loadGameCore(gameCore)
            Game.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AddPlayerButton_Click(sender As Object, e As EventArgs) Handles AddPlayerButton.Click
        If (currentPlayerNum > Me.PlayerCountInput.Value - 1) Then
            MsgBox("Player Count Specified has been exceeded")
        Else
            Dim currentPlayer = New Player(New Coordinate(0, 0), New Coordinate(0, 0), Me.currentPlayerNum, Image.FromFile(TankImage.ImageLocation), Me.NameInput.Text, getCurrentPlayerStats())
            Me.players.Add(currentPlayer)
            Me.currentPlayerNum += 1
            Me.NameInput.Text = ""
            If Me.currentPlayerNum = Me.PlayerCountInput.Value Then
                StartGameButton.Show()
                AddPlayerButton.Hide()
                StartPromptText.Hide()
            End If
        End If
    End Sub

    Private Function getCurrentPlayerStats()
        Return New PlayerStats
    End Function

    Private Sub TankImageButton_Click(sender As Object, e As EventArgs) Handles TankImageButton.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "JPG Files|*.jpg"
        fileDialog.Title = "Select a JPG file"
        If fileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TankImage.ImageLocation = fileDialog.FileName
        End If
    End Sub

    Private Sub InGameOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TankImage.ImageLocation = Me.defaultTankLocation
        GridBoxImage.ImageLocation = Me.defaultGridBoxLocation
        SelectedBoxImage.ImageLocation = Me.defaultSelectionBoxLocation
        HighLightImageBox.ImageLocation = Me.defaultHighLightBoxLocation
    End Sub

    Private Sub RowsInput_Validating(sender As Object, e As CancelEventArgs) Handles RowsInput.Validating
        Dim inputVal As Integer = RowsInput.Value
        If inputVal < 5 Or inputVal > 40 Then
            MessageBox.Show("The value you entered is outside the valid range. Please correct.")
            e.Cancel = True
        End If
    End Sub

    Private Sub ColumnsInput_Validating(sender As Object, e As CancelEventArgs) Handles ColumnsInput.Validating
        Dim inputVal As Integer = ColumnsInput.Value
        If inputVal < 5 Or inputVal > 40 Then
            MessageBox.Show("The value you entered is outside the valid range. Please correct.")
            e.Cancel = True
        End If
    End Sub

    Private Sub GridBoxButton_Click(sender As Object, e As EventArgs) Handles GridBoxButton.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "JPG Files|*.jpg"
        fileDialog.Title = "Select a JPG file"
        If fileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            GridBoxImage.ImageLocation = fileDialog.FileName
        End If
    End Sub

    Private Sub SelectionBoxButton_Click(sender As Object, e As EventArgs) Handles SelectedBoxButton.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "JPG Files|*.jpg"
        fileDialog.Title = "Select a JPG file"
        If fileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            SelectedBoxImage.ImageLocation = fileDialog.FileName
        End If
    End Sub

    Private Sub HighLightBoxButton_Click(sender As Object, e As EventArgs) Handles HighLightBoxButton.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "JPG Files|*.jpg"
        fileDialog.Title = "Select a JPG file"
        If fileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            HighLightImageBox.ImageLocation = fileDialog.FileName
        End If
    End Sub

    Private Sub TeamsModeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles TeamsModeCheck.CheckedChanged
        TeamModeText.Visible = Not TeamModeText.Visible
        TeamList.Visible = Not TeamList.Visible
    End Sub
End Class