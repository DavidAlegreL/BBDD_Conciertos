Public Class AlbumDAO
    Public ReadOnly Property Albumes As Collection
    Public Property ArtistaDA As ArtistaDAO
    Public Sub New()
        Me.Albumes = New Collection
        Me.ArtistaDA = New ArtistaDAO
    End Sub

    Public Sub LeerTodas()
        Dim alb As Album
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Albumes ORDER BY idAlbum")
        For Each aux In col
            alb = New Album(aux(1))
            alb.Titulo = aux(2).ToString
            alb.Año = aux(3).ToString
            alb.ArtistaDelAlbum = New Artista(aux(4).ToString)
            Me.ArtistaDA.LeerId(alb.ArtistaDelAlbum)
            Me.Albumes.Add(alb)
        Next
    End Sub

    Public Sub Leer(ByRef alb As Album)
        Dim a As Artista = New Artista
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Albumes WHERE nombreAlbum='" & alb.Titulo & "';")
        For Each aux In col
            alb.Id = aux(1)
            alb.Año = aux(3)
            alb.ArtistaDelAlbum.Id = aux(4).ToString
        Next
    End Sub

    Public Sub LeerID(ByRef alb As Album)
        Dim a As Artista = New Artista
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Albumes WHERE idAlbum='" & alb.Id & "';")
        For Each aux In col
            alb.Titulo = aux(2).ToString
            alb.Año = aux(3).ToString
            alb.ArtistaDelAlbum = New Artista(aux(4).ToString)
            Me.ArtistaDA.LeerId(alb.ArtistaDelAlbum)
        Next
    End Sub

    Public Function Insertar(ByVal alb As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Albumes VALUES ('" & alb.Id & "', '" & alb.Titulo & "', '" & alb.Año & "', '" & alb.ArtistaDelAlbum.Id & "');")
    End Function

    Public Function Actualizar(ByVal alb As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Albumes SET nombreAlbum='" & alb.Titulo & "', AñoAlbum='" & alb.Año & "', Artista='" & alb.ArtistaDelAlbum.Id & "' WHERE idAlbum='" & alb.Id & "';")
    End Function

    Public Function Borrar(ByVal alb As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Albumes WHERE idAlbum='" & alb.Id & "';")
    End Function
End Class
