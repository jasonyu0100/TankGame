''' <summary>
''' Defines an entity, that has a coordinate and picture
''' Parent of all other classes occupying grid
''' </summary>
Public Class Entity
    Public Const shiftPercent = 0.03
    Public actualCoordinate As Coordinate
    Public gridCoordinate As Coordinate
    Public imageFile As Image
    Public pictureElement As PictureBox
    Public entityType As EntityType

    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, imageFile As Image)
        Me.actualCoordinate = actualCoordinate
        Me.gridCoordinate = gridCoordinate
        Me.imageFile = imageFile
    End Sub

    Public Sub createElement(squareSize As Double, form As Form)
        Dim pictureElement = New System.Windows.Forms.PictureBox()
        pictureElement.Image = Me.imageFile
        pictureElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        pictureElement.Size = New System.Drawing.Size(squareSize, squareSize)
        pictureElement.Location = New System.Drawing.Point(Me.actualCoordinate.x, Me.actualCoordinate.y)
        pictureElement.SendToBack()
        Me.pictureElement = pictureElement
        form.Controls.Add(Me.pictureElement)
    End Sub
End Class
