Public Class CrearConcierto
    Private a As Artista
    Private s As Sitio
    Private c As Concierto
    Private ca As Cancion
    Private se As Setlist
    Private Sub GestorConciertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cAux As Concierto
        Me.c = New Concierto
        Dim aAux As Artista
        Me.a = New Artista
        Dim sAux As Sitio
        Me.s = New Sitio
        Dim caAux As Cancion
        Me.ca = New Cancion

        Me.ArtistaConciertoComboBox.Items.Clear()
        Me.SitioConciertoComboBox.Items.Clear()
        Me.ConciertosListView.Items.Clear()
        Me.SetlistListBox.Items.Clear()
        Me.NombresListBox.Items.Clear()
        Me.NombresSListBox.Items.Clear()
        Me.IDNOMBREListBox.Items.Clear()
        Me.NombreCListBox.Items.Clear()



        Me.ModificarConciertoButton.Enabled = False
        Me.EliminarConciertoButton.Enabled = False

        Try
            Me.c.LeerTodosConciertos()
            Me.a.LeerTodosArtistas()
            Me.s.LeerTodosSitios()
            Me.ca.LeerTodasCanciones()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim Item As ListViewItem
        For Each cAux In c.ConciDAO.Conciertos
            Item = New ListViewItem(cAux.Id)
            Item.SubItems.Add(cAux.Artista.Id)
            Item.SubItems.Add(cAux.Sitio.Id)
            Item.SubItems.Add(cAux.Fecha.Date.ToString())

            Me.ConciertosListView.Items.Add(Item)
        Next
        For Each aAux In a.ArtisDAO.Artista
            Me.ArtistaConciertoComboBox.Items.Add(aAux.Id)
            Me.NombresListBox.Items.Add(aAux.Id & " = " & aAux.Nombre)
        Next
        For Each sAux In s.SitiDAO.Sitio
            Me.SitioConciertoComboBox.Items.Add(sAux.Id)
            Me.NombresSListBox.Items.Add(sAux.Id & " = " & sAux.Nombre)
        Next
        For Each cAux In c.ConciDAO.Conciertos
            Me.IDNOMBREListBox.Items.Add(cAux.Id & ", " & cAux.Artista.Nombre & ", " & cAux.Sitio.Nombre)
        Next
        For Each caAux In ca.CancDAO.Canciones
            Me.NombreCListBox.Items.Add(caAux.Id & " = " & caAux.Titulo)
        Next

    End Sub

    Private Sub ConciertosListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConciertosListView.SelectedIndexChanged
        If ConciertosListView.SelectedItems.Count > 0 Then
            ' Habilitar los botones de Modificar y Eliminar
            Me.ModificarConciertoButton.Enabled = True
            Me.EliminarConciertoButton.Enabled = True
            Dim Item As ListViewItem = ConciertosListView.SelectedItems(0)
            Me.c.Id = Item.SubItems(0).Text
            Try
                ' Leer la información del concierto seleccionado
                Me.c.LeerConcierto()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            ' Actualizar los campos en el formulario con la información del concierto
            Me.IdConciertoTextBox.Text = c.Id
            Me.ArtistaConciertoComboBox.SelectedItem = c.Artista.Id
            Me.SitioConciertoComboBox.SelectedItem = c.Sitio.Id
            Me.DateConciertoTimePicker.Value = c.Fecha
            actualizarSetlist()
        Else
            ' Si no hay ningún concierto seleccionado, limpiar los campos y deshabilitar los botones
            Me.LimpiarConciertoButton.PerformClick()
        End If


    End Sub
    Private Sub actualizarSetlist()
        If ConciertosListView.SelectedItems.Count > 0 Then
            Dim seAux As Setlist
            Me.se = New Setlist
            Me.SetlistListBox.Items.Clear()
            Dim Item As ListViewItem = ConciertosListView.SelectedItems(0)
            Me.se.Concierto.Id = Item.SubItems(0).Text
            Try
                'seAux = New Setlist(ConciertosListView.SelectedItems(0).SubItems(0).Text)
                'seAux.LeerTodosConciertosSetlist()
                Me.se.LeerTodosConciertosSetlist()
                ' Recorrido de la colección de canciones obtenida y agregado de cada título de canción a la ListBox
                For Each seAux In se.SetlDAO.Setlist
                    'leer por ir y sacar titulo
                    Me.SetlistListBox.Items.Add(seAux.Cancion.Id)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            ' Si no hay ningún concierto seleccionado, limpiar los campos y deshabilitar los botones
            Me.LimpiarConciertoButton.PerformClick()
        End If
    End Sub
    Private Sub CrearConciertoBoton_Click(sender As Object, e As EventArgs) Handles CrearConciertoBoton.Click
        If IdConciertoTextBox.Text <> String.Empty And ArtistaConciertoComboBox.Text <> String.Empty And SitioConciertoComboBox.Text <> String.Empty Then
            c = New Concierto
            c.Id = IdConciertoTextBox.Text
            c.Artista.Id = ArtistaConciertoComboBox.SelectedItem
            c.Sitio.Id = SitioConciertoComboBox.SelectedItem
            c.Fecha = DateConciertoTimePicker.Value
            Try
                If c.InsertarConcierto <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            GestorConciertos_Load(sender, e)
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub EliminarConciertoButton_Click(sender As Object, e As EventArgs) Handles EliminarConciertoButton.Click
        If IdConciertoTextBox.Text <> String.Empty Then

            c.Id = IdConciertoTextBox.Text
            Try
                If c.BorrarConcierto() Then
                    MessageBox.Show("Concierto eliminado correctamente", "Eliminar Concierto", MessageBoxButtons.OK)
                    IdConciertoTextBox.Text = String.Empty
                    ArtistaConciertoComboBox.SelectedIndex = -1
                    SitioConciertoComboBox.SelectedIndex = -1
                    DateConciertoTimePicker.Value = DateTime.Now
                    GestorConciertos_Load(sender, e)
                Else
                    MessageBox.Show("Error al eliminar el concierto", "Eliminar Concierto", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
            End Try
        Else
            MessageBox.Show("Por favor ingrese un Id de concierto válido", "Error al eliminar el concierto", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub ModificarConciertoButton_Click(sender As Object, e As EventArgs) Handles ModificarConciertoButton.Click
        If IdConciertoTextBox.Text <> String.Empty And ArtistaConciertoComboBox.Text <> String.Empty And SitioConciertoComboBox.Text <> String.Empty Then
            c = New Concierto
            c.Id = IdConciertoTextBox.Text
            c.Artista.Id = ArtistaConciertoComboBox.SelectedItem
            c.Sitio.Id = SitioConciertoComboBox.SelectedItem
            c.Fecha = DateConciertoTimePicker.Value
            Try
                If c.ActualizarConcierto() Then
                    MessageBox.Show("Concierto modificado correctamente", "Modificar Concierto", MessageBoxButtons.OK)
                    GestorConciertos_Load(sender, e)
                Else
                    MessageBox.Show("Error al modificar el concierto", "Modificar Concierto", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
            End Try
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al modificar el concierto", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub LimpiarConciertoButton_Click(sender As Object, e As EventArgs) Handles LimpiarConciertoButton.Click
        IdConciertoTextBox.Text = String.Empty
        ArtistaConciertoComboBox.SelectedIndex = -1
        SitioConciertoComboBox.SelectedIndex = -1
        DateConciertoTimePicker.Value = DateTime.Now
        SetlistListBox.Items.Clear()

    End Sub

    Private Sub ArtistaConciertoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArtistaConciertoComboBox.SelectedIndexChanged
        Dim aAux As Artista
        Me.CancionesListBox.Items.Clear()
        Try

            aAux = New Artista(ArtistaConciertoComboBox.SelectedItem)
            ' se asigna la lista de canciones obtenida a la propiedad "canciones" del objeto "aAux"
            aAux.ObtenerCanciones()
            ' Recorrido de la colección de canciones obtenida y agregado de cada título de canción a la ListBox
            For Each canciones In aAux.canciones
                Me.CancionesListBox.Items.Add(canciones.Id)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub



    Private Sub AnadirCancionSetlistButton_Click(sender As Object, e As EventArgs) Handles AnadirCancionSetlistButton.Click
        If IdConciertoTextBox.Text <> String.Empty And CancionesListBox.Text <> String.Empty And OrdenSetlistNumericUpDown.Text <> String.Empty Then
            se = New Setlist
            se.Concierto.Id = IdConciertoTextBox.Text
            se.Cancion.Id = CancionesListBox.SelectedItem
            se.OrdenSetlist = OrdenSetlistNumericUpDown.TextAlign

            Try
                If se.InsertarConciertoSetlist <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            GestorConciertos_Load(sender, e)
            actualizarSetlist()
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub EliminarCancionSetlistButton_Click(sender As Object, e As EventArgs) Handles EliminarCancionSetlistButton.Click
        If SetlistListBox.Text <> String.Empty Then

            se.Cancion.Id = SetlistListBox.SelectedItem

            Try
                If se.BorrarConciertoSetlist() Then
                    MessageBox.Show("Concierto eliminado correctamente", "Eliminar Concierto", MessageBoxButtons.OK)
                    actualizarSetlist()
                    GestorConciertos_Load(sender, e)
                Else
                    MessageBox.Show("Error al eliminar el concierto", "Eliminar Concierto", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
            End Try
        Else
            MessageBox.Show("Por favor ingrese un Id de concierto válido", "Error al eliminar el concierto", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub SetlistListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SetlistListBox.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub OrdenSetlistNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles OrdenSetlistNumericUpDown.ValueChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreCListBox.SelectedIndexChanged

    End Sub
End Class