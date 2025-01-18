Public Class Sitio
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property PaisS As Pais
    Public Property Tipo As String

    Public ReadOnly Property SitiDAO As SitioDAO
    Public Sub New()
        Me.SitiDAO = New SitioDAO
        Me.PaisS = New Pais
    End Sub

    Public Sub New(id As String)
        Me.SitiDAO = New SitioDAO
        Me.Id = id
        Me.PaisS = New Pais
    End Sub

    Public Sub LeerTodosSitios()
        Me.SitiDAO.LeerTodas()
    End Sub

    Public Sub LeerSitio()
        Me.SitiDAO.Leer(Me)
    End Sub
    Public Sub LeerSitioID()
        Me.SitiDAO.LeerID(Me)
    End Sub
    Public Function InsertarSitio() As Integer
        Return Me.SitiDAO.Insertar(Me)
    End Function

    Public Function ActualizarSitio() As Integer
        Return Me.SitiDAO.Actualizar(Me)
    End Function

    Public Function BorrarSitio() As Integer
        Return Me.SitiDAO.Borrar(Me)
    End Function
End Class
