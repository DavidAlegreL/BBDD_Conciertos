Public Class ArtistaDAO
    Public ReadOnly Property Artista As Collection
    Public ReadOnly Property TopTusArtistas As Collection
    Public ReadOnly Property TopTusPaises As Collection
    Public Property PaisDA As PaisDAO
    Public ReadOnly Property canciones As List(Of Cancion)
    Public Property albumes As List(Of Album)
    Public Sub New()
        Me.Artista = New Collection
        Me.TopTusArtistas = New Collection
        Me.TopTusPaises = New Collection
        Me.PaisDA = New PaisDAO
        Me.canciones = New List(Of Cancion)
    End Sub

    Public Sub LeerId(ByRef art As Artista)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Artistas WHERE idArtista=" & art.Id & ";")
        For Each aux In col
            art.Nombre = aux(2).ToString
            art.PaisA = New Pais(aux(3).ToString)
            Me.PaisDA.LeerID(art.PaisA)
        Next
    End Sub

    Public Sub LeerTodas()
        Dim a As Artista
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Artistas ORDER BY idArtista")
        For Each aux In col
            a = New Artista(aux(1))
            a.Nombre = aux(2).ToString
            a.PaisA = New Pais(aux(3).ToString)
            Me.PaisDA.LeerID(a.PaisA)
            Me.Artista.Add(a)
        Next
    End Sub

    Public Sub Leer(ByRef a As Artista)
        Dim p As Pais = New Pais
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Artistas WHERE nombre='" & a.Nombre & "';")
        For Each aux In col
            a.Id = aux(1)
            a.PaisA.IdPais = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Artistas VALUES ('" & a.Id & "', '" & a.Nombre & "', '" & a.PaisA.IdPais & "');")
    End Function

    Public Function Actualizar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Artistas SET Nombre='" & a.Nombre & "', País='" & a.PaisA.IdPais & "' WHERE idArtista='" & a.Id & "';")
    End Function

    Public Function Borrar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Artistas WHERE idArtista='" & a.Id & "';")
    End Function

    Public Function CancionesPorArtista(ByRef ar As Artista) As List(Of Cancion)
        Dim canciones As New List(Of Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT c.* FROM canciones c JOIN albumes a ON c.Album = a.IdAlbum JOIN artistas ar ON a.Artista = ar.IdArtista WHERE ar.idArtista = " & ar.Id & ";")
        For Each aux In col
            aux = col.Item(1)
            col.Remove(1)
            Dim cancion As New Cancion()
            cancion.Id = aux.Item(1)
            cancion.Titulo = aux.Item(2)
            cancion.Duracion = aux.Item(3)
            cancion.cancioAlbum.Id = aux.Item(4)
            cancion.ordenCancion = aux.Item(5)
            canciones.Add(cancion)
        Next
        ' Asignar las canciones obtenidas a la propiedad canciones del objeto Artista
        ar.canciones = canciones
        Return canciones
    End Function
    Public Function AlbumesPorArtista(ByRef ar As Artista) As List(Of Album)
        Dim albumes As New List(Of Album)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT a.* FROM albumes a JOIN artistas ar ON a.Artista = ar.IdArtista WHERE ar.idArtista = " & ar.Id & ";")
        For Each aux In col
            aux = col.Item(1)
            col.Remove(1)
            Dim album As New Album()
            album.Id = aux.Item(1)
            album.Titulo = aux.Item(2)
            album.Año = aux.Item(3)
            album.ArtistaDelAlbum.Id = aux.Item(4).ToString
            albumes.Add(album)
        Next
        ' Asignar las canciones obtenidas a la propiedad canciones del objeto Artista
        ar.albumes = albumes
        Return albumes
    End Function
    Public Sub LeerTopTusArtistas(fecha_inicial As Date, fecha_final As Date)
        Dim a As Artista
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT art.* FROM ARTISTAS AS art Join conciertos c on c.Artista = art.idArtista WHERE c.FechaConcierto BETWEEN '" & fecha_inicial.Date & "' AND '" & fecha_final.Date & "' GROUP BY art.IdArtista ORDER BY COUNT(*) DESC;")
        For Each aux In col
            a = New Artista
            a.Id = aux.Item(1).ToString
            a.Nombre = aux.Item(2).ToString
            a.PaisA = New Pais(aux.Item(3).ToString)
            Me.PaisDA.LeerID(a.PaisA)
            Me.TopTusArtistas.Add(a)
        Next

    End Sub
    Public Sub LeerTopTusAlbumes(fecha_inicial As Date, fecha_final As Date)
        Dim a As Pais
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT p.* FROM paises AS p join sitio s on s.país = p.idPais Join conciertos c on c.Sitio = s.idSitio WHERE c.FechaConcierto BETWEEN '" & fecha_inicial.Date & "' AND '" & fecha_final.Date & "' GROUP BY p.idPais ORDER BY COUNT(*) DESC;")
        For Each aux In col
            a = New Pais
            a.IdPais = aux.Item(1)
            a.Nombre = aux.Item(2)
            Me.TopTusPaises.Add(a)
        Next

    End Sub

End Class
