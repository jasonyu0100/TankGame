Public Class Turret
    Inherits Entity
    Public shiftPercent = 0.1
    Public turretStats As TurretStats
    Public playerNum As Integer
    Public entityType As EntityType

    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, playerNum As Integer, imageFile As Image, turretStats As TurretStats)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.turretStats = turretStats
        Me.playerNum = playerNum
        Me.entityType = EntityType.Turret
    End Sub

    Public Overloads Sub createElement(squareSize As Double, form As Form)
        Dim shift As Double = squareSize * Me.shiftPercent
        Dim pictureElement = New System.Windows.Forms.PictureBox()
        form.Controls.Add(pictureElement)
        pictureElement.Image = Me.imageFile
        pictureElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        pictureElement.Size = New System.Drawing.Size(squareSize - 2 * shift, squareSize - 2 * shift)
        pictureElement.Location = New System.Drawing.Point(Me.actualCoordinate.x + shift, Me.actualCoordinate.y + shift)
        AddHandler pictureElement.Click, AddressOf pictureElement_Click
        Me.pictureElement = pictureElement
    End Sub

    Private Sub pictureElement_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim correspondingGridSquare = Game.currentGame.grid.squares(Me.gridCoordinate.y)(Me.gridCoordinate.x)
        If correspondingGridSquare.changed = True Then
            Game.executeAction(Me.gridCoordinate)
        End If
    End Sub
End Class

Public Structure TurretStats
    Public health As Integer
    Public attack As Integer
    Public armor As Integer
    Public shootRange As Integer
End Structure
