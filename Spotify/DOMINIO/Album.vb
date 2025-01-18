Public Class Album
    Public Property Id As Integer
    Public Property Titulo As String
    Public Property Año As Integer
    Public Property ArtistaDelAlbum As Artista
    Public ReadOnly Property AlbDAO As AlbumDAO

    Public Overrides Function ToString() As String
        Return Me.Titulo()
    End Function

    Public Sub New()
        Me.AlbDAO = New AlbumDAO
        Me.ArtistaDelAlbum = New Artista
    End Sub
    Public Sub New(id As String)
        Me.AlbDAO = New AlbumDAO
        Me.Id = id
        Me.ArtistaDelAlbum = New Artista
    End Sub

    Public Sub LeerTodosAlbumes()
        Me.AlbDAO.LeerTodas()
    End Sub

    Public Sub LeerAlbum()
        Me.AlbDAO.Leer(Me)
    End Sub
    Public Sub LeerAlbumID()
        Me.AlbDAO.LeerID(Me)
    End Sub
    Public Function InsertarAlbum() As Integer
        Return Me.AlbDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlbum() As Integer
        Return Me.AlbDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlbum() As Integer
        Return Me.AlbDAO.Borrar(Me)
    End Function
End Class
