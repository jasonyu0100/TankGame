﻿Public Class Player
    Inherits Entity
    Public playerNum As Integer
    Public playerName As String
    Public playerStats As PlayerStats
    Public healthLabel As Label

    Public turretStats As TurretStats
    Public turrets As List(Of Turret)
    Public turretImageFile As Image
    Public currentTurret As Turret
    Public traversals As Integer

    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, playerNum As Integer, imageFile As Image, playerName As String, playerStats As PlayerStats, turretStats As TurretStats, turretImageFile As Image)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.playerNum = playerNum
        Me.playerName = playerName
        Me.entityType = EntityType.Player
        Me.playerStats = playerStats
        Me.turretStats = turretStats
        Me.turretImageFile = turretImageFile
        Me.turrets = New List(Of Turret)
        Me.currentTurret = Nothing
    End Sub

    Public Overloads Sub createElement(squareSize As Double, form As Form)
        Dim shift As Double = squareSize * shiftPercent
        Dim pictureElement = New System.Windows.Forms.PictureBox()
        form.Controls.Add(pictureElement)
        pictureElement.Image = Me.imageFile
        pictureElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        pictureElement.Size = New System.Drawing.Size(squareSize - 2 * shift, squareSize - 2 * shift)
        pictureElement.Location = New System.Drawing.Point(Me.actualCoordinate.x + shift, Me.actualCoordinate.y + shift)
        AddHandler pictureElement.Click, AddressOf pictureElement_Click
        pictureElement.BringToFront()
        pictureElement.BackColor = Color.Transparent
        Me.pictureElement = pictureElement

        Dim label = New System.Windows.Forms.Label()
        label.Location = New System.Drawing.Point(Me.actualCoordinate.x + shift, Me.actualCoordinate.y + (4 * squareSize / 5) - shift)
        label.Size = New System.Drawing.Size(squareSize / 3 + 5, squareSize / 5)
        label.Text = Me.playerStats.health
        label.BackColor = Color.Red
        label.ForeColor = Color.Black
        form.Controls.Add(label)
        label.BringToFront()
        Me.healthLabel = label
    End Sub

    Public Sub updateHealthLabel(squareSize As Double)
        Dim shift As Double = squareSize * shiftPercent
        healthLabel.Location = New System.Drawing.Point(Me.actualCoordinate.x + shift, Me.actualCoordinate.y + (4 * squareSize / 5) - shift)
    End Sub

    Private Sub pictureElement_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim correspondingGridSquare = Game.currentGame.grid.gridSquaresGrid(Me.gridCoordinate.y)(Me.gridCoordinate.x)
        If correspondingGridSquare.changed = True Then
            Game.executeAction(Me.gridCoordinate)
        End If
    End Sub
End Class

Public Structure PlayerStats
    Public health As Integer
    Public attack As Integer
    Public speed As Integer
    Public armor As Integer
    Public shootRange As Integer
    Public moveRange As Integer
    Public buildRange As Integer
    Public turretRange As Integer
    Public actionPoints As Integer
    Public maxActionPoints As Integer
End Structure
