<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartUp
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
        Me.StartGameButton = New System.Windows.Forms.Button()
        Me.GameLabel = New System.Windows.Forms.Label()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartGameButton
        '
        Me.StartGameButton.ForeColor = System.Drawing.Color.Black
        Me.StartGameButton.Location = New System.Drawing.Point(85, 169)
        Me.StartGameButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StartGameButton.Name = "StartGameButton"
        Me.StartGameButton.Size = New System.Drawing.Size(199, 28)
        Me.StartGameButton.TabIndex = 1
        Me.StartGameButton.Text = "Start Game"
        Me.StartGameButton.UseVisualStyleBackColor = True
        '
        'GameLabel
        '
        Me.GameLabel.AutoSize = True
        Me.GameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLabel.ForeColor = System.Drawing.Color.White
        Me.GameLabel.Location = New System.Drawing.Point(77, 80)
        Me.GameLabel.Name = "GameLabel"
        Me.GameLabel.Size = New System.Drawing.Size(227, 46)
        Me.GameLabel.TabIndex = 2
        Me.GameLabel.Text = "Tank Game"
        '
        'SettingsButton
        '
        Me.SettingsButton.ForeColor = System.Drawing.Color.Black
        Me.SettingsButton.Location = New System.Drawing.Point(85, 240)
        Me.SettingsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(199, 30)
        Me.SettingsButton.TabIndex = 3
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'StartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.GameLabel)
        Me.Controls.Add(Me.StartGameButton)
        Me.ForeColor = System.Drawing.Color.Cornsilk
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "StartUp"
        Me.Text = "StartUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartGameButton As Button
    Friend WithEvents GameLabel As Label
    Friend WithEvents SettingsButton As Button
End Class
