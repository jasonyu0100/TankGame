Public Class Square
    'Displays a grid square
    Inherits Entity
    Public selectImageFile As Image
    Public changed As Boolean = False
    Public squareImages As SquareImages
    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, squareImages As SquareImages)
        MyBase.New(gridCoordinate, actualCoordinate, squareImages.normalImage)
        Me.squareImages = squareImages
        Me.changed = False
    End Sub

    Public Sub setImageFile(style As SquareStyleEnum)
        Select Case style
            Case SquareStyleEnum.Normal
                Me.pictureElement.Image = Me.squareImages.normalImage
            Case SquareStyleEnum.Selected
                Me.pictureElement.Image = Me.squareImages.selectedImage
                Me.changed = True
            Case SquareStyleEnum.Highlight
                Me.pictureElement.Image = Me.squareImages.highLightedImage
            Case Else
                Throw New Exception("Style is invalid: " & style.ToString)
        End Select
    End Sub

    Public Overloads Sub createElement(squareSize As Double, form As Form)
        Dim pictureElement = New System.Windows.Forms.PictureBox()
        pictureElement.Image = Me.imageFile
        pictureElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        pictureElement.Size = New System.Drawing.Size(squareSize, squareSize)
        pictureElement.Location = New System.Drawing.Point(Me.actualCoordinate.x, Me.actualCoordinate.y)
        pictureElement.SendToBack()
        form.Controls.Add(pictureElement)
        AddHandler pictureElement.Click, AddressOf pictureElement_Click
        Me.pictureElement = pictureElement
    End Sub

    Private Sub pictureElement_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.changed = True Then
            Game.executeAction(Me.gridCoordinate)
        End If
    End Sub
End Class

Public Enum SquareStyleEnum
    Normal
    Selected
    Highlight
End Enum

Public Structure SquareImages
    Public normalImage As Image
    Public selectedImage As Image
    Public highLightedImage As Image
End Structure
