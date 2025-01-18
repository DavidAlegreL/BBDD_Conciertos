Public Class CancionDAO
    Public ReadOnly Property Canciones As Collection
    Public Property AlbumDA As AlbumDAO

    Public Sub New()
        Me.Canciones = New Collection
        Me.AlbumDA = New AlbumDAO
    End Sub

    Public Sub LeerTodas()
        Dim p As Cancion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Canciones ORDER BY idCancion")
        For Each aux In col
            p = New Cancion(aux(1))
            p.Titulo = aux(2).ToString
            p.Duracion = aux(3).ToString
            p.cancioAlbum = New Album(aux(4).ToString)
            Me.AlbumDA.LeerID(p.cancioAlbum)
            p.ordenCancion = aux(5).ToString
            Me.Canciones.Add(p)
        Next
    End Sub

    Public Sub LeerNombre(ByRef p As Cancion)
        Dim alb As Album = New Album
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Canciones WHERE nombreCancion='" & p.Titulo & "';")
        For Each aux In col
            p.Id = aux(1).ToString
            p.Duracion = aux(3).ToString
            p.cancioAlbum = New Album(aux(4).ToString)
            Me.AlbumDA.LeerID(p.cancioAlbum)
            p.ordenCancion = aux(5).ToString
        Next
    End Sub
    Public Sub Leer(ByRef p As Cancion)
        Dim alb As Album = New Album
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Canciones WHERE nombreCancion='" & p.Titulo & "';")
        For Each aux In col
            p.Id = aux(1)
            p.Duracion = aux(3)
            p.cancioAlbum.Id = aux(4)
            p.ordenCancion = aux(5)
        Next
    End Sub
    Public Sub LeerID(ByRef p As Cancion)
      
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Canciones WHERE idCancion='" & p.Id & "';")
        For Each aux In col
            p.Titulo = aux(2).ToString
            p.Duracion = aux(3).ToString
            p.cancioAlbum = New Album(aux(4).ToString)
            Me.AlbumDA.LeerID(p.cancioAlbum)
            p.ordenCancion = aux(5).ToString
        Next
    End Sub
    Public Function Insertar(ByVal p As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Canciones VALUES ('" & p.Id & "', '" & p.Titulo & "', '" & p.Duracion & "', '" & p.cancioAlbum.Id & "', '" & p.ordenCancion & "');")
        End Function

    Public Function Actualizar(ByVal p As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Canciones SET NombreCancion='" & p.Titulo & "', Duración='" & p.Duracion & "', Album='" & p.cancioAlbum.Id & "', OrdenCanción='" & p.ordenCancion & "' WHERE idCancion='" & p.Id & "';")
    End Function

    Public Function Borrar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Canciones WHERE idCancion='" & c.Id & "';")
    End Function

    Public Sub LeerPorId(ByRef canc As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Canciones WHERE idCancion=" & canc.Id & ";")
        For Each aux In col
            canc.Titulo = aux(2).ToString
            canc.Duracion = aux(3)
            canc.cancioAlbum = aux(4)
            canc.ordenCancion = aux(5)
        Next
    End Sub


End Class
