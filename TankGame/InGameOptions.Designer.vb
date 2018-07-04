<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InGameOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StartGameButton = New System.Windows.Forms.Button()
        Me.RowsLabel = New System.Windows.Forms.Label()
        Me.RowsInput = New System.Windows.Forms.NumericUpDown()
        Me.PlayerCountInput = New System.Windows.Forms.NumericUpDown()
        Me.PlayerLabel = New System.Windows.Forms.Label()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ImageLabel = New System.Windows.Forms.Label()
        Me.AddPlayerButton = New System.Windows.Forms.Button()
        Me.PlayerCreationGroup = New System.Windows.Forms.GroupBox()
        Me.TankTypesList = New System.Windows.Forms.ComboBox()
        Me.TankTypeLabel = New System.Windows.Forms.Label()
        Me.TankImage = New System.Windows.Forms.PictureBox()
        Me.TankImageButton = New System.Windows.Forms.Button()
        Me.GeneralGameSettingsGroup = New System.Windows.Forms.GroupBox()
        Me.ColumnsLabel = New System.Windows.Forms.Label()
        Me.ColumnsInput = New System.Windows.Forms.NumericUpDown()
        Me.GridBoxImage = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SelectionBoxImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GameStylingGroup = New System.Windows.Forms.GroupBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttackInput = New System.Windows.Forms.NumericUpDown()
        Me.ActionPointsInput = New System.Windows.Forms.NumericUpDown()
        Me.ArmorInput = New System.Windows.Forms.NumericUpDown()
        Me.AttackLabel = New System.Windows.Forms.Label()
        Me.ActionPoints = New System.Windows.Forms.Label()
        Me.ArmorLabel = New System.Windows.Forms.Label()
        Me.AvailablePointsLabel = New System.Windows.Forms.Label()
        Me.StatsGroup = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TauntInput = New System.Windows.Forms.TextBox()
        Me.TauntLabel = New System.Windows.Forms.Label()
        Me.MapImportGroup = New System.Windows.Forms.GroupBox()
        Me.ImportMapButton = New System.Windows.Forms.Button()
        CType(Me.RowsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCountInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerCreationGroup.SuspendLayout()
        CType(Me.TankImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GeneralGameSettingsGroup.SuspendLayout()
        CType(Me.ColumnsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameStylingGroup.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttackInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActionPointsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmorInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatsGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MapImportGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartGameButton
        '
        Me.StartGameButton.Location = New System.Drawing.Point(595, 618)
        Me.StartGameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartGameButton.Name = "StartGameButton"
        Me.StartGameButton.Size = New System.Drawing.Size(100, 28)
        Me.StartGameButton.TabIndex = 0
        Me.StartGameButton.Text = "Start Game"
        Me.StartGameButton.UseVisualStyleBackColor = True
        Me.StartGameButton.Visible = False
        '
        'RowsLabel
        '
        Me.RowsLabel.AutoSize = True
        Me.RowsLabel.Location = New System.Drawing.Point(22, 51)
        Me.RowsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RowsLabel.Name = "RowsLabel"
        Me.RowsLabel.Size = New System.Drawing.Size(42, 17)
        Me.RowsLabel.TabIndex = 3
        Me.RowsLabel.Text = "Rows"
        '
        'RowsInput
        '
        Me.RowsInput.Location = New System.Drawing.Point(142, 46)
        Me.RowsInput.Margin = New System.Windows.Forms.Padding(4)
        Me.RowsInput.Name = "RowsInput"
        Me.RowsInput.Size = New System.Drawing.Size(53, 22)
        Me.RowsInput.TabIndex = 6
        Me.RowsInput.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'PlayerCountInput
        '
        Me.PlayerCountInput.Location = New System.Drawing.Point(142, 145)
        Me.PlayerCountInput.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerCountInput.Name = "PlayerCountInput"
        Me.PlayerCountInput.Size = New System.Drawing.Size(49, 22)
        Me.PlayerCountInput.TabIndex = 8
        Me.PlayerCountInput.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'PlayerLabel
        '
        Me.PlayerLabel.AutoSize = True
        Me.PlayerLabel.Location = New System.Drawing.Point(22, 150)
        Me.PlayerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerLabel.Name = "PlayerLabel"
        Me.PlayerLabel.Size = New System.Drawing.Size(89, 17)
        Me.PlayerLabel.TabIndex = 9
        Me.PlayerLabel.Text = "Player Count"
        '
        'NameInput
        '
        Me.NameInput.Location = New System.Drawing.Point(240, 85)
        Me.NameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(148, 22)
        Me.NameInput.TabIndex = 11
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(289, 42)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 13
        Me.NameLabel.Text = "Name"
        '
        'ImageLabel
        '
        Me.ImageLabel.AutoSize = True
        Me.ImageLabel.Location = New System.Drawing.Point(67, 42)
        Me.ImageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ImageLabel.Name = "ImageLabel"
        Me.ImageLabel.Size = New System.Drawing.Size(46, 17)
        Me.ImageLabel.TabIndex = 15
        Me.ImageLabel.Text = "Image"
        '
        'AddPlayerButton
        '
        Me.AddPlayerButton.Location = New System.Drawing.Point(335, 261)
        Me.AddPlayerButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddPlayerButton.Name = "AddPlayerButton"
        Me.AddPlayerButton.Size = New System.Drawing.Size(100, 28)
        Me.AddPlayerButton.TabIndex = 19
        Me.AddPlayerButton.Text = "Add Player"
        Me.AddPlayerButton.UseVisualStyleBackColor = True
        '
        'PlayerCreationGroup
        '
        Me.PlayerCreationGroup.Controls.Add(Me.GroupBox1)
        Me.PlayerCreationGroup.Controls.Add(Me.StatsGroup)
        Me.PlayerCreationGroup.Location = New System.Drawing.Point(12, 244)
        Me.PlayerCreationGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerCreationGroup.Name = "PlayerCreationGroup"
        Me.PlayerCreationGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.PlayerCreationGroup.Size = New System.Drawing.Size(804, 338)
        Me.PlayerCreationGroup.TabIndex = 20
        Me.PlayerCreationGroup.TabStop = False
        Me.PlayerCreationGroup.Text = "Player Creation"
        '
        'TankTypesList
        '
        Me.TankTypesList.FormattingEnabled = True
        Me.TankTypesList.Items.AddRange(New Object() {"Light Tank", "Medium Tank", "Heavy Tank", "Blitzer", "Engineer"})
        Me.TankTypesList.Location = New System.Drawing.Point(68, 72)
        Me.TankTypesList.Name = "TankTypesList"
        Me.TankTypesList.Size = New System.Drawing.Size(121, 24)
        Me.TankTypesList.TabIndex = 32
        '
        'TankTypeLabel
        '
        Me.TankTypeLabel.AutoSize = True
        Me.TankTypeLabel.Location = New System.Drawing.Point(97, 44)
        Me.TankTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TankTypeLabel.Name = "TankTypeLabel"
        Me.TankTypeLabel.Size = New System.Drawing.Size(76, 17)
        Me.TankTypeLabel.TabIndex = 31
        Me.TankTypeLabel.Text = "Tank Type"
        '
        'TankImage
        '
        Me.TankImage.ImageLocation = ""
        Me.TankImage.Location = New System.Drawing.Point(19, 85)
        Me.TankImage.Margin = New System.Windows.Forms.Padding(4)
        Me.TankImage.Name = "TankImage"
        Me.TankImage.Size = New System.Drawing.Size(150, 150)
        Me.TankImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TankImage.TabIndex = 17
        Me.TankImage.TabStop = False
        '
        'TankImageButton
        '
        Me.TankImageButton.Location = New System.Drawing.Point(18, 261)
        Me.TankImageButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TankImageButton.Name = "TankImageButton"
        Me.TankImageButton.Size = New System.Drawing.Size(151, 28)
        Me.TankImageButton.TabIndex = 16
        Me.TankImageButton.Text = "Import Tank Image"
        Me.TankImageButton.UseVisualStyleBackColor = True
        '
        'GeneralGameSettingsGroup
        '
        Me.GeneralGameSettingsGroup.Controls.Add(Me.ColumnsLabel)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.ColumnsInput)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.RowsLabel)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.RowsInput)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.PlayerLabel)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.PlayerCountInput)
        Me.GeneralGameSettingsGroup.Location = New System.Drawing.Point(12, 12)
        Me.GeneralGameSettingsGroup.Name = "GeneralGameSettingsGroup"
        Me.GeneralGameSettingsGroup.Size = New System.Drawing.Size(341, 225)
        Me.GeneralGameSettingsGroup.TabIndex = 21
        Me.GeneralGameSettingsGroup.TabStop = False
        Me.GeneralGameSettingsGroup.Text = "General Game Settings"
        '
        'ColumnsLabel
        '
        Me.ColumnsLabel.AutoSize = True
        Me.ColumnsLabel.Location = New System.Drawing.Point(22, 101)
        Me.ColumnsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ColumnsLabel.Name = "ColumnsLabel"
        Me.ColumnsLabel.Size = New System.Drawing.Size(62, 17)
        Me.ColumnsLabel.TabIndex = 10
        Me.ColumnsLabel.Text = "Columns"
        '
        'ColumnsInput
        '
        Me.ColumnsInput.Location = New System.Drawing.Point(142, 96)
        Me.ColumnsInput.Margin = New System.Windows.Forms.Padding(4)
        Me.ColumnsInput.Name = "ColumnsInput"
        Me.ColumnsInput.Size = New System.Drawing.Size(53, 22)
        Me.ColumnsInput.TabIndex = 11
        Me.ColumnsInput.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'GridBoxImage
        '
        Me.GridBoxImage.ImageLocation = ""
        Me.GridBoxImage.Location = New System.Drawing.Point(7, 37)
        Me.GridBoxImage.Margin = New System.Windows.Forms.Padding(4)
        Me.GridBoxImage.Name = "GridBoxImage"
        Me.GridBoxImage.Size = New System.Drawing.Size(152, 130)
        Me.GridBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GridBoxImage.TabIndex = 25
        Me.GridBoxImage.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Grid Box Image"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 175)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 29)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Import Grid Box Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(223, 175)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 29)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Import Selection Box Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SelectionBoxImage
        '
        Me.SelectionBoxImage.ImageLocation = ""
        Me.SelectionBoxImage.Location = New System.Drawing.Point(223, 37)
        Me.SelectionBoxImage.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectionBoxImage.Name = "SelectionBoxImage"
        Me.SelectionBoxImage.Size = New System.Drawing.Size(152, 130)
        Me.SelectionBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SelectionBoxImage.TabIndex = 28
        Me.SelectionBoxImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Selection Box Image"
        '
        'GameStylingGroup
        '
        Me.GameStylingGroup.Controls.Add(Me.GridBoxImage)
        Me.GameStylingGroup.Controls.Add(Me.Button2)
        Me.GameStylingGroup.Controls.Add(Me.Label2)
        Me.GameStylingGroup.Controls.Add(Me.SelectionBoxImage)
        Me.GameStylingGroup.Controls.Add(Me.Button1)
        Me.GameStylingGroup.Controls.Add(Me.Label1)
        Me.GameStylingGroup.Location = New System.Drawing.Point(372, 12)
        Me.GameStylingGroup.Name = "GameStylingGroup"
        Me.GameStylingGroup.Size = New System.Drawing.Size(444, 225)
        Me.GameStylingGroup.TabIndex = 30
        Me.GameStylingGroup.TabStop = False
        Me.GameStylingGroup.Text = "Game Styling"
        '
        'AttackInput
        '
        Me.AttackInput.Location = New System.Drawing.Point(192, 165)
        Me.AttackInput.Margin = New System.Windows.Forms.Padding(4)
        Me.AttackInput.Name = "AttackInput"
        Me.AttackInput.Size = New System.Drawing.Size(49, 22)
        Me.AttackInput.TabIndex = 31
        Me.AttackInput.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ActionPointsInput
        '
        Me.ActionPointsInput.Location = New System.Drawing.Point(192, 215)
        Me.ActionPointsInput.Margin = New System.Windows.Forms.Padding(4)
        Me.ActionPointsInput.Name = "ActionPointsInput"
        Me.ActionPointsInput.Size = New System.Drawing.Size(49, 22)
        Me.ActionPointsInput.TabIndex = 33
        Me.ActionPointsInput.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ArmorInput
        '
        Me.ArmorInput.Location = New System.Drawing.Point(192, 269)
        Me.ArmorInput.Margin = New System.Windows.Forms.Padding(4)
        Me.ArmorInput.Name = "ArmorInput"
        Me.ArmorInput.Size = New System.Drawing.Size(49, 22)
        Me.ArmorInput.TabIndex = 34
        Me.ArmorInput.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'AttackLabel
        '
        Me.AttackLabel.AutoSize = True
        Me.AttackLabel.Location = New System.Drawing.Point(54, 170)
        Me.AttackLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AttackLabel.Name = "AttackLabel"
        Me.AttackLabel.Size = New System.Drawing.Size(47, 17)
        Me.AttackLabel.TabIndex = 35
        Me.AttackLabel.Text = "Attack"
        '
        'ActionPoints
        '
        Me.ActionPoints.AutoSize = True
        Me.ActionPoints.Location = New System.Drawing.Point(54, 220)
        Me.ActionPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ActionPoints.Name = "ActionPoints"
        Me.ActionPoints.Size = New System.Drawing.Size(49, 17)
        Me.ActionPoints.TabIndex = 36
        Me.ActionPoints.Text = "Speed"
        '
        'ArmorLabel
        '
        Me.ArmorLabel.AutoSize = True
        Me.ArmorLabel.Location = New System.Drawing.Point(55, 274)
        Me.ArmorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ArmorLabel.Name = "ArmorLabel"
        Me.ArmorLabel.Size = New System.Drawing.Size(46, 17)
        Me.ArmorLabel.TabIndex = 37
        Me.ArmorLabel.Text = "Armor"
        '
        'AvailablePointsLabel
        '
        Me.AvailablePointsLabel.AutoSize = True
        Me.AvailablePointsLabel.Location = New System.Drawing.Point(54, 135)
        Me.AvailablePointsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AvailablePointsLabel.Name = "AvailablePointsLabel"
        Me.AvailablePointsLabel.Size = New System.Drawing.Size(116, 17)
        Me.AvailablePointsLabel.TabIndex = 38
        Me.AvailablePointsLabel.Text = "Available Points: "
        '
        'StatsGroup
        '
        Me.StatsGroup.Controls.Add(Me.AttackLabel)
        Me.StatsGroup.Controls.Add(Me.AvailablePointsLabel)
        Me.StatsGroup.Controls.Add(Me.TankTypesList)
        Me.StatsGroup.Controls.Add(Me.TankTypeLabel)
        Me.StatsGroup.Controls.Add(Me.AttackInput)
        Me.StatsGroup.Controls.Add(Me.ArmorLabel)
        Me.StatsGroup.Controls.Add(Me.ActionPointsInput)
        Me.StatsGroup.Controls.Add(Me.ActionPoints)
        Me.StatsGroup.Controls.Add(Me.ArmorInput)
        Me.StatsGroup.Location = New System.Drawing.Point(494, 20)
        Me.StatsGroup.Name = "StatsGroup"
        Me.StatsGroup.Size = New System.Drawing.Size(303, 311)
        Me.StatsGroup.TabIndex = 39
        Me.StatsGroup.TabStop = False
        Me.StatsGroup.Text = "Tank Options"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TauntLabel)
        Me.GroupBox1.Controls.Add(Me.TauntInput)
        Me.GroupBox1.Controls.Add(Me.TankImage)
        Me.GroupBox1.Controls.Add(Me.ImageLabel)
        Me.GroupBox1.Controls.Add(Me.AddPlayerButton)
        Me.GroupBox1.Controls.Add(Me.NameInput)
        Me.GroupBox1.Controls.Add(Me.TankImageButton)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 311)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appearance"
        '
        'TauntInput
        '
        Me.TauntInput.Location = New System.Drawing.Point(240, 212)
        Me.TauntInput.Margin = New System.Windows.Forms.Padding(4)
        Me.TauntInput.Name = "TauntInput"
        Me.TauntInput.Size = New System.Drawing.Size(148, 22)
        Me.TauntInput.TabIndex = 20
        '
        'TauntLabel
        '
        Me.TauntLabel.AutoSize = True
        Me.TauntLabel.Location = New System.Drawing.Point(289, 168)
        Me.TauntLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TauntLabel.Name = "TauntLabel"
        Me.TauntLabel.Size = New System.Drawing.Size(45, 17)
        Me.TauntLabel.TabIndex = 21
        Me.TauntLabel.Text = "Taunt"
        '
        'MapImportGroup
        '
        Me.MapImportGroup.Controls.Add(Me.ImportMapButton)
        Me.MapImportGroup.Location = New System.Drawing.Point(12, 581)
        Me.MapImportGroup.Name = "MapImportGroup"
        Me.MapImportGroup.Size = New System.Drawing.Size(488, 75)
        Me.MapImportGroup.TabIndex = 31
        Me.MapImportGroup.TabStop = False
        Me.MapImportGroup.Text = "Map Import"
        '
        'ImportMapButton
        '
        Me.ImportMapButton.Location = New System.Drawing.Point(25, 28)
        Me.ImportMapButton.Name = "ImportMapButton"
        Me.ImportMapButton.Size = New System.Drawing.Size(189, 37)
        Me.ImportMapButton.TabIndex = 0
        Me.ImportMapButton.Text = "Import Map (Optional)"
        Me.ImportMapButton.UseVisualStyleBackColor = True
        '
        'InGameOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 663)
        Me.Controls.Add(Me.MapImportGroup)
        Me.Controls.Add(Me.GameStylingGroup)
        Me.Controls.Add(Me.GeneralGameSettingsGroup)
        Me.Controls.Add(Me.PlayerCreationGroup)
        Me.Controls.Add(Me.StartGameButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InGameOptions"
        Me.Text = "InGameOptions"
        CType(Me.RowsInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCountInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayerCreationGroup.ResumeLayout(False)
        CType(Me.TankImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GeneralGameSettingsGroup.ResumeLayout(False)
        Me.GeneralGameSettingsGroup.PerformLayout()
        CType(Me.ColumnsInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameStylingGroup.ResumeLayout(False)
        Me.GameStylingGroup.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttackInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActionPointsInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmorInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatsGroup.ResumeLayout(False)
        Me.StatsGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MapImportGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartGameButton As Button
    Friend WithEvents RowsLabel As Label
    Friend WithEvents RowsInput As NumericUpDown
    Friend WithEvents PlayerCountInput As NumericUpDown
    Friend WithEvents PlayerLabel As Label
    Friend WithEvents NameInput As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents ImageLabel As Label
    Friend WithEvents AddPlayerButton As Button
    Friend WithEvents PlayerCreationGroup As GroupBox
    Friend WithEvents TankImageButton As Button
    Friend WithEvents TankImage As PictureBox
    Friend WithEvents GeneralGameSettingsGroup As GroupBox
    Friend WithEvents GridBoxImage As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SelectionBoxImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GameStylingGroup As GroupBox
    Friend WithEvents ColumnsLabel As Label
    Friend WithEvents ColumnsInput As NumericUpDown
    Friend WithEvents TankTypeLabel As Label
    Friend WithEvents TankTypesList As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TauntLabel As Label
    Friend WithEvents TauntInput As TextBox
    Friend WithEvents StatsGroup As GroupBox
    Friend WithEvents AttackLabel As Label
    Friend WithEvents AvailablePointsLabel As Label
    Friend WithEvents AttackInput As NumericUpDown
    Friend WithEvents ArmorLabel As Label
    Friend WithEvents ActionPointsInput As NumericUpDown
    Friend WithEvents ActionPoints As Label
    Friend WithEvents ArmorInput As NumericUpDown
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MapImportGroup As GroupBox
    Friend WithEvents ImportMapButton As Button
End Class
