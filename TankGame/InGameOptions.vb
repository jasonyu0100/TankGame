Imports System.ComponentModel

Public Class InGameOptions
    Public players As New List(Of Player)
    Public currentPlayerNum = 0
    Public defaultTankLocation = Application.StartupPath() & "\resources\tank.jpg"
    Public defaultGridBoxLocation = Application.StartupPath() & "\resources\tile.jpg"
    Public defaultSelectionBoxLocation = Application.StartupPath() & "\resources\red.jpg"
    Public gameInfo As GameInformation

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
            Dim gameCore = New GameCore(Me.gameInfo)
            Game.loadGameCore(gameCore)
            Game.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AddPlayerButton_Click(sender As Object, e As EventArgs) Handles AddPlayerButton.Click
        If (currentPlayerNum > Me.PlayerCountInput.Value - 1) Then
            MsgBox("Player Count Specified has been exceeded")
        Else
            Dim currentPlayer = New Player(New Coordinate(0, 0), New Coordinate(0, 0), Me.currentPlayerNum, Image.FromFile(TankImage.ImageLocation), Me.NameInput.Text)
            Me.players.Add(currentPlayer)
            Me.currentPlayerNum += 1
            Me.NameInput.Text = ""
            If Me.currentPlayerNum = Me.PlayerCountInput.Value Then
                StartGameButton.Show()
                AddPlayerButton.Hide()
            End If
        End If
    End Sub

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
        SelectionBoxImage.ImageLocation = Me.defaultSelectionBoxLocation
        Me.gameInfo.gridBoxImage = GridBoxImage.ImageLocation
        Me.gameInfo.selectionBoxImage = SelectionBoxImage.ImageLocation
    End Sub

    Private Sub RowsInput_ValueChanged(sender As Object, e As EventArgs) Handles RowsInput.ValueChanged

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

End Class

Public Structure GameInformation
    Public gridBoxImage As String
    Public selectionBoxImage As String
    Public players As List(Of Player)
    Public playerCount As Integer
    Public rows As Integer
    Public cols As Integer
End Structure