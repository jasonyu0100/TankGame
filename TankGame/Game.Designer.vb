<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GameHudGroup = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActionPointsLabel = New System.Windows.Forms.Label()
        Me.PlayerHealth = New System.Windows.Forms.Label()
        Me.PlayerName = New System.Windows.Forms.Label()
        Me.TurnNumLabel = New System.Windows.Forms.Label()
        Me.EndTurnButton = New System.Windows.Forms.Button()
        Me.TurretButton = New System.Windows.Forms.Button()
        Me.BuildButton = New System.Windows.Forms.Button()
        Me.MoveButton = New System.Windows.Forms.Button()
        Me.ShootButton = New System.Windows.Forms.Button()
        Me.GameHudGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameHudGroup
        '
        Me.GameHudGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GameHudGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GameHudGroup.Controls.Add(Me.Label5)
        Me.GameHudGroup.Controls.Add(Me.Label2)
        Me.GameHudGroup.Controls.Add(Me.Label4)
        Me.GameHudGroup.Controls.Add(Me.Label3)
        Me.GameHudGroup.Controls.Add(Me.Label1)
        Me.GameHudGroup.Controls.Add(Me.ActionPointsLabel)
        Me.GameHudGroup.Controls.Add(Me.PlayerHealth)
        Me.GameHudGroup.Controls.Add(Me.PlayerName)
        Me.GameHudGroup.Controls.Add(Me.TurnNumLabel)
        Me.GameHudGroup.Controls.Add(Me.EndTurnButton)
        Me.GameHudGroup.Controls.Add(Me.TurretButton)
        Me.GameHudGroup.Controls.Add(Me.BuildButton)
        Me.GameHudGroup.Controls.Add(Me.MoveButton)
        Me.GameHudGroup.Controls.Add(Me.ShootButton)
        Me.GameHudGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameHudGroup.Location = New System.Drawing.Point(1033, 0)
        Me.GameHudGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.GameHudGroup.Name = "GameHudGroup"
        Me.GameHudGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.GameHudGroup.Size = New System.Drawing.Size(150, 954)
        Me.GameHudGroup.TabIndex = 0
        Me.GameHudGroup.TabStop = False
        Me.GameHudGroup.Text = "Game Hud"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 895)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 76)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ends your turn"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 744)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 65)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Commands your turret to do something"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 601)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 76)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Builds a building in a designated location"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 459)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 76)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Moves your tank to a new location"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shoots a projectile that deals heavy damage!"
        '
        'ActionPointsLabel
        '
        Me.ActionPointsLabel.AutoSize = True
        Me.ActionPointsLabel.Location = New System.Drawing.Point(20, 173)
        Me.ActionPointsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ActionPointsLabel.Name = "ActionPointsLabel"
        Me.ActionPointsLabel.Size = New System.Drawing.Size(94, 17)
        Me.ActionPointsLabel.TabIndex = 8
        Me.ActionPointsLabel.Text = "Action Points:"
        '
        'PlayerHealth
        '
        Me.PlayerHealth.AutoSize = True
        Me.PlayerHealth.Location = New System.Drawing.Point(14, 84)
        Me.PlayerHealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerHealth.Name = "PlayerHealth"
        Me.PlayerHealth.Size = New System.Drawing.Size(57, 17)
        Me.PlayerHealth.TabIndex = 7
        Me.PlayerHealth.Text = "Health: "
        '
        'PlayerName
        '
        Me.PlayerName.AutoSize = True
        Me.PlayerName.Location = New System.Drawing.Point(14, 39)
        Me.PlayerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(53, 17)
        Me.PlayerName.TabIndex = 6
        Me.PlayerName.Text = "Name: "
        '
        'TurnNumLabel
        '
        Me.TurnNumLabel.AutoSize = True
        Me.TurnNumLabel.Location = New System.Drawing.Point(14, 125)
        Me.TurnNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TurnNumLabel.Name = "TurnNumLabel"
        Me.TurnNumLabel.Size = New System.Drawing.Size(100, 17)
        Me.TurnNumLabel.TabIndex = 5
        Me.TurnNumLabel.Text = "Turn Number: "
        '
        'EndTurnButton
        '
        Me.EndTurnButton.BackColor = System.Drawing.Color.Gray
        Me.EndTurnButton.Location = New System.Drawing.Point(17, 823)
        Me.EndTurnButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EndTurnButton.Name = "EndTurnButton"
        Me.EndTurnButton.Size = New System.Drawing.Size(100, 58)
        Me.EndTurnButton.TabIndex = 4
        Me.EndTurnButton.Text = "End Turn (T)"
        Me.EndTurnButton.UseVisualStyleBackColor = False
        '
        'TurretButton
        '
        Me.TurretButton.BackColor = System.Drawing.Color.Gray
        Me.TurretButton.Location = New System.Drawing.Point(17, 682)
        Me.TurretButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TurretButton.Name = "TurretButton"
        Me.TurretButton.Size = New System.Drawing.Size(100, 58)
        Me.TurretButton.TabIndex = 3
        Me.TurretButton.Text = "Turret (R)"
        Me.TurretButton.UseVisualStyleBackColor = False
        '
        'BuildButton
        '
        Me.BuildButton.BackColor = System.Drawing.Color.Gray
        Me.BuildButton.Location = New System.Drawing.Point(20, 539)
        Me.BuildButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BuildButton.Name = "BuildButton"
        Me.BuildButton.Size = New System.Drawing.Size(100, 58)
        Me.BuildButton.TabIndex = 2
        Me.BuildButton.Text = "Build (E)"
        Me.BuildButton.UseVisualStyleBackColor = False
        '
        'MoveButton
        '
        Me.MoveButton.BackColor = System.Drawing.Color.Gray
        Me.MoveButton.Location = New System.Drawing.Point(20, 384)
        Me.MoveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveButton.Name = "MoveButton"
        Me.MoveButton.Size = New System.Drawing.Size(100, 58)
        Me.MoveButton.TabIndex = 1
        Me.MoveButton.Text = "Move (W)"
        Me.MoveButton.UseVisualStyleBackColor = False
        '
        'ShootButton
        '
        Me.ShootButton.BackColor = System.Drawing.Color.Gray
        Me.ShootButton.Location = New System.Drawing.Point(20, 216)
        Me.ShootButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ShootButton.Name = "ShootButton"
        Me.ShootButton.Size = New System.Drawing.Size(100, 58)
        Me.ShootButton.TabIndex = 0
        Me.ShootButton.Text = "Shoot (Q)"
        Me.ShootButton.UseVisualStyleBackColor = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 953)
        Me.Controls.Add(Me.GameHudGroup)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Game"
        Me.Text = "Form1"
        Me.GameHudGroup.ResumeLayout(False)
        Me.GameHudGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GameHudGroup As GroupBox
    Friend WithEvents EndTurnButton As Button
    Friend WithEvents TurretButton As Button
    Friend WithEvents BuildButton As Button
    Friend WithEvents MoveButton As Button
    Friend WithEvents ShootButton As Button
    Friend WithEvents PlayerHealth As Label
    Friend WithEvents PlayerName As Label
    Friend WithEvents TurnNumLabel As Label
    Friend WithEvents ActionPointsLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
