Public Class ConciertoDAO
    Public ReadOnly Property Conciertos As Collection
    Public Property ArtistaDA As ArtistaDAO
    Public Property SitioDA As SitioDAO
    Public ReadOnly Property SitioConcierto As Collection
    Public ReadOnly Property conciertosFiltrados As Collection
    Public Sub New()
        Conciertos = New Collection
        Me.ArtistaDA = New ArtistaDAO
        Me.SitioDA = New SitioDAO
        Me.conciertosFiltrados = New Collection
        Me.SitioConcierto = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim c As Concierto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Conciertos ORDER BY idConcierto")
        For Each aux In col
            c = New Concierto(aux(1))
            c.Artista = New Artista(aux(2).ToString)
            Me.ArtistaDA.LeerId(c.Artista)
            c.Sitio = New Sitio(aux(3).ToString)
            Me.SitioDA.LeerID(c.Sitio)
            c.Fecha = Convert.ToDateTime(aux(4))
            Me.Conciertos.Add(c)
        Next
    End Sub

    Public Sub Leer(ByRef c As Concierto)
        Dim a As Artista = New Artista
        Dim s As Sitio = New Sitio
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Conciertos WHERE idConcierto='" & c.Id & "';")
        For Each aux In col
            c.Artista.Id = aux(2)
            c.Sitio.Id = aux(3)
            c.Fecha = Convert.ToDateTime(aux(4))
        Next
    End Sub
    Public Sub LeerID(ByRef c As Concierto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Conciertos WHERE idConcierto='" & c.Id & "';")
        For Each aux In col
            c.Artista = New Artista(aux(2).ToString)
            Me.ArtistaDA.LeerId(c.Artista)
            c.Sitio = New Sitio(aux(3).ToString)
            Me.SitioDA.LeerID(c.Sitio)
            c.Fecha = Convert.ToDateTime(aux(4))
        Next
    End Sub

    Public Function Insertar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Conciertos VALUES ('" & c.Id & "', '" & c.Artista.Id & "', '" & c.Sitio.Id & "', '" & c.Fecha.ToString("yyyy-MM-dd") & "');")
    End Function

    Public Function Actualizar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Conciertos SET FechaConcierto='" & c.Fecha.ToString("yyyy-MM-dd") & "', Artista='" & c.Artista.Id & "', Sitio='" & c.Sitio.Id & "' WHERE idConcierto='" & c.Id & "';")
    End Function

    Public Function Borrar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Conciertos WHERE idConcierto='" & c.Id & "';")
    End Function

    'DAVID
    Public Sub leerConciertosPorIdYPais(id As String, p As String)
        Dim c As Concierto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT DISTINCT c.idConcierto, c.FechaConcierto FROM Conciertos c JOIN Artistas ar ON c.Artista = ar.idArtista JOIN Sitio s ON c.Sitio = s.idSitio JOIN Paises p ON s.País = p.idPais WHERE ar.idArtista = " & id & " AND p.idPais = '" & p & "'")
        For Each aux In col
            c = New Concierto
            c.Id = aux(1)
            Me.conciertosFiltrados.Add(c)
        Next
    End Sub
    Public Sub leerConciertosPorIdSitio(id As Integer)
        Dim c As Concierto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Conciertos WHERE Sitio = " & id)
        For Each aux In col
            c = New Concierto
            c.Id = aux(1)
            c.Artista.Id = aux(2)
            c.Sitio.Id = aux(3)
            c.Fecha = Convert.ToDateTime(aux(4))
            Me.SitioConcierto.Add(c)
        Next
    End Sub
    Public Sub leerArtista(ByRef con As Concierto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Artistas WHERE IdConcierto=" & con.Id & ";")
        For Each aux In col
            con.Artista = aux(2)
            con.Sitio = aux(3)
            con.Fecha = Convert.ToDateTime(aux(4))
        Next
    End Sub
End Class
