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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TeamModeText = New System.Windows.Forms.Label()
        Me.TeamList = New System.Windows.Forms.ComboBox()
        Me.TeamLabel = New System.Windows.Forms.Label()
        Me.TankImage = New System.Windows.Forms.PictureBox()
        Me.TankImageButton = New System.Windows.Forms.Button()
        Me.StatsGroup = New System.Windows.Forms.GroupBox()
        Me.AttackLabel = New System.Windows.Forms.Label()
        Me.AvailablePointsLabel = New System.Windows.Forms.Label()
        Me.TankTypesList = New System.Windows.Forms.ComboBox()
        Me.TankTypeLabel = New System.Windows.Forms.Label()
        Me.AttackInput = New System.Windows.Forms.NumericUpDown()
        Me.ArmorLabel = New System.Windows.Forms.Label()
        Me.SpeedInput = New System.Windows.Forms.NumericUpDown()
        Me.SpeedLabel = New System.Windows.Forms.Label()
        Me.ArmorInput = New System.Windows.Forms.NumericUpDown()
        Me.GeneralGameSettingsGroup = New System.Windows.Forms.GroupBox()
        Me.GridInfoLabel = New System.Windows.Forms.Label()
        Me.ColumnsLabel = New System.Windows.Forms.Label()
        Me.ColumnsInput = New System.Windows.Forms.NumericUpDown()
        Me.GridBoxImage = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridBoxButton = New System.Windows.Forms.Button()
        Me.SelectedBoxButton = New System.Windows.Forms.Button()
        Me.SelectedBoxImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GameStylingGroup = New System.Windows.Forms.GroupBox()
        Me.HighLightBoxButton = New System.Windows.Forms.Button()
        Me.HighLightImageBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportMapButton = New System.Windows.Forms.Button()
        Me.GameplaySettingsGroup = New System.Windows.Forms.GroupBox()
        Me.ImportMapLabel = New System.Windows.Forms.Label()
        Me.TeamModeLabel = New System.Windows.Forms.Label()
        Me.NoBuildingLabel = New System.Windows.Forms.Label()
        Me.NoTurretLabel = New System.Windows.Forms.Label()
        Me.EnvironmentModeLabel = New System.Windows.Forms.Label()
        Me.BlitzText = New System.Windows.Forms.Label()
        Me.TeamsModeCheck = New System.Windows.Forms.CheckBox()
        Me.AntiFortniteModeCheck = New System.Windows.Forms.CheckBox()
        Me.GunSlingerModeCheck = New System.Windows.Forms.CheckBox()
        Me.EnvironmentalModeCheck = New System.Windows.Forms.CheckBox()
        Me.BlizModeCheck = New System.Windows.Forms.CheckBox()
        Me.StartPromptText = New System.Windows.Forms.Label()
        Me.TurretImage = New System.Windows.Forms.PictureBox()
        Me.TurretImageButton = New System.Windows.Forms.Button()
        CType(Me.RowsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCountInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerCreationGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TankImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatsGroup.SuspendLayout()
        CType(Me.AttackInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeedInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmorInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GeneralGameSettingsGroup.SuspendLayout()
        CType(Me.ColumnsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameStylingGroup.SuspendLayout()
        CType(Me.HighLightImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameplaySettingsGroup.SuspendLayout()
        CType(Me.TurretImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartGameButton
        '
        Me.StartGameButton.Location = New System.Drawing.Point(869, 548)
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
        Me.RowsInput.Location = New System.Drawing.Point(119, 46)
        Me.RowsInput.Margin = New System.Windows.Forms.Padding(4)
        Me.RowsInput.Name = "RowsInput"
        Me.RowsInput.Size = New System.Drawing.Size(53, 22)
        Me.RowsInput.TabIndex = 6
        Me.RowsInput.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'PlayerCountInput
        '
        Me.PlayerCountInput.Location = New System.Drawing.Point(119, 145)
        Me.PlayerCountInput.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerCountInput.Name = "PlayerCountInput"
        Me.PlayerCountInput.Size = New System.Drawing.Size(49, 22)
        Me.PlayerCountInput.TabIndex = 8
        Me.PlayerCountInput.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'PlayerLabel
        '
        Me.PlayerLabel.AutoSize = True
        Me.PlayerLabel.Location = New System.Drawing.Point(17, 147)
        Me.PlayerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerLabel.Name = "PlayerLabel"
        Me.PlayerLabel.Size = New System.Drawing.Size(89, 17)
        Me.PlayerLabel.TabIndex = 9
        Me.PlayerLabel.Text = "Player Count"
        '
        'NameInput
        '
        Me.NameInput.Location = New System.Drawing.Point(101, 23)
        Me.NameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(164, 22)
        Me.NameInput.TabIndex = 11
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(31, 27)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 13
        Me.NameLabel.Text = "Name"
        '
        'ImageLabel
        '
        Me.ImageLabel.AutoSize = True
        Me.ImageLabel.Location = New System.Drawing.Point(31, 90)
        Me.ImageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ImageLabel.Name = "ImageLabel"
        Me.ImageLabel.Size = New System.Drawing.Size(82, 17)
        Me.ImageLabel.TabIndex = 15
        Me.ImageLabel.Text = "Tank Image"
        '
        'AddPlayerButton
        '
        Me.AddPlayerButton.Location = New System.Drawing.Point(438, 260)
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
        Me.PlayerCreationGroup.Controls.Add(Me.AddPlayerButton)
        Me.PlayerCreationGroup.Location = New System.Drawing.Point(431, 211)
        Me.PlayerCreationGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerCreationGroup.Name = "PlayerCreationGroup"
        Me.PlayerCreationGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.PlayerCreationGroup.Size = New System.Drawing.Size(578, 329)
        Me.PlayerCreationGroup.TabIndex = 20
        Me.PlayerCreationGroup.TabStop = False
        Me.PlayerCreationGroup.Text = "Player Creation"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TurretImageButton)
        Me.GroupBox1.Controls.Add(Me.TurretImage)
        Me.GroupBox1.Controls.Add(Me.TeamModeText)
        Me.GroupBox1.Controls.Add(Me.TeamList)
        Me.GroupBox1.Controls.Add(Me.TeamLabel)
        Me.GroupBox1.Controls.Add(Me.TankImage)
        Me.GroupBox1.Controls.Add(Me.ImageLabel)
        Me.GroupBox1.Controls.Add(Me.NameInput)
        Me.GroupBox1.Controls.Add(Me.TankImageButton)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 302)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appearance"
        '
        'TeamModeText
        '
        Me.TeamModeText.Location = New System.Drawing.Point(98, 49)
        Me.TeamModeText.Name = "TeamModeText"
        Me.TeamModeText.Size = New System.Drawing.Size(181, 36)
        Me.TeamModeText.TabIndex = 37
        Me.TeamModeText.Text = "Optionally Select Team Mode"
        '
        'TeamList
        '
        Me.TeamList.Cursor = System.Windows.Forms.Cursors.Default
        Me.TeamList.FormattingEnabled = True
        Me.TeamList.Items.AddRange(New Object() {"Light Tank", "Medium Tank", "Heavy Tank", "Blitzer", "Engineer"})
        Me.TeamList.Location = New System.Drawing.Point(101, 56)
        Me.TeamList.Name = "TeamList"
        Me.TeamList.Size = New System.Drawing.Size(165, 24)
        Me.TeamList.TabIndex = 33
        Me.TeamList.Visible = False
        '
        'TeamLabel
        '
        Me.TeamLabel.AutoSize = True
        Me.TeamLabel.Location = New System.Drawing.Point(31, 56)
        Me.TeamLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TeamLabel.Name = "TeamLabel"
        Me.TeamLabel.Size = New System.Drawing.Size(44, 17)
        Me.TeamLabel.TabIndex = 20
        Me.TeamLabel.Text = "Team"
        '
        'TankImage
        '
        Me.TankImage.ImageLocation = ""
        Me.TankImage.Location = New System.Drawing.Point(7, 118)
        Me.TankImage.Margin = New System.Windows.Forms.Padding(4)
        Me.TankImage.Name = "TankImage"
        Me.TankImage.Size = New System.Drawing.Size(150, 150)
        Me.TankImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TankImage.TabIndex = 17
        Me.TankImage.TabStop = False
        '
        'TankImageButton
        '
        Me.TankImageButton.Location = New System.Drawing.Point(7, 267)
        Me.TankImageButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TankImageButton.Name = "TankImageButton"
        Me.TankImageButton.Size = New System.Drawing.Size(151, 28)
        Me.TankImageButton.TabIndex = 16
        Me.TankImageButton.Text = "Import Tank Image"
        Me.TankImageButton.UseVisualStyleBackColor = True
        '
        'StatsGroup
        '
        Me.StatsGroup.Controls.Add(Me.AttackLabel)
        Me.StatsGroup.Controls.Add(Me.AvailablePointsLabel)
        Me.StatsGroup.Controls.Add(Me.TankTypesList)
        Me.StatsGroup.Controls.Add(Me.TankTypeLabel)
        Me.StatsGroup.Controls.Add(Me.AttackInput)
        Me.StatsGroup.Controls.Add(Me.ArmorLabel)
        Me.StatsGroup.Controls.Add(Me.SpeedInput)
        Me.StatsGroup.Controls.Add(Me.SpeedLabel)
        Me.StatsGroup.Controls.Add(Me.ArmorInput)
        Me.StatsGroup.Location = New System.Drawing.Point(370, 20)
        Me.StatsGroup.Name = "StatsGroup"
        Me.StatsGroup.Size = New System.Drawing.Size(198, 233)
        Me.StatsGroup.TabIndex = 39
        Me.StatsGroup.TabStop = False
        Me.StatsGroup.Text = "Tank Options"
        '
        'AttackLabel
        '
        Me.AttackLabel.AutoSize = True
        Me.AttackLabel.Location = New System.Drawing.Point(10, 125)
        Me.AttackLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AttackLabel.Name = "AttackLabel"
        Me.AttackLabel.Size = New System.Drawing.Size(47, 17)
        Me.AttackLabel.TabIndex = 35
        Me.AttackLabel.Text = "Attack"
        '
        'AvailablePointsLabel
        '
        Me.AvailablePointsLabel.AutoSize = True
        Me.AvailablePointsLabel.Location = New System.Drawing.Point(7, 90)
        Me.AvailablePointsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AvailablePointsLabel.Name = "AvailablePointsLabel"
        Me.AvailablePointsLabel.Size = New System.Drawing.Size(116, 17)
        Me.AvailablePointsLabel.TabIndex = 38
        Me.AvailablePointsLabel.Text = "Available Points: "
        '
        'TankTypesList
        '
        Me.TankTypesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TankTypesList.FormattingEnabled = True
        Me.TankTypesList.Items.AddRange(New Object() {"Light Tank", "Medium Tank", "Heavy Tank"})
        Me.TankTypesList.Location = New System.Drawing.Point(6, 56)
        Me.TankTypesList.Name = "TankTypesList"
        Me.TankTypesList.Size = New System.Drawing.Size(121, 24)
        Me.TankTypesList.TabIndex = 32
        '
        'TankTypeLabel
        '
        Me.TankTypeLabel.AutoSize = True
        Me.TankTypeLabel.Location = New System.Drawing.Point(7, 33)
        Me.TankTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TankTypeLabel.Name = "TankTypeLabel"
        Me.TankTypeLabel.Size = New System.Drawing.Size(76, 17)
        Me.TankTypeLabel.TabIndex = 31
        Me.TankTypeLabel.Text = "Tank Type"
        '
        'AttackInput
        '
        Me.AttackInput.Location = New System.Drawing.Point(105, 123)
        Me.AttackInput.Margin = New System.Windows.Forms.Padding(4)
        Me.AttackInput.Name = "AttackInput"
        Me.AttackInput.Size = New System.Drawing.Size(49, 22)
        Me.AttackInput.TabIndex = 31
        '
        'ArmorLabel
        '
        Me.ArmorLabel.AutoSize = True
        Me.ArmorLabel.Location = New System.Drawing.Point(13, 189)
        Me.ArmorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ArmorLabel.Name = "ArmorLabel"
        Me.ArmorLabel.Size = New System.Drawing.Size(46, 17)
        Me.ArmorLabel.TabIndex = 37
        Me.ArmorLabel.Text = "Armor"
        '
        'SpeedInput
        '
        Me.SpeedInput.Location = New System.Drawing.Point(105, 156)
        Me.SpeedInput.Margin = New System.Windows.Forms.Padding(4)
        Me.SpeedInput.Name = "SpeedInput"
        Me.SpeedInput.Size = New System.Drawing.Size(49, 22)
        Me.SpeedInput.TabIndex = 33
        '
        'SpeedLabel
        '
        Me.SpeedLabel.AutoSize = True
        Me.SpeedLabel.Location = New System.Drawing.Point(10, 158)
        Me.SpeedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(49, 17)
        Me.SpeedLabel.TabIndex = 36
        Me.SpeedLabel.Text = "Speed"
        '
        'ArmorInput
        '
        Me.ArmorInput.Location = New System.Drawing.Point(105, 189)
        Me.ArmorInput.Margin = New System.Windows.Forms.Padding(4)
        Me.ArmorInput.Name = "ArmorInput"
        Me.ArmorInput.Size = New System.Drawing.Size(49, 22)
        Me.ArmorInput.TabIndex = 34
        '
        'GeneralGameSettingsGroup
        '
        Me.GeneralGameSettingsGroup.Controls.Add(Me.GridInfoLabel)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.ColumnsLabel)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.ColumnsInput)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.RowsLabel)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.RowsInput)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.PlayerLabel)
        Me.GeneralGameSettingsGroup.Controls.Add(Me.PlayerCountInput)
        Me.GeneralGameSettingsGroup.Location = New System.Drawing.Point(12, 12)
        Me.GeneralGameSettingsGroup.Name = "GeneralGameSettingsGroup"
        Me.GeneralGameSettingsGroup.Size = New System.Drawing.Size(412, 193)
        Me.GeneralGameSettingsGroup.TabIndex = 21
        Me.GeneralGameSettingsGroup.TabStop = False
        Me.GeneralGameSettingsGroup.Text = "General Game Settings"
        '
        'GridInfoLabel
        '
        Me.GridInfoLabel.Location = New System.Drawing.Point(202, 39)
        Me.GridInfoLabel.Name = "GridInfoLabel"
        Me.GridInfoLabel.Size = New System.Drawing.Size(195, 128)
        Me.GridInfoLabel.TabIndex = 13
        Me.GridInfoLabel.Text = "Rows and columns of game grid. Larger maps generally have longer games, while sma" &
    "lls maps have short and intense games."
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
        Me.ColumnsInput.Location = New System.Drawing.Point(119, 96)
        Me.ColumnsInput.Margin = New System.Windows.Forms.Padding(4)
        Me.ColumnsInput.Name = "ColumnsInput"
        Me.ColumnsInput.Size = New System.Drawing.Size(53, 22)
        Me.ColumnsInput.TabIndex = 11
        Me.ColumnsInput.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'GridBoxImage
        '
        Me.GridBoxImage.ImageLocation = ""
        Me.GridBoxImage.Location = New System.Drawing.Point(15, 39)
        Me.GridBoxImage.Margin = New System.Windows.Forms.Padding(4)
        Me.GridBoxImage.Name = "GridBoxImage"
        Me.GridBoxImage.Size = New System.Drawing.Size(99, 88)
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
        'GridBoxButton
        '
        Me.GridBoxButton.Location = New System.Drawing.Point(17, 135)
        Me.GridBoxButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GridBoxButton.Name = "GridBoxButton"
        Me.GridBoxButton.Size = New System.Drawing.Size(99, 43)
        Me.GridBoxButton.TabIndex = 26
        Me.GridBoxButton.Text = "Import Grid Box"
        Me.GridBoxButton.UseVisualStyleBackColor = True
        '
        'SelectedBoxButton
        '
        Me.SelectedBoxButton.Location = New System.Drawing.Point(232, 134)
        Me.SelectedBoxButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectedBoxButton.Name = "SelectedBoxButton"
        Me.SelectedBoxButton.Size = New System.Drawing.Size(110, 43)
        Me.SelectedBoxButton.TabIndex = 29
        Me.SelectedBoxButton.Text = "Import Selected Box Image"
        Me.SelectedBoxButton.UseVisualStyleBackColor = True
        '
        'SelectedBoxImage
        '
        Me.SelectedBoxImage.ImageLocation = ""
        Me.SelectedBoxImage.Location = New System.Drawing.Point(234, 39)
        Me.SelectedBoxImage.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectedBoxImage.Name = "SelectedBoxImage"
        Me.SelectedBoxImage.Size = New System.Drawing.Size(108, 88)
        Me.SelectedBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SelectedBoxImage.TabIndex = 28
        Me.SelectedBoxImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Selection Box Image"
        '
        'GameStylingGroup
        '
        Me.GameStylingGroup.Controls.Add(Me.HighLightBoxButton)
        Me.GameStylingGroup.Controls.Add(Me.HighLightImageBox)
        Me.GameStylingGroup.Controls.Add(Me.Label3)
        Me.GameStylingGroup.Controls.Add(Me.GridBoxImage)
        Me.GameStylingGroup.Controls.Add(Me.SelectedBoxButton)
        Me.GameStylingGroup.Controls.Add(Me.Label2)
        Me.GameStylingGroup.Controls.Add(Me.SelectedBoxImage)
        Me.GameStylingGroup.Controls.Add(Me.GridBoxButton)
        Me.GameStylingGroup.Controls.Add(Me.Label1)
        Me.GameStylingGroup.Location = New System.Drawing.Point(430, 12)
        Me.GameStylingGroup.Name = "GameStylingGroup"
        Me.GameStylingGroup.Size = New System.Drawing.Size(579, 193)
        Me.GameStylingGroup.TabIndex = 30
        Me.GameStylingGroup.TabStop = False
        Me.GameStylingGroup.Text = "Game Styling"
        '
        'HighLightBoxButton
        '
        Me.HighLightBoxButton.Location = New System.Drawing.Point(439, 134)
        Me.HighLightBoxButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HighLightBoxButton.Name = "HighLightBoxButton"
        Me.HighLightBoxButton.Size = New System.Drawing.Size(110, 43)
        Me.HighLightBoxButton.TabIndex = 32
        Me.HighLightBoxButton.Text = "Import Selection Box Image"
        Me.HighLightBoxButton.UseVisualStyleBackColor = True
        '
        'HighLightImageBox
        '
        Me.HighLightImageBox.ImageLocation = ""
        Me.HighLightImageBox.Location = New System.Drawing.Point(439, 39)
        Me.HighLightImageBox.Margin = New System.Windows.Forms.Padding(4)
        Me.HighLightImageBox.Name = "HighLightImageBox"
        Me.HighLightImageBox.Size = New System.Drawing.Size(108, 88)
        Me.HighLightImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HighLightImageBox.TabIndex = 31
        Me.HighLightImageBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "High Light Image"
        '
        'ImportMapButton
        '
        Me.ImportMapButton.Location = New System.Drawing.Point(22, 237)
        Me.ImportMapButton.Name = "ImportMapButton"
        Me.ImportMapButton.Size = New System.Drawing.Size(111, 31)
        Me.ImportMapButton.TabIndex = 0
        Me.ImportMapButton.Text = "Import Map"
        Me.ImportMapButton.UseVisualStyleBackColor = True
        '
        'GameplaySettingsGroup
        '
        Me.GameplaySettingsGroup.Controls.Add(Me.ImportMapButton)
        Me.GameplaySettingsGroup.Controls.Add(Me.ImportMapLabel)
        Me.GameplaySettingsGroup.Controls.Add(Me.TeamModeLabel)
        Me.GameplaySettingsGroup.Controls.Add(Me.NoBuildingLabel)
        Me.GameplaySettingsGroup.Controls.Add(Me.NoTurretLabel)
        Me.GameplaySettingsGroup.Controls.Add(Me.EnvironmentModeLabel)
        Me.GameplaySettingsGroup.Controls.Add(Me.BlitzText)
        Me.GameplaySettingsGroup.Controls.Add(Me.TeamsModeCheck)
        Me.GameplaySettingsGroup.Controls.Add(Me.AntiFortniteModeCheck)
        Me.GameplaySettingsGroup.Controls.Add(Me.GunSlingerModeCheck)
        Me.GameplaySettingsGroup.Controls.Add(Me.EnvironmentalModeCheck)
        Me.GameplaySettingsGroup.Controls.Add(Me.BlizModeCheck)
        Me.GameplaySettingsGroup.Location = New System.Drawing.Point(12, 211)
        Me.GameplaySettingsGroup.Name = "GameplaySettingsGroup"
        Me.GameplaySettingsGroup.Size = New System.Drawing.Size(412, 329)
        Me.GameplaySettingsGroup.TabIndex = 32
        Me.GameplaySettingsGroup.TabStop = False
        Me.GameplaySettingsGroup.Text = "Gameplay Settings (Optional)"
        '
        'ImportMapLabel
        '
        Me.ImportMapLabel.Location = New System.Drawing.Point(202, 242)
        Me.ImportMapLabel.Name = "ImportMapLabel"
        Me.ImportMapLabel.Size = New System.Drawing.Size(195, 31)
        Me.ImportMapLabel.TabIndex = 37
        Me.ImportMapLabel.Text = "Imports map"
        '
        'TeamModeLabel
        '
        Me.TeamModeLabel.Location = New System.Drawing.Point(202, 211)
        Me.TeamModeLabel.Name = "TeamModeLabel"
        Me.TeamModeLabel.Size = New System.Drawing.Size(195, 31)
        Me.TeamModeLabel.TabIndex = 36
        Me.TeamModeLabel.Text = "Enables Teams"
        '
        'NoBuildingLabel
        '
        Me.NoBuildingLabel.Location = New System.Drawing.Point(202, 176)
        Me.NoBuildingLabel.Name = "NoBuildingLabel"
        Me.NoBuildingLabel.Size = New System.Drawing.Size(195, 25)
        Me.NoBuildingLabel.TabIndex = 17
        Me.NoBuildingLabel.Text = "Disable Buildings"
        '
        'NoTurretLabel
        '
        Me.NoTurretLabel.Location = New System.Drawing.Point(202, 139)
        Me.NoTurretLabel.Name = "NoTurretLabel"
        Me.NoTurretLabel.Size = New System.Drawing.Size(195, 23)
        Me.NoTurretLabel.TabIndex = 16
        Me.NoTurretLabel.Text = "Disable Turrets"
        '
        'EnvironmentModeLabel
        '
        Me.EnvironmentModeLabel.Location = New System.Drawing.Point(202, 90)
        Me.EnvironmentModeLabel.Name = "EnvironmentModeLabel"
        Me.EnvironmentModeLabel.Size = New System.Drawing.Size(195, 28)
        Me.EnvironmentModeLabel.TabIndex = 15
        Me.EnvironmentModeLabel.Text = "Water, Earth, Fire and Air"
        '
        'BlitzText
        '
        Me.BlitzText.Location = New System.Drawing.Point(202, 49)
        Me.BlitzText.Name = "BlitzText"
        Me.BlitzText.Size = New System.Drawing.Size(195, 30)
        Me.BlitzText.TabIndex = 14
        Me.BlitzText.Text = "All Damage is increased"
        '
        'TeamsModeCheck
        '
        Me.TeamsModeCheck.AutoSize = True
        Me.TeamsModeCheck.Location = New System.Drawing.Point(22, 210)
        Me.TeamsModeCheck.Name = "TeamsModeCheck"
        Me.TeamsModeCheck.Size = New System.Drawing.Size(73, 21)
        Me.TeamsModeCheck.TabIndex = 11
        Me.TeamsModeCheck.Text = "Teams"
        Me.TeamsModeCheck.UseVisualStyleBackColor = True
        '
        'AntiFortniteModeCheck
        '
        Me.AntiFortniteModeCheck.AutoSize = True
        Me.AntiFortniteModeCheck.Location = New System.Drawing.Point(22, 174)
        Me.AntiFortniteModeCheck.Name = "AntiFortniteModeCheck"
        Me.AntiFortniteModeCheck.Size = New System.Drawing.Size(146, 21)
        Me.AntiFortniteModeCheck.TabIndex = 9
        Me.AntiFortniteModeCheck.Text = "Anti-Fortnite Mode"
        Me.AntiFortniteModeCheck.UseVisualStyleBackColor = True
        '
        'GunSlingerModeCheck
        '
        Me.GunSlingerModeCheck.AutoSize = True
        Me.GunSlingerModeCheck.Location = New System.Drawing.Point(22, 129)
        Me.GunSlingerModeCheck.Name = "GunSlingerModeCheck"
        Me.GunSlingerModeCheck.Size = New System.Drawing.Size(144, 21)
        Me.GunSlingerModeCheck.TabIndex = 8
        Me.GunSlingerModeCheck.Text = "Gun Slinger Mode"
        Me.GunSlingerModeCheck.UseVisualStyleBackColor = True
        '
        'EnvironmentalModeCheck
        '
        Me.EnvironmentalModeCheck.AutoSize = True
        Me.EnvironmentalModeCheck.Location = New System.Drawing.Point(22, 89)
        Me.EnvironmentalModeCheck.Name = "EnvironmentalModeCheck"
        Me.EnvironmentalModeCheck.Size = New System.Drawing.Size(159, 21)
        Me.EnvironmentalModeCheck.TabIndex = 6
        Me.EnvironmentalModeCheck.Text = "Environmental Mode"
        Me.EnvironmentalModeCheck.UseVisualStyleBackColor = True
        '
        'BlizModeCheck
        '
        Me.BlizModeCheck.AutoSize = True
        Me.BlizModeCheck.Location = New System.Drawing.Point(22, 49)
        Me.BlizModeCheck.Name = "BlizModeCheck"
        Me.BlizModeCheck.Size = New System.Drawing.Size(95, 21)
        Me.BlizModeCheck.TabIndex = 0
        Me.BlizModeCheck.Text = "Blitz Mode"
        Me.BlizModeCheck.UseVisualStyleBackColor = True
        '
        'StartPromptText
        '
        Me.StartPromptText.Location = New System.Drawing.Point(841, 540)
        Me.StartPromptText.Name = "StartPromptText"
        Me.StartPromptText.Size = New System.Drawing.Size(168, 36)
        Me.StartPromptText.TabIndex = 38
        Me.StartPromptText.Text = "Complete all Player Creation"
        '
        'TurretImage
        '
        Me.TurretImage.ImageLocation = ""
        Me.TurretImage.Location = New System.Drawing.Point(200, 118)
        Me.TurretImage.Margin = New System.Windows.Forms.Padding(4)
        Me.TurretImage.Name = "TurretImage"
        Me.TurretImage.Size = New System.Drawing.Size(150, 150)
        Me.TurretImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TurretImage.TabIndex = 38
        Me.TurretImage.TabStop = False
        '
        'TurretImageButton
        '
        Me.TurretImageButton.Location = New System.Drawing.Point(200, 267)
        Me.TurretImageButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TurretImageButton.Name = "TurretImageButton"
        Me.TurretImageButton.Size = New System.Drawing.Size(151, 28)
        Me.TurretImageButton.TabIndex = 39
        Me.TurretImageButton.Text = "Import Turret Image"
        Me.TurretImageButton.UseVisualStyleBackColor = True
        '
        'InGameOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 585)
        Me.Controls.Add(Me.StartPromptText)
        Me.Controls.Add(Me.GameplaySettingsGroup)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TankImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatsGroup.ResumeLayout(False)
        Me.StatsGroup.PerformLayout()
        CType(Me.AttackInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeedInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmorInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GeneralGameSettingsGroup.ResumeLayout(False)
        Me.GeneralGameSettingsGroup.PerformLayout()
        CType(Me.ColumnsInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameStylingGroup.ResumeLayout(False)
        Me.GameStylingGroup.PerformLayout()
        CType(Me.HighLightImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameplaySettingsGroup.ResumeLayout(False)
        Me.GameplaySettingsGroup.PerformLayout()
        CType(Me.TurretImage, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridBoxButton As Button
    Friend WithEvents SelectedBoxButton As Button
    Friend WithEvents SelectedBoxImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GameStylingGroup As GroupBox
    Friend WithEvents ColumnsLabel As Label
    Friend WithEvents ColumnsInput As NumericUpDown
    Friend WithEvents TankTypeLabel As Label
    Friend WithEvents TankTypesList As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatsGroup As GroupBox
    Friend WithEvents AttackLabel As Label
    Friend WithEvents AvailablePointsLabel As Label
    Friend WithEvents AttackInput As NumericUpDown
    Friend WithEvents ArmorLabel As Label
    Friend WithEvents SpeedInput As NumericUpDown
    Friend WithEvents SpeedLabel As Label
    Friend WithEvents ArmorInput As NumericUpDown
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ImportMapButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents HighLightBoxButton As Button
    Friend WithEvents HighLightImageBox As PictureBox
    Friend WithEvents GameplaySettingsGroup As GroupBox
    Friend WithEvents AntiFortniteModeCheck As CheckBox
    Friend WithEvents GunSlingerModeCheck As CheckBox
    Friend WithEvents EnvironmentalModeCheck As CheckBox
    Friend WithEvents BlizModeCheck As CheckBox
    Friend WithEvents TeamsModeCheck As CheckBox
    Friend WithEvents TeamList As ComboBox
    Friend WithEvents TeamLabel As Label
    Friend WithEvents GridInfoLabel As Label
    Friend WithEvents ImportMapLabel As Label
    Friend WithEvents TeamModeLabel As Label
    Friend WithEvents NoBuildingLabel As Label
    Friend WithEvents NoTurretLabel As Label
    Friend WithEvents EnvironmentModeLabel As Label
    Friend WithEvents BlitzText As Label
    Friend WithEvents TeamModeText As Label
    Friend WithEvents StartPromptText As Label
    Friend WithEvents TurretImageButton As Button
    Friend WithEvents TurretImage As PictureBox
End Class
