Public Class Grid
    Public rows As Integer
    Public cols As Integer
    Public grid As List(Of List(Of Entity))
    Public squares As List(Of List(Of Square))
    Public squareSize As Double
    Public shiftPercent = 0.1

    Public Sub New(rows As Integer, cols As Integer)
        Me.grid = New List(Of List(Of Entity))
        Me.rows = rows
        Me.cols = cols
        Me.squareSize = Me.getSquareSize()
        Me.fillGrid()
    End Sub

    Public Sub fillGrid()
        For r As Integer = 0 To Me.rows
            grid.Add(New List(Of Entity))
            For c As Integer = 0 To Me.cols
                Dim current = New Empty(New Coordinate(r, c), New Coordinate(r * Me.squareSize, c * Me.squareSize))
                grid(r).Add(current)
            Next
        Next
    End Sub

    Public Function gridCoordToActual(currentCoordinate As Coordinate)
        Dim actualCoordinate = New Coordinate(currentCoordinate.y * Me.squareSize, currentCoordinate.x * Me.squareSize)
        Return actualCoordinate
    End Function

    Public Sub updateGridCell(currentEntity As Entity, currentCoordinate As Coordinate)
        Me.grid(currentCoordinate.y)(currentCoordinate.x) = currentEntity
    End Sub

    Public Sub deleteGridCell(currentCoordinate As Coordinate)
        Dim pictureElement = Me.grid(currentCoordinate.y)(currentCoordinate.x).pictureElement
        Me.grid(currentCoordinate.y)(currentCoordinate.x) = New Empty(currentCoordinate, gridCoordToActual(currentCoordinate))
        Game.Controls.Remove(pictureElement)
    End Sub

    Public Sub moveEntity(startCoordinate As Coordinate, endCoordinate As Coordinate)
        deleteGridCell(endCoordinate)
        Dim value = Me.grid(startCoordinate.y)(startCoordinate.x)
        Me.grid(endCoordinate.y)(endCoordinate.x) = value
        Me.grid(startCoordinate.y)(startCoordinate.x) = New Empty(startCoordinate, gridCoordToActual(startCoordinate))
        Dim pictureElementLocation = getImageLocation(endCoordinate)
        value.pictureElement.Location = New System.Drawing.Point(pictureElementLocation.x, pictureElementLocation.y)
        value.actualCoordinate = gridCoordToActual(endCoordinate)
        value.gridCoordinate = endCoordinate
    End Sub

    Public Function getEntity(givenCoordinate As Coordinate)
        Return Me.grid(givenCoordinate.y)(givenCoordinate.x)
    End Function

    Public Sub createSquareGrid(gridSquare As String, selectionSquare As String)
        Dim normalSquare = Image.FromFile(gridSquare)
        Dim selectedSquare = Image.FromFile(selectionSquare)
        Me.squares = New List(Of List(Of Square))
        For r = 0 To Me.rows - 1
            Me.squares.Add(New List(Of Square))
            For c = 0 To Me.cols - 1
                Dim coord = New Coordinate(r * Me.squareSize, c * Me.squareSize)
                Dim currentSquare = New Square(New Coordinate(r, c), New Coordinate(r * Me.squareSize, c * Me.squareSize), normalSquare, selectedSquare)
                currentSquare.createElement(Me.squareSize, Game)
                Me.squares(r).Add(currentSquare)
            Next
        Next
    End Sub

    Public Function getSquareSize()
        Dim width = Game.Size.Width
        Dim selectedSize As Double
        If Me.cols > Me.rows Then
            selectedSize = width / Me.cols
        Else
            selectedSize = width / Me.rows
        End If
        Return selectedSize
    End Function

    Public Sub clearSelected()
        For Each row In Me.squares
            For Each square In row
                If square.selected = True Then
                    square.selected = False
                    square.pictureElement.Image = square.imageFile
                End If
            Next
        Next
    End Sub

    Public Function getImageLocation(coordinate As Coordinate)
        Dim imageLocation = gridCoordToActual(coordinate)
        imageLocation.x += squareSize * Me.shiftPercent
        imageLocation.y += squareSize * Me.shiftPercent
        Return imageLocation
    End Function
End Class