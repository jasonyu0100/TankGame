Public Class Player
    Inherits Entity
    Public playerNum As Integer
    Public playerName As String
    Public shiftPercent = 0.1
    Public playerStats As PlayerStats

    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate, playerNum As Integer, imageFile As Image, playerName As String, playerStats As PlayerStats)
        MyBase.New(gridCoordinate, actualCoordinate, imageFile)
        Me.playerNum = playerNum
        Me.playerName = playerName
        Me.entityType = EntityType.Player
        Me.playerStats = playerStats
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
End Structure
