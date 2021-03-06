﻿''' <summary>
''' Stores state information of elements, grid squares, and environments
''' </summary>
Public Class GameGrid
    Public rows As Integer
    Public cols As Integer
    Public gameWidth As Integer
    Public gameHeight As Integer
    Public gameElementGrid As List(Of ArrayList)
    Public gridSquaresGrid As List(Of List(Of Square))
    Public environmentGrid As List(Of List(Of EnvironmentalEntity)) 'Holds all environment information
    Public squareSize As Double

    Public Sub New(rows As Integer, cols As Integer)
        Me.gameElementGrid = New List(Of ArrayList)
        Me.rows = rows
        Me.cols = cols
        Me.gameHeight = Game.Size.Height - Game.originCoord.y
        Me.gameWidth = Game.Size.Width - Game.originCoord.x
        Me.squareSize = Me.getSquareSize()
        Me.fillGrid()
    End Sub

    ''' <summary>
    ''' Fills element grid with empty
    ''' </summary>
    Public Sub fillGrid()
        For r As Integer = 0 To Me.rows
            gameElementGrid.Add(New ArrayList)
            For c As Integer = 0 To Me.cols
                Dim gridCoord = New Coordinate(r, c)
                Dim current = New Empty(gridCoord, gridCoordToActual(gridCoord))
                gameElementGrid(r).Add(current)
            Next
        Next
    End Sub

    ''' <summary>
    ''' Creates environment grid based on map
    ''' </summary>
    ''' <param name="environmentalImages"></param>
    ''' <param name="map"></param>
    ''' <returns></returns>
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
                currentEnvironmentalEntity.pictureElement.BringToFront()
                environmentalRow.Add(currentEnvironmentalEntity)
            Next
            environmentalGrid.Add(environmentalRow)
        Next
        Return environmentalGrid
    End Function

    ''' <summary>
    ''' Transform grid coordinate to actual coordinate
    ''' </summary>
    ''' <param name="currentCoordinate"></param>
    ''' <returns></returns>
    Public Function gridCoordToActual(currentCoordinate As Coordinate)
        Dim actualCoordinate = New Coordinate(Game.originCoord.y + currentCoordinate.y * Me.squareSize, Game.originCoord.x + currentCoordinate.x * Me.squareSize)
        Return actualCoordinate
    End Function

    ''' <summary>
    ''' Updates grid cell
    ''' </summary>
    ''' <param name="currentEntity"></param>
    ''' <param name="currentCoordinate"></param>
    Public Sub updateGridCell(currentEntity As Entity, currentCoordinate As Coordinate)
        Me.gameElementGrid(currentCoordinate.y)(currentCoordinate.x) = currentEntity
    End Sub

    ''' <summary>
    ''' Deletes element and picture
    ''' </summary>
    ''' <param name="currentCoordinate"></param>
    Public Sub deleteGridCell(currentCoordinate As Coordinate)
        Dim pictureElement = Me.gameElementGrid(currentCoordinate.y)(currentCoordinate.x).pictureElement
        Me.gameElementGrid(currentCoordinate.y)(currentCoordinate.x) = New Empty(currentCoordinate, gridCoordToActual(currentCoordinate))
        Game.Controls.Remove(pictureElement)
    End Sub

    ''' <summary>
    ''' Moves entity from one place to another
    ''' </summary>
    ''' <param name="startCoordinate"></param>
    ''' <param name="endCoordinate"></param>
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

    ''' <summary>
    ''' Creates square grid which is the framework of grid displayed
    ''' </summary>
    ''' <param name="squareImages"></param>
    Public Sub createSquareGrid(squareImages As SquareImages)
        Me.gridSquaresGrid = New List(Of List(Of Square))
        For r = 0 To Me.rows - 1
            Me.gridSquaresGrid.Add(New List(Of Square))
            For c = 0 To Me.cols - 1
                Dim coord = New Coordinate(r, c)
                Dim currentSquare = New Square(coord, Me.gridCoordToActual(coord), squareImages)
                currentSquare.createElement(Me.squareSize, Game)
                Me.gridSquaresGrid(r).Add(currentSquare)
            Next
        Next
    End Sub

    ''' <summary>
    ''' Gets square size based on game width and rows and cols
    ''' </summary>
    ''' <returns></returns>
    Private Function getSquareSize()
        Dim selectedSize As Double
        If Me.cols > Me.rows Then
            selectedSize = Me.gameWidth / Me.cols
        Else
            selectedSize = Me.gameWidth / Me.rows
        End If
        Return selectedSize
    End Function

    ''' <summary>
    ''' Clears selected elements in grid
    ''' </summary>
    Public Sub clearSelected()
        For Each row In Me.gridSquaresGrid
            For Each square In row
                If square.changed = True Then
                    square.changed = False
                    square.pictureElement.Image = square.imageFile
                End If
                If square.showingLabel = True Then
                    Game.Controls.Remove(square.label)
                    square.label = Nothing
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