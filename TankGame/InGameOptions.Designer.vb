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
        Me.TauntLabel = New System.Windows.Forms.Label()
        Me.TauntInput = New System.Windows.Forms.TextBox()
        Me.TankImage = New System.Windows.Forms.PictureBox()
        Me.TankImageButton = New System.Windows.Forms.Button()
        Me.StatsGroup = New System.Windows.Forms.GroupBox()
        Me.AttackLabel = New System.Windows.Forms.Label()
        Me.AvailablePointsLabel = New System.Windows.Forms.Label()
        Me.TankTypesList = New System.Windows.Forms.ComboBox()
        Me.TankTypeLabel = New System.Windows.Forms.Label()
        Me.AttackInput = New System.Windows.Forms.NumericUpDown()
        Me.ArmorLabel = New System.Windows.Forms.Label()
        Me.ActionPointsInput = New System.Windows.Forms.NumericUpDown()
        Me.ActionPoints = New System.Windows.Forms.Label()
        Me.ArmorInput = New System.Windows.Forms.NumericUpDown()
        Me.GeneralGameSettingsGroup = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.RowsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCountInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerCreationGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TankImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatsGroup.SuspendLayout()
        CType(Me.AttackInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActionPointsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmorInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GeneralGameSettingsGroup.SuspendLayout()
        CType(Me.ColumnsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameStylingGroup.SuspendLayout()
        CType(Me.HighLightImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartGameButton
        '
        Me.StartGameButton.Location = New System.Drawing.Point(906, 546)
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
        Me.NameInput.Location = New System.Drawing.Point(186, 54)
        Me.NameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(148, 22)
        Me.NameInput.TabIndex = 11
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(237, 33)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 13
        Me.NameLabel.Text = "Name"
        '
        'ImageLabel
        '
        Me.ImageLabel.AutoSize = True
        Me.ImageLabel.Location = New System.Drawing.Point(63, 33)
        Me.ImageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ImageLabel.Name = "ImageLabel"
        Me.ImageLabel.Size = New System.Drawing.Size(46, 17)
        Me.ImageLabel.TabIndex = 15
        Me.ImageLabel.Text = "Image"
        '
        'AddPlayerButton
        '
        Me.AddPlayerButton.Location = New System.Drawing.Point(234, 220)
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
        Me.PlayerCreationGroup.Location = New System.Drawing.Point(431, 211)
        Me.PlayerCreationGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerCreationGroup.Name = "PlayerCreationGroup"
        Me.PlayerCreationGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.PlayerCreationGroup.Size = New System.Drawing.Size(578, 304)
        Me.PlayerCreationGroup.TabIndex = 20
        Me.PlayerCreationGroup.TabStop = False
        Me.PlayerCreationGroup.Text = "Player Creation"
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
        Me.GroupBox1.Size = New System.Drawing.Size(357, 270)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appearance"
        '
        'TauntLabel
        '
        Me.TauntLabel.AutoSize = True
        Me.TauntLabel.Location = New System.Drawing.Point(237, 161)
        Me.TauntLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TauntLabel.Name = "TauntLabel"
        Me.TauntLabel.Size = New System.Drawing.Size(45, 17)
        Me.TauntLabel.TabIndex = 21
        Me.TauntLabel.Text = "Taunt"
        '
        'TauntInput
        '
        Me.TauntInput.Location = New System.Drawing.Point(186, 182)
        Me.TauntInput.Margin = New System.Windows.Forms.Padding(4)
        Me.TauntInput.Name = "TauntInput"
        Me.TauntInput.Size = New System.Drawing.Size(148, 22)
        Me.TauntInput.TabIndex = 20
        '
        'TankImage
        '
        Me.TankImage.ImageLocation = ""
        Me.TankImage.Location = New System.Drawing.Point(19, 54)
        Me.TankImage.Margin = New System.Windows.Forms.Padding(4)
        Me.TankImage.Name = "TankImage"
        Me.TankImage.Size = New System.Drawing.Size(150, 150)
        Me.TankImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TankImage.TabIndex = 17
        Me.TankImage.TabStop = False
        '
        'TankImageButton
        '
        Me.TankImageButton.Location = New System.Drawing.Point(18, 215)
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
        Me.StatsGroup.Controls.Add(Me.ActionPointsInput)
        Me.StatsGroup.Controls.Add(Me.ActionPoints)
        Me.StatsGroup.Controls.Add(Me.ArmorInput)
        Me.StatsGroup.Location = New System.Drawing.Point(370, 20)
        Me.StatsGroup.Name = "StatsGroup"
        Me.StatsGroup.Size = New System.Drawing.Size(198, 276)
        Me.StatsGroup.TabIndex = 39
        Me.StatsGroup.TabStop = False
        Me.StatsGroup.Text = "Tank Options"
        '
        'AttackLabel
        '
        Me.AttackLabel.AutoSize = True
        Me.AttackLabel.Location = New System.Drawing.Point(7, 128)
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
        Me.TankTypesList.FormattingEnabled = True
        Me.TankTypesList.Items.AddRange(New Object() {"Light Tank", "Medium Tank", "Heavy Tank", "Blitzer", "Engineer"})
        Me.TankTypesList.Location = New System.Drawing.Point(10, 54)
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
        Me.AttackInput.Location = New System.Drawing.Point(110, 126)
        Me.AttackInput.Margin = New System.Windows.Forms.Padding(4)
        Me.AttackInput.Name = "AttackInput"
        Me.AttackInput.Size = New System.Drawing.Size(49, 22)
        Me.AttackInput.TabIndex = 31
        Me.AttackInput.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ArmorLabel
        '
        Me.ArmorLabel.AutoSize = True
        Me.ArmorLabel.Location = New System.Drawing.Point(10, 213)
        Me.ArmorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ArmorLabel.Name = "ArmorLabel"
        Me.ArmorLabel.Size = New System.Drawing.Size(46, 17)
        Me.ArmorLabel.TabIndex = 37
        Me.ArmorLabel.Text = "Armor"
        '
        'ActionPointsInput
        '
        Me.ActionPointsInput.Location = New System.Drawing.Point(110, 167)
        Me.ActionPointsInput.Margin = New System.Windows.Forms.Padding(4)
        Me.ActionPointsInput.Name = "ActionPointsInput"
        Me.ActionPointsInput.Size = New System.Drawing.Size(49, 22)
        Me.ActionPointsInput.TabIndex = 33
        Me.ActionPointsInput.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ActionPoints
        '
        Me.ActionPoints.AutoSize = True
        Me.ActionPoints.Location = New System.Drawing.Point(7, 167)
        Me.ActionPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ActionPoints.Name = "ActionPoints"
        Me.ActionPoints.Size = New System.Drawing.Size(49, 17)
        Me.ActionPoints.TabIndex = 36
        Me.ActionPoints.Text = "Speed"
        '
        'ArmorInput
        '
        Me.ArmorInput.Location = New System.Drawing.Point(110, 211)
        Me.ArmorInput.Margin = New System.Windows.Forms.Padding(4)
        Me.ArmorInput.Name = "ArmorInput"
        Me.ArmorInput.Size = New System.Drawing.Size(49, 22)
        Me.ArmorInput.TabIndex = 34
        Me.ArmorInput.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'GeneralGameSettingsGroup
        '
        Me.GeneralGameSettingsGroup.Controls.Add(Me.TextBox6)
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
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(205, 35)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(192, 86)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = "Rows and columns of game grid. Larger maps generally have longer games, while sma" &
    "lls maps have short and intense games." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.SelectedBoxButton.Location = New System.Drawing.Point(165, 134)
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
        Me.SelectedBoxImage.Location = New System.Drawing.Point(167, 39)
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
        Me.Label1.Location = New System.Drawing.Point(151, 16)
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
        Me.HighLightBoxButton.Location = New System.Drawing.Point(313, 135)
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
        Me.HighLightImageBox.Location = New System.Drawing.Point(315, 39)
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
        Me.Label3.Location = New System.Drawing.Point(311, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "High Light Image"
        '
        'ImportMapButton
        '
        Me.ImportMapButton.Location = New System.Drawing.Point(20, 24)
        Me.ImportMapButton.Name = "ImportMapButton"
        Me.ImportMapButton.Size = New System.Drawing.Size(111, 31)
        Me.ImportMapButton.TabIndex = 0
        Me.ImportMapButton.Text = "Import Map"
        Me.ImportMapButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 304)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gameplay Settings"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(205, 21)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 40)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "Custom Maps can be imported"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(22, 198)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox5.TabIndex = 9
        Me.CheckBox5.Text = "Anti-Fortnite Mode"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(22, 150)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(144, 21)
        Me.CheckBox4.TabIndex = 8
        Me.CheckBox4.Text = "Gun Slinger Mode"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(22, 95)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(159, 21)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Environmental Mode"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(205, 196)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(192, 23)
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Text = "Disable Buildings"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(205, 150)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 23)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = "Disable Turrets"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(205, 95)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 30)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "Water, Earth, Fire and Air"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(205, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 54)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Players have double the action points and have bonus damage every 5th turn."
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Blitz Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(205, 245)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(192, 23)
        Me.TextBox7.TabIndex = 10
        Me.TextBox7.Text = "Team gameplay"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(22, 247)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(73, 21)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "Teams"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.ImportMapButton)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 520)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 67)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc."
        '
        'InGameOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 597)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
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
        CType(Me.ActionPointsInput, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents ImportMapButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents HighLightBoxButton As Button
    Friend WithEvents HighLightImageBox As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
