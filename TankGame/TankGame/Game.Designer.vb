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
        Me.GameHudGroup.Controls.Add(Me.PlayerHealth)
        Me.GameHudGroup.Controls.Add(Me.PlayerName)
        Me.GameHudGroup.Controls.Add(Me.TurnNumLabel)
        Me.GameHudGroup.Controls.Add(Me.EndTurnButton)
        Me.GameHudGroup.Controls.Add(Me.TurretButton)
        Me.GameHudGroup.Controls.Add(Me.BuildButton)
        Me.GameHudGroup.Controls.Add(Me.MoveButton)
        Me.GameHudGroup.Controls.Add(Me.ShootButton)
        Me.GameHudGroup.Location = New System.Drawing.Point(0, 794)
        Me.GameHudGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.GameHudGroup.Name = "GameHudGroup"
        Me.GameHudGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.GameHudGroup.Size = New System.Drawing.Size(782, 160)
        Me.GameHudGroup.TabIndex = 0
        Me.GameHudGroup.TabStop = False
        Me.GameHudGroup.Text = "Game Hud"
        '
        'PlayerHealth
        '
        Me.PlayerHealth.AutoSize = True
        Me.PlayerHealth.Location = New System.Drawing.Point(20, 159)
        Me.PlayerHealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerHealth.Name = "PlayerHealth"
        Me.PlayerHealth.Size = New System.Drawing.Size(57, 17)
        Me.PlayerHealth.TabIndex = 7
        Me.PlayerHealth.Text = "Health: "
        '
        'PlayerName
        '
        Me.PlayerName.AutoSize = True
        Me.PlayerName.Location = New System.Drawing.Point(20, 96)
        Me.PlayerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(53, 17)
        Me.PlayerName.TabIndex = 6
        Me.PlayerName.Text = "Name: "
        '
        'TurnNumLabel
        '
        Me.TurnNumLabel.AutoSize = True
        Me.TurnNumLabel.Location = New System.Drawing.Point(16, 39)
        Me.TurnNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TurnNumLabel.Name = "TurnNumLabel"
        Me.TurnNumLabel.Size = New System.Drawing.Size(100, 17)
        Me.TurnNumLabel.TabIndex = 5
        Me.TurnNumLabel.Text = "Turn Number: "
        '
        'EndTurnButton
        '
        Me.EndTurnButton.Location = New System.Drawing.Point(615, 90)
        Me.EndTurnButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EndTurnButton.Name = "EndTurnButton"
        Me.EndTurnButton.Size = New System.Drawing.Size(100, 28)
        Me.EndTurnButton.TabIndex = 4
        Me.EndTurnButton.Text = "End Turn"
        Me.EndTurnButton.UseVisualStyleBackColor = True
        '
        'TurretButton
        '
        Me.TurretButton.Location = New System.Drawing.Point(493, 90)
        Me.TurretButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TurretButton.Name = "TurretButton"
        Me.TurretButton.Size = New System.Drawing.Size(100, 28)
        Me.TurretButton.TabIndex = 3
        Me.TurretButton.Text = "Turret"
        Me.TurretButton.UseVisualStyleBackColor = True
        '
        'BuildButton
        '
        Me.BuildButton.Location = New System.Drawing.Point(376, 90)
        Me.BuildButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BuildButton.Name = "BuildButton"
        Me.BuildButton.Size = New System.Drawing.Size(100, 28)
        Me.BuildButton.TabIndex = 2
        Me.BuildButton.Text = "Build"
        Me.BuildButton.UseVisualStyleBackColor = True
        '
        'MoveButton
        '
        Me.MoveButton.Location = New System.Drawing.Point(252, 90)
        Me.MoveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveButton.Name = "MoveButton"
        Me.MoveButton.Size = New System.Drawing.Size(100, 28)
        Me.MoveButton.TabIndex = 1
        Me.MoveButton.Text = "Move"
        Me.MoveButton.UseVisualStyleBackColor = True
        '
        'ShootButton
        '
        Me.ShootButton.Location = New System.Drawing.Point(144, 90)
        Me.ShootButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ShootButton.Name = "ShootButton"
        Me.ShootButton.Size = New System.Drawing.Size(100, 28)
        Me.ShootButton.TabIndex = 0
        Me.ShootButton.Text = "Shoot"
        Me.ShootButton.UseVisualStyleBackColor = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(782, 953)
        Me.Controls.Add(Me.GameHudGroup)
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
End Class
