Public Class ConsultasForm
    Private a As Artista
    Private alb As Album
    Private c As Cancion
    Private p As Pais
    Private s As Sitio
    Private con As Concierto
    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aAux As Artista
        Me.a = New Artista
        Try

            Me.a.LeerTodosArtistas()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each aAux In a.ArtisDAO.Artista
            Me.ComboBoxArtista.Items.Add(aAux.Id)
            Me.ArtistaComboBox.Items.Add(aAux.Id)
        Next


    End Sub

    Private Sub ComboBoxArtista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxArtista.SelectedIndexChanged
        Dim aAux As Artista
        Me.CancionesListBox.Items.Clear()
        Try
            aAux = New Artista(ComboBoxArtista.SelectedItem)
            ' se asigna la lista de canciones obtenida a la propiedad "canciones" del objeto "aAux"
            aAux.ObtenerCanciones()
            ' Recorrido de la colección de canciones obtenida y agregado de cada título de canción a la ListBox
            For Each canciones In aAux.canciones
                Me.CancionesListBox.Items.Add(canciones.Titulo)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub ArtistaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArtistaComboBox.SelectedIndexChanged
        Dim aAux As Artista
        Me.AlbumesListBox.Items.Clear()
        Try
            aAux = New Artista(ArtistaComboBox.SelectedItem)
            ' se asigna la lista de canciones obtenida a la propiedad "canciones" del objeto "aAux"
            aAux.ObtenerAlbumes()
            ' Recorrido de la colección de canciones obtenida y agregado de cada título de canción a la ListBox
            For Each albumes In aAux.albumes
                Me.AlbumesListBox.Items.Add(albumes.Titulo)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub Buscado_Click(sender As Object, e As EventArgs) Handles Buscado.Click
        Dim cAux As Cancion
        Me.c = New Cancion
        Me.ConciertosListView.Items.Clear()
        Try
            Me.c.LeerTodasCanciones()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim Item As ListViewItem
        For Each cAux In c.CancDAO.Canciones
            Item = New ListViewItem(cAux.Id)
            Item.SubItems.Add(cAux.Titulo)
            Item.SubItems.Add(cAux.Duracion)
            Item.SubItems.Add(cAux.cancioAlbum.Titulo)
            Item.SubItems.Add(cAux.ordenCancion)

            Me.ConciertosListView.Items.Add(Item)
        Next
    End Sub

    Private Sub Recargar_Click(sender As Object, e As EventArgs) Handles Recargar.Click
        Dim aAux As Artista
        Me.a = New Artista
        Me.AlbumesCompletos.Items.Clear()
        Try

            Me.a.LeerTodosArtistas()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each aAux In a.ArtisDAO.Artista
            Me.AlbumesCompletos.Items.Add(aAux.Nombre)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aAux As Artista
        Me.a = New Artista
        Me.TopArtistas.Items.Clear()
        Try

            a.LeerTopTusArtistas(FechaInicialDateTimePicker.Value.Date, FechaFinalDateTimePicker.Value.Date)
            'For Each aAux In a.ArtisDAO.TopTusArtistas
            'aAux.LeerId()
            'Me.TopArtistas.Items.Add(aAux.Id)
            'Next
            If a.ArtisDAO.TopTusArtistas.Count = 0 Then
                MessageBox.Show("No se encontraron artistas en el rango de fechas indicado.")
            Else
                For Each aAux In a.ArtisDAO.TopTusArtistas
                    Me.TopArtistas.Items.Add(aAux.Id)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
            Exit Sub
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pAux As Pais
        Me.p = New Pais
        Dim aAux As Artista
        Me.a = New Artista
        Me.TopPaises.Items.Clear()
        Try

            a.LeerTopTusAlbumes(DateTimePicker2.Value.Date, DateTimePicker1.Value.Date)
            'For Each aAux In a.ArtisDAO.TopTusArtistas
            'aAux.LeerId()
            'Me.TopArtistas.Items.Add(aAux.Id)
            'Next
            If a.ArtisDAO.TopTusPaises.Count = 0 Then
                MessageBox.Show("No se encontraron artistas en el rango de fechas indicado.")
            Else
                For Each pAux In a.ArtisDAO.TopTusPaises
                    Me.TopPaises.Items.Add(pAux.IdPais)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
            Exit Sub
        End Try
    End Sub

    Private Sub TopPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TopPaises.SelectedIndexChanged

    End Sub
End Class