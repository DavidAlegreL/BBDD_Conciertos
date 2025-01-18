Public Class PaisDAO
    Public ReadOnly Property Pais As Collection

    Public Sub New()
        Pais = New Collection
    End Sub
    Public Sub LeerTodas()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Paises ORDER BY IdPais")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            p.Nombre = aux(2).ToString
            Me.Pais.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Paises WHERE NombrePais='" & p.Nombre & "';")
        For Each aux In col
            p.IdPais = aux(1)
        Next
    End Sub
    Public Sub LeerID(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Paises WHERE idPais='" & p.IdPais & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
        Next
    End Sub

    Public Sub buscarID(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select IdPais from Paises where NombrePais='" & p.Nombre & "';")
        For Each aux In col
            p.IdPais = aux(1).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Paises VALUES ('" & p.IdPais & "','" & p.Nombre & "');")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Paises WHERE idPais='" & p.IdPais & "';")
    End Function
End Class
