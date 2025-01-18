Public Class Setlist
    Public Property Concierto As Concierto
    Public Property Cancion As Cancion
    Public Property OrdenSetlist As Integer

    Public ReadOnly Property SetlDAO As SetlistDAO

    Public Sub New()
        Me.SetlDAO = New SetlistDAO
        Me.Concierto = New Concierto
        Me.Cancion = New Cancion
    End Sub
    Public Sub New(OrdenSetlist As String)
        Me.SetlDAO = New SetlistDAO
        Me.OrdenSetlist = OrdenSetlist
        Me.Concierto = New Concierto
        Me.Cancion = New Cancion
    End Sub

    Public Sub LeerTodosConciertosSetlist()
        Me.SetlDAO.LeerTodasSetlist(Me, Concierto)
    End Sub

    Public Sub LeerConciertoSetlist()
        Me.SetlDAO.LeerSetlist(Me)
    End Sub

    Public Function InsertarConciertoSetlist() As Integer
        Return Me.SetlDAO.InsertarSetlist(Me)
    End Function

    Public Function ActualizarConciertoSetlist() As Integer
        Return Me.SetlDAO.ActualizarSetlist(Me)
    End Function

    Public Function BorrarConciertoSetlist() As Integer
        Return Me.SetlDAO.BorrarSetlist(Me)
    End Function
End Class
