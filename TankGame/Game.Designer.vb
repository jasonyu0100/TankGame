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
        Me.ActionPointsLabel = New System.Windows.Forms.Label()
        Me.PlayerHealth = New System.Windows.Forms.Label()
        Me.PlayerName = New System.Windows.Forms.Label()
        Me.TurnNumLabel = New System.Windows.Forms.Label()
        Me.EndTurnButton = New System.Windows.Forms.Button()
        Me.TurretButton = New System.Windows.Forms.Button()
        Me.BuildButton = New System.Windows.Forms.Button()
        Me.MoveButton = New System.Windows.Forms.Button()
        Me.ShootButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GameHudGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameHudGroup
        '
        Me.GameHudGroup.Controls.Add(Me.Label5)
        Me.GameHudGroup.Controls.Add(Me.Label4)
        Me.GameHudGroup.Controls.Add(Me.Label3)
        Me.GameHudGroup.Controls.Add(Me.Label2)
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
        Me.GameHudGroup.Location = New System.Drawing.Point(13, 747)
        Me.GameHudGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.GameHudGroup.Name = "GameHudGroup"
        Me.GameHudGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.GameHudGroup.Size = New System.Drawing.Size(781, 204)
        Me.GameHudGroup.TabIndex = 0
        Me.GameHudGroup.TabStop = False
        Me.GameHudGroup.Text = "Game Hud"
        '
        'ActionPointsLabel
        '
        Me.ActionPointsLabel.AutoSize = True
        Me.ActionPointsLabel.Location = New System.Drawing.Point(343, 30)
        Me.ActionPointsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ActionPointsLabel.Name = "ActionPointsLabel"
        Me.ActionPointsLabel.Size = New System.Drawing.Size(94, 17)
        Me.ActionPointsLabel.TabIndex = 8
        Me.ActionPointsLabel.Text = "Action Points:"
        '
        'PlayerHealth
        '
        Me.PlayerHealth.AutoSize = True
        Me.PlayerHealth.Location = New System.Drawing.Point(173, 30)
        Me.PlayerHealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerHealth.Name = "PlayerHealth"
        Me.PlayerHealth.Size = New System.Drawing.Size(57, 17)
        Me.PlayerHealth.TabIndex = 7
        Me.PlayerHealth.Text = "Health: "
        '
        'PlayerName
        '
        Me.PlayerName.AutoSize = True
        Me.PlayerName.Location = New System.Drawing.Point(20, 30)
        Me.PlayerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(53, 17)
        Me.PlayerName.TabIndex = 6
        Me.PlayerName.Text = "Name: "
        '
        'TurnNumLabel
        '
        Me.TurnNumLabel.AutoSize = True
        Me.TurnNumLabel.Location = New System.Drawing.Point(495, 30)
        Me.TurnNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TurnNumLabel.Name = "TurnNumLabel"
        Me.TurnNumLabel.Size = New System.Drawing.Size(100, 17)
        Me.TurnNumLabel.TabIndex = 5
        Me.TurnNumLabel.Text = "Turn Number: "
        '
        'EndTurnButton
        '
        Me.EndTurnButton.Location = New System.Drawing.Point(646, 62)
        Me.EndTurnButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EndTurnButton.Name = "EndTurnButton"
        Me.EndTurnButton.Size = New System.Drawing.Size(100, 58)
        Me.EndTurnButton.TabIndex = 4
        Me.EndTurnButton.Text = "End Turn (T)"
        Me.EndTurnButton.UseVisualStyleBackColor = True
        '
        'TurretButton
        '
        Me.TurretButton.Location = New System.Drawing.Point(486, 62)
        Me.TurretButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TurretButton.Name = "TurretButton"
        Me.TurretButton.Size = New System.Drawing.Size(100, 58)
        Me.TurretButton.TabIndex = 3
        Me.TurretButton.Text = "Turret (R)"
        Me.TurretButton.UseVisualStyleBackColor = True
        '
        'BuildButton
        '
        Me.BuildButton.Location = New System.Drawing.Point(337, 62)
        Me.BuildButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BuildButton.Name = "BuildButton"
        Me.BuildButton.Size = New System.Drawing.Size(100, 58)
        Me.BuildButton.TabIndex = 2
        Me.BuildButton.Text = "Build (E)"
        Me.BuildButton.UseVisualStyleBackColor = True
        '
        'MoveButton
        '
        Me.MoveButton.Location = New System.Drawing.Point(176, 62)
        Me.MoveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MoveButton.Name = "MoveButton"
        Me.MoveButton.Size = New System.Drawing.Size(100, 58)
        Me.MoveButton.TabIndex = 1
        Me.MoveButton.Text = "Move (W)"
        Me.MoveButton.UseVisualStyleBackColor = True
        '
        'ShootButton
        '
        Me.ShootButton.Location = New System.Drawing.Point(23, 62)
        Me.ShootButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ShootButton.Name = "ShootButton"
        Me.ShootButton.Size = New System.Drawing.Size(100, 58)
        Me.ShootButton.TabIndex = 0
        Me.ShootButton.Text = "Shoot (Q)"
        Me.ShootButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shoots a projectile that deals heavy damage!"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(173, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 76)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Moves your tank to a new location"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(334, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 76)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Builds a building in a designated location"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(483, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 76)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Commands your turret to do something"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(644, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 76)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ends your turn"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 953)
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
