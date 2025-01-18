Public Class SitioDAO
    Public ReadOnly Property Sitio As Collection
    Public Property PaisDA As PaisDAO
    Public Sub New()
        Me.Sitio = New Collection
        Me.PaisDA = New PaisDAO
    End Sub

    Public Sub LeerTodas()
        Dim p As Sitio
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Sitio ORDER BY idSitio")
        For Each aux In col
            p = New Sitio(aux(1))
            p.Nombre = aux(2).ToString
            p.PaisS = New Pais(aux(3).ToString)
            Me.PaisDA.LeerID(p.PaisS)
            p.Tipo = aux(4).ToString
            Me.Sitio.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Sitio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Sitio WHERE NombreSitio='" & p.Nombre & "';")
        For Each aux In col
            p.Id = aux(1)
            p.PaisS.IdPais = aux(3).ToString
            p.Tipo = aux(4).ToString
        Next
    End Sub

    Public Sub LeerID(ByRef p As Sitio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Sitio WHERE idSitio='" & p.Id & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.PaisS = New Pais(aux(3).ToString)
            Me.PaisDA.leerID(p.PaisS)
            p.Tipo = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Sitio VALUES ('" & p.Id & "', '" & p.Nombre & "', '" & p.PaisS.IdPais & "', '" & p.Tipo & "');")
    End Function

    Public Function Actualizar(ByVal p As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Sitio SET NombreSitio='" & p.Nombre & "', País='" & p.PaisS.IdPais & "', Tipo='" & p.Tipo & "' WHERE idSitio='" & p.Id & "';")
    End Function

    Public Function Borrar(ByVal p As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Sitio WHERE idSitio='" & p.Id & "';")
    End Function

End Class
