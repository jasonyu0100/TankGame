Public Class Empty
    Inherits Entity
    Public Sub New(gridCoordinate As Coordinate, actualCoordinate As Coordinate)
        MyBase.New(gridCoordinate, actualCoordinate, Nothing)
    End Sub
End Class
