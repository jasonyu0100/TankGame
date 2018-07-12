Imports System.ComponentModel

Public Class InGameOptions
    Public players As New List(Of Player)
    Public currentPlayerNum = 0
    Public defaultTankLocation = Application.StartupPath() & "\resources\tank.jpg"
    Public defaultTurretLocation = Application.StartupPath() & "\resources\turret.jpg"
    Public defaultGridBoxLocation = Application.StartupPath() & "\resources\tile.jpg"
    Public defaultSelectionBoxLocation = Application.StartupPath() & "\resources\red.jpg"
    Public defaultHighLightBoxLocation = Application.StartupPath() & "\resources\green.jpg"
    Public gameInfo As GameInformation
    Public squareImages As SquareImages
    Public moveCosts As MoveCosts
    'Constants
    Public defaultShootCost = 4
    Public defaultMoveCost = 4
    Public defaultBuildCost = 4
    Public defaultTurretCost = 4
    Public defaultStatPoints = 18
    Public defaultAttack = 5
    Public defaultArmor = 5
    Public defaultSpeed = 5
    Public defaultActionPoints = 8

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
            Me.gameInfo.moveCosts = Me.moveCosts
            Me.gameInfo.actionPoints = Me.defaultActionPoints
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
            Dim currentPlayer = New Player(New Coordinate(0, 0), New Coordinate(0, 0), Me.currentPlayerNum, Image.FromFile(TankImage.ImageLocation), Me.NameInput.Text, Me.getCurrentPlayerStats(), Me.getCurrentTurretStats(), Image.FromFile(TurretImage.ImageLocation))
            Me.players.Add(currentPlayer)
            Me.currentPlayerNum += 1
            Me.NameInput.Text = ""
            Me.resetStats()
            If Me.currentPlayerNum = Me.PlayerCountInput.Value Then
                StartGameButton.Show()
                AddPlayerButton.Hide()
                StartPromptText.Hide()
            End If
        End If
    End Sub

    Private Sub resetStats()
        Me.AttackInput.Value = Me.defaultAttack
        Me.ArmorInput.Value = Me.defaultArmor
        Me.SpeedInput.Value = Me.defaultSpeed
        Me.AvailablePointsLabel.Text = "Available Points: " & Me.defaultStatPoints - (Me.AttackInput.Value + Me.ArmorInput.Value + Me.SpeedInput.Value)
    End Sub

    Private Function getCurrentPlayerStats()
        Dim currentPlayerStats = New PlayerStats
        currentPlayerStats.health = 100
        currentPlayerStats.attack = Me.AttackInput.Value
        currentPlayerStats.speed = Me.SpeedInput.Value
        currentPlayerStats.armor = Me.ArmorInput.Value
        currentPlayerStats.shootRange = 5
        currentPlayerStats.moveRange = 3
        currentPlayerStats.buildRange = 1
        currentPlayerStats.turretRange = Nothing
        currentPlayerStats.actionPoints = Me.defaultActionPoints
        Return currentPlayerStats
    End Function

    Private Function getCurrentTurretStats()
        Dim currentTurretStats = New TurretStats
        currentTurretStats.health = 20
        currentTurretStats.attack = 5
        currentTurretStats.shootRange = 4
        Return currentTurretStats
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
        TurretImage.ImageLocation = Me.defaultTurretLocation
        GridBoxImage.ImageLocation = Me.defaultGridBoxLocation
        SelectedBoxImage.ImageLocation = Me.defaultSelectionBoxLocation
        HighLightImageBox.ImageLocation = Me.defaultHighLightBoxLocation
        Me.moveCosts.shoot = defaultShootCost
        Me.moveCosts.move = defaultMoveCost
        Me.moveCosts.build = defaultBuildCost
        Me.moveCosts.turret = defaultTurretCost

        Me.AttackInput.Value = Me.defaultAttack
        Me.ArmorInput.Value = Me.defaultArmor
        Me.SpeedInput.Value = Me.defaultSpeed
        Me.AvailablePointsLabel.Text = "Available Points: " & Me.defaultStatPoints - (Me.AttackInput.Value + Me.ArmorInput.Value + Me.SpeedInput.Value)
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

    Private Sub PlayerCountInput_ValueChanged(sender As Object, e As EventArgs) Handles PlayerCountInput.ValueChanged
        Me.currentPlayerNum = 0
        Me.players = New List(Of Player)
        StartGameButton.Hide()
        AddPlayerButton.Show()
        StartPromptText.Show()
    End Sub


    Private Sub AttackInput_Validating(sender As Object, e As CancelEventArgs) Handles AttackInput.Validating
        Dim newTotal = sender.value + SpeedInput.Value + ArmorInput.Value
        If newTotal > Me.defaultStatPoints Then
            MsgBox("Not enough stat points")
            e.Cancel = True
        ElseIf (sender.value < Me.defaultAttack) Then
            MsgBox("Minimum points exceeded")
            e.Cancel = True
        Else
            Me.AvailablePointsLabel.Text = "Available Points: " & Me.defaultStatPoints - (Me.AttackInput.Value + Me.ArmorInput.Value + Me.SpeedInput.Value)
        End If
    End Sub

    Private Sub SpeedInput_Validating(sender As Object, e As CancelEventArgs) Handles SpeedInput.Validating
        Dim newTotal = sender.value + AttackInput.Value + ArmorInput.Value
        If newTotal > Me.defaultStatPoints Then
            MsgBox("Not enough stat points")
            e.Cancel = True
        ElseIf (sender.value < Me.defaultSpeed) Then
            MsgBox("Minimum points exceeded")
            e.Cancel = True
        Else
            Me.AvailablePointsLabel.Text = "Available Points: " & Me.defaultStatPoints - (Me.AttackInput.Value + Me.ArmorInput.Value + Me.SpeedInput.Value)
        End If
    End Sub

    Private Sub ArmorInput_Validating(sender As Object, e As CancelEventArgs) Handles ArmorInput.Validating
        Dim newTotal = sender.value + SpeedInput.Value + AttackInput.Value
        If newTotal > Me.defaultStatPoints Then
            MsgBox("Not enough stat points")
            e.Cancel = True
        ElseIf (sender.value < Me.defaultArmor) Then
            MsgBox("Minimum points exceeded")
            e.Cancel = True
        Else
            Me.AvailablePointsLabel.Text = "Available Points: " & Me.defaultStatPoints - (Me.AttackInput.Value + Me.ArmorInput.Value + Me.SpeedInput.Value)
        End If
    End Sub

    Private Sub TurretImageButton_Click(sender As Object, e As EventArgs) Handles TurretImageButton.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "JPG Files|*.jpg"
        fileDialog.Title = "Select a JPG file"
        If fileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TurretImage.ImageLocation = fileDialog.FileName
        End If
    End Sub
End Class

Public Structure MoveCosts
    Public shoot As Integer
    Public move As Integer
    Public turret As Integer
    Public build As Integer
End Structure