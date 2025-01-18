Public Class Artista
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property PaisA As Pais
    Public ReadOnly Property ArtisDAO As ArtistaDAO
    Public Property canciones As List(Of Cancion)
    Public Property albumes As List(Of Album)
    Public Sub ObtenerCanciones()
        Me.canciones = Me.ArtisDAO.CancionesPorArtista(Me)
    End Sub
    Public Sub ObtenerAlbumes()
        Me.albumes = Me.ArtisDAO.AlbumesPorArtista(Me)
    End Sub
    Public Sub New()
        Me.ArtisDAO = New ArtistaDAO
        Me.PaisA = New Pais
        Me.canciones = New List(Of Cancion)
    End Sub
    Public Sub New(id As String)
        Me.ArtisDAO = New ArtistaDAO
        Me.Id = id
        Me.PaisA = New Pais
        Me.canciones = New List(Of Cancion)
    End Sub

    Public Sub LeerTodosArtistas()
        Me.ArtisDAO.LeerTodas()
    End Sub

    Public Sub LeerArtista()
        Me.ArtisDAO.Leer(Me)
    End Sub
    Public Sub LeerArtistaID()
        Me.ArtisDAO.LeerId(Me)
    End Sub
    Public Function InsertarArtista() As Integer
        Return Me.ArtisDAO.Insertar(Me)
    End Function

    Public Function ActualizarArtista() As Integer
        Return Me.ArtisDAO.Actualizar(Me)
    End Function

    Public Function BorrarArtista() As Integer
        Return Me.ArtisDAO.Borrar(Me)
    End Function
    Public Sub LeerId()
        Me.ArtisDAO.LeerId(Me)
    End Sub
    Public Sub LeerTopTusArtistas(fecha_inicial As Date, fecha_final As Date)
        Me.ArtisDAO.LeerTopTusArtistas(fecha_inicial, fecha_final)
    End Sub
    Public Sub LeerTopTusAlbumes(fecha_inicial As Date, fecha_final As Date)
        Me.ArtisDAO.LeerTopTusAlbumes(fecha_inicial, fecha_final)
    End Sub
End Class
