Public Class Square
    'Displays a grid square
    Inherits Entity
    Public selectImageFile As Image
    Public selected As Boolean = False
    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, imageFile As Image, selectImageFile As Image)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.selected = False
        Me.selectImageFile = selectImageFile
    End Sub

    Public Sub setSelectImageFile()
        Me.pictureElement.Image = Me.selectImageFile
        Me.selected = True
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
        If Me.selected = True Then
            Game.executeAction(Me.gridCoordinate)
        End If
    End Sub
End Class
