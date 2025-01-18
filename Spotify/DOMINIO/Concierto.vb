Public Class Concierto
    Public Property Id As Integer
    Public Property Artista As Artista
    Public Property Sitio As Sitio
    Public Property Fecha As DateTime

    Public ReadOnly Property ConciDAO As ConciertoDAO

    Public Sub New()
        Me.ConciDAO = New ConciertoDAO
        Me.Artista = New Artista
        Me.Sitio = New Sitio
    End Sub
    Public Sub New(id As String)
        Me.ConciDAO = New ConciertoDAO
        Me.Id = id
        Me.Artista = New Artista
        Me.Sitio = New Sitio
    End Sub

    Public Sub LeerTodosConciertos()
        Me.ConciDAO.LeerTodas()
    End Sub

    Public Sub LeerConcierto()
        Me.ConciDAO.Leer(Me)
    End Sub

    Public Sub LeerConciertoID()
        Me.ConciDAO.LeerID(Me)
    End Sub

    Public Function InsertarConcierto() As Integer
        Return Me.ConciDAO.Insertar(Me)
    End Function

    Public Function ActualizarConcierto() As Integer
        Return Me.ConciDAO.Actualizar(Me)
    End Function

    Public Function BorrarConcierto() As Integer
        Return Me.ConciDAO.Borrar(Me)
    End Function

    Public Sub LeerporIdyPais(id As String, pais As String)
        Me.ConciDAO.leerConciertosPorIdYPais(id, pais)
    End Sub

    Public Sub LeerporIdSitio(id As Integer)
        Me.ConciDAO.leerConciertosPorIdSitio(id)
    End Sub
End Class
