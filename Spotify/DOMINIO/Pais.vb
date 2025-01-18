Public Class Pais
    Public Property IdPais As String
    Public Property Nombre As String
    Public ReadOnly Property PaisDAO As PaisDAO
    Public Sub New()
        Me.PaisDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.PaisDAO = New PaisDAO
        Me.IdPais = id
    End Sub

    Public Sub LeerTodosPaises()
        Me.PaisDAO.LeerTodas()
    End Sub

    Public Sub LeerPais()
        Me.PaisDAO.Leer(Me)
    End Sub
    Public Sub LeerPaisID()
        Me.PaisDAO.LeerID(Me)
    End Sub
    Public Function InsertarPais() As Integer
        Return Me.PaisDAO.Insertar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaisDAO.Borrar(Me)
    End Function

    Public Sub buscarId()
        Me.PaisDAO.buscarID(Me)
    End Sub
End Class
