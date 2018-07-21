Public Class GameGrid
    Public rows As Integer
    Public cols As Integer
    Public gameElementGrid As List(Of ArrayList)
    Public gridSquaresGrid As List(Of List(Of Square))
    Public environmentGrid As List(Of List(Of EnvironmentalEntity)) 'Holds all environment information
    Public squareSize As Double

    Public Sub New(rows As Integer, cols As Integer)
        Me.gameElementGrid = New List(Of ArrayList)
        Me.rows = rows
        Me.cols = cols
        Me.squareSize = Me.getSquareSize()
        Me.fillGrid()
    End Sub

    Public Sub fillGrid()
        For r As Integer = 0 To Me.rows
            gameElementGrid.Add(New ArrayList)
            For c As Integer = 0 To Me.cols
                Dim current = New Empty(New Coordinate(r, c), New Coordinate(r * Me.squareSize, c * Me.squareSize))
                gameElementGrid(r).Add(current)
            Next
        Next
    End Sub

    Public Function createEnvironmentalGrid(environmentalImages As EnvironmentalImages, map As List(Of List(Of Char)))
        Dim environmentalGrid = New List(Of List(Of EnvironmentalEntity))
        For r = 0 To map.Count - 1
            Dim row = map(r)
            Dim environmentalRow = New List(Of EnvironmentalEntity)
            For c = 0 To row.Count - 1
                Dim letter = row(c)
                Dim currentCoordinate = New Coordinate(r, c)
                Dim currentEnvironmentalEntity As EnvironmentalEntity
                Select Case letter
                    Case Grass.characterIdentifier
                        currentEnvironmentalEntity = New Grass(currentCoordinate, gridCoordToActual(currentCoordinate), environmentalImages.Grass)
                    Case Road.characterIdentifier
                        currentEnvironmentalEntity = New Road(currentCoordinate, gridCoordToActual(currentCoordinate), environmentalImages.Road)
                    Case Mountain.characterIdentifier
                        currentEnvironmentalEntity = New Mountain(currentCoordinate, gridCoordToActual(currentCoordinate), environmentalImages.Mountain)
                    Case Water.characterIdentifier
                        currentEnvironmentalEntity = New Water(currentCoordinate, gridCoordToActual(currentCoordinate), environmentalImages.Water)
                    Case Else
                        Throw New Exception("Unidentifiable Character")
                End Select
                currentEnvironmentalEntity.createElement(Me.squareSize, Game)
            Next
            environmentalGrid.Add(environmentalRow)
        Next
        Return environmentalGrid
    End Function

    Private Function gridCoordToActual(currentCoordinate As Coordinate)
        Dim actualCoordinate = New Coordinate(currentCoordinate.y * Me.squareSize, currentCoordinate.x * Me.squareSize)
        Return actualCoordinate
    End Function

    Public Sub updateGridCell(currentEntity As Entity, currentCoordinate As Coordinate)
        Me.gameElementGrid(currentCoordinate.y)(currentCoordinate.x) = currentEntity
    End Sub

    Public Sub deleteGridCell(currentCoordinate As Coordinate)
        Dim pictureElement = Me.gameElementGrid(currentCoordinate.y)(currentCoordinate.x).pictureElement
        Me.gameElementGrid(currentCoordinate.y)(currentCoordinate.x) = New Empty(currentCoordinate, gridCoordToActual(currentCoordinate))
        Game.Controls.Remove(pictureElement)
    End Sub

    Public Sub moveEntity(startCoordinate As Coordinate, endCoordinate As Coordinate)
        deleteGridCell(endCoordinate)
        Dim value = Me.gameElementGrid(startCoordinate.y)(startCoordinate.x)
        Me.gameElementGrid(endCoordinate.y)(endCoordinate.x) = value
        Me.gameElementGrid(startCoordinate.y)(startCoordinate.x) = New Empty(startCoordinate, gridCoordToActual(startCoordinate))
        Dim pictureElementLocation = getPlayerImageLocation(endCoordinate)
        value.pictureElement.Location = New System.Drawing.Point(pictureElementLocation.x, pictureElementLocation.y)
        value.actualCoordinate = gridCoordToActual(endCoordinate)
        value.gridCoordinate = endCoordinate
    End Sub

    Public Sub createSquareGrid(squareImages As SquareImages)
        Me.gridSquaresGrid = New List(Of List(Of Square))
        For r = 0 To Me.rows - 1
            Me.gridSquaresGrid.Add(New List(Of Square))
            For c = 0 To Me.cols - 1
                Dim coord = New Coordinate(r * Me.squareSize, c * Me.squareSize)
                Dim currentSquare = New Square(New Coordinate(r, c), New Coordinate(r * Me.squareSize, c * Me.squareSize), squareImages)
                currentSquare.createElement(Me.squareSize, Game)
                Me.gridSquaresGrid(r).Add(currentSquare)
            Next
        Next
    End Sub

    Private Function getSquareSize()
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
        For Each row In Me.gridSquaresGrid
            For Each square In row
                If square.changed = True Then
                    square.changed = False
                    square.pictureElement.Image = square.imageFile
                End If
            Next
        Next
    End Sub

    Private Function getPlayerImageLocation(coordinate As Coordinate)
        Dim imageLocation = gridCoordToActual(coordinate)
        imageLocation.x += squareSize * Entity.shiftPercent
        imageLocation.y += squareSize * Entity.shiftPercent
        Return imageLocation
    End Function
End Class