Public Class SetlistDAO
    Public ReadOnly Property Setlist As Collection
    Public Property CancionDA As CancionDAO
    Public Property ConciertoDA As ConciertoDAO
    Public Sub New()
        Me.Setlist = New Collection
        Me.CancionDA = New CancionDAO
        Me.ConciertoDA = New ConciertoDAO
    End Sub

    Public Sub LeerTodasSetlist(ByRef s As Setlist, ByRef c As Concierto)
        'Dim setlistConciertos As New List(Of Cancion)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT s.* FROM Setlists s JOIN Conciertos c On s.Concierto = c.idConcierto WHERE c.idConcierto='" & c.Id & "';")
        For Each aux In col
            s = New Setlist
            s.Concierto = New Concierto(aux(1))
            Me.ConciertoDA.LeerID(s.Concierto)
            s.Cancion = New Cancion(aux(2))
            Me.CancionDA.LeerID(s.Cancion)
            s.OrdenSetlist = aux(3)
            Me.Setlist.Add(s)
        Next
    End Sub

    Public Sub LeerSetlist(ByRef p As Setlist)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Setlists WHERE Concierto='" & p.Concierto.Id & "';")
        For Each aux In col
            p.Concierto = aux(1)
            p.Cancion = aux(2)
            p.OrdenSetlist = aux(3)
        Next
    End Sub

    Public Function InsertarSetlist(ByVal s As Setlist) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Setlists VALUES ('" & s.Concierto.Id & "', '" & s.Cancion.Id & "', '" & s.OrdenSetlist & "');")
    End Function

    Public Function ActualizarSetlist(ByVal s As Setlist) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Setlists SET Concierto='" & s.Concierto.Id & "' WHERE Cancion='" & s.Cancion.Id & "', OrdenSetlist'" & s.OrdenSetlist & "');")
    End Function

    Public Function BorrarSetlist(ByVal s As Setlist) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Setlists WHERE Canción='" & s.Cancion.Id & "';")
    End Function
End Class
