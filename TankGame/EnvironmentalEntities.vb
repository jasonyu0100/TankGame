Public Class EnvironmentalEntity
    Inherits Entity
    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, imageFile As Image)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
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
        Dim correspondingGridSquare = Game.currentGame.grid.gridSquaresGrid(Me.gridCoordinate.y)(Me.gridCoordinate.x)
        If correspondingGridSquare.changed = True Then
            Game.executeAction(Me.gridCoordinate)
        End If
    End Sub
End Class

Public Class Water
    Inherits EnvironmentalEntity
    Public Const characterIdentifier = "w"
    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, imageFile As Image)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.entityType = EntityType.Water
    End Sub
End Class

Public Class Grass
    Inherits EnvironmentalEntity
    Public Const characterIdentifier = "g"
    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, imageFile As Image)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.entityType = EntityType.Grass
    End Sub
End Class

Public Class Road
    Inherits EnvironmentalEntity
    Public Const characterIdentifier = "r"
    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, imageFile As Image)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.entityType = EntityType.Road
    End Sub
End Class

Public Class Mountain
    Inherits EnvironmentalEntity
    Public Const characterIdentifier = "m"
    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, imageFile As Image)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.entityType = EntityType.Mountain
    End Sub
End Class

Public Structure EnvironmentalImages
    Public Water As Image
    Public Grass As Image
    Public Road As Image
    Public Mountain As Image
End Structure