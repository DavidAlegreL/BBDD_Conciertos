Public Class Cancion
    Public Property Id As Integer
    Public Property Titulo As String
    Public Property Duracion As Integer
    Public Property cancioAlbum As Album
    Public Property ordenCancion As Integer

    Public ReadOnly Property CancDAO As CancionDAO

    Public Sub New()
        Me.CancDAO = New CancionDAO
        Me.cancioAlbum = New Album
    End Sub

    Public Sub New(id As String)
        Me.CancDAO = New CancionDAO
        Me.Id = id
        Me.cancioAlbum = New Album
    End Sub

    Public Sub LeerTodasCanciones()
        Me.CancDAO.LeerTodas()
    End Sub

    Public Sub LeerCancion()
        Me.CancDAO.Leer(Me)
    End Sub
    Public Sub LeerCancionNombre(Titulo)
        Me.CancDAO.LeerNombre(Me)
    End Sub
    Public Sub LeerCancionID(Id)
        Me.CancDAO.LeerID(Me)
    End Sub
    Public Function InsertarCancion() As Integer
        Return Me.CancDAO.Insertar(Me)
    End Function

    Public Function ActualizarCancion() As Integer
        Return Me.CancDAO.Actualizar(Me)
    End Function

    Public Function BorrarCancion() As Integer
        Return Me.CancDAO.Borrar(Me)
    End Function
End Class
