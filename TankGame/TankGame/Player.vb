Public Class Player
    Inherits Entity
    Public playerNum As Integer
    Public playerName As String
    Public playerHealth As Integer = 100
    Public shootRange = 4
    Public buildRange = 1
    Public moveRange = 2
    Public turretRange = 1
    Public shiftPercent = 0.1

    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, playerNum As Integer, imageFile As Image, playerName As String)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.playerNum = playerNum
        Me.playerName = playerName
    End Sub

    Public Overloads Sub createElement(squareSize As Double, form As Form)
        Dim shift As Double = squareSize * Me.shiftPercent
        Me.pictureElement = New System.Windows.Forms.PictureBox()
        form.Controls.Add(Me.pictureElement)
        Me.pictureElement.Image = Me.imageFile
        Me.pictureElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureElement.Size = New System.Drawing.Size(squareSize - 2 * shift, squareSize - 2 * shift)
        Me.pictureElement.Location = New System.Drawing.Point(Me.actualCoordinate.x + shift, Me.actualCoordinate.y + shift)
    End Sub

End Class
