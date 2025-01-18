Public Class Navegacion
    Private a As Artista
    Private c As Concierto
    Private ca As Cancion
    Private s As Sitio
    Private p As Pais
    Private Sub Navegacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cAux As Concierto
        Me.c = New Concierto
        Dim aAux As Artista
        Me.a = New Artista
        Dim pAux As Pais
        Me.p = New Pais
        Dim sAux As Sitio
        Me.s = New Sitio

        Me.ArtistaComboBox.Items.Clear()
        Me.PaisComboBox.Items.Clear()
        Me.SitiosListBox.Items.Clear()
        Me.SitioComboBox.Items.Clear()
        Me.ConciertosListbox.Items.Clear()
        Me.NombresSListBox.Items.Clear()
        Me.NombresListBox.Items.Clear()
        Me.IDNOMBREListBox.Items.Clear()

        Me.SitioBoton.Enabled = True
        Me.ArtistaBoton.Enabled = True

        Try
            Me.c.LeerTodosConciertos()
            Me.a.LeerTodosArtistas()
            Me.p.LeerTodosPaises()
            Me.s.LeerTodosSitios()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each cAux In c.ConciDAO.conciertosFiltrados
            Me.ConciertosListbox.Items.Add(cAux.Id)

        Next
        For Each aAux In a.ArtisDAO.Artista
            Me.ArtistaComboBox.Items.Add(aAux.Id)
            Me.NombresListBox.Items.Add(aAux.Id & " = " & aAux.Nombre)
        Next
        For Each pAux In p.PaisDAO.Pais
            Me.PaisComboBox.Items.Add(pAux.IdPais)
        Next
        For Each cAux In c.ConciDAO.SitioConcierto
            Me.ConciertosListbox.Items.Add(cAux.Id)
        Next
        For Each sAux In s.SitiDAO.Sitio
            Me.SitioComboBox.Items.Add(sAux.Id)
            Me.NombresSListBox.Items.Add(sAux.Id & " = " & sAux.Nombre)
        Next
        For Each cAux In c.ConciDAO.Conciertos
            Me.IDNOMBREListBox.Items.Add(cAux.Id & ", " & cAux.Artista.Nombre & ", " & cAux.Sitio.Nombre)
        Next

    End Sub

    Private Sub ArtistaBoton_Click(sender As Object, e As EventArgs) Handles ArtistaBoton.Click
        Dim cAux As Concierto
        Me.c = New Concierto
        Me.ConciertosListbox.Items.Clear()
        Try
            c.LeerporIdyPais(ArtistaComboBox.SelectedItem, PaisComboBox.SelectedItem)
            For Each cAux In c.ConciDAO.conciertosFiltrados
                cAux.LeerConciertoID()
                Me.ConciertosListbox.Items.Add(cAux.Id)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
            Exit Sub
        End Try
    End Sub

    Private Sub SitioBoton_Click(sender As Object, e As EventArgs) Handles SitioBoton.Click
        Dim cAux As Concierto
        Me.c = New Concierto
        Me.SitiosListBox.Items.Clear()
        Try
            c.LeerporIdSitio(SitioComboBox.SelectedItem)
            For Each cAux In c.ConciDAO.SitioConcierto
                cAux.LeerConciertoID()
                Me.SitiosListBox.Items.Add(cAux.Id)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
            Exit Sub
        End Try
    End Sub

    Private Sub IDNOMBREListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IDNOMBREListBox.SelectedIndexChanged

    End Sub
End Class