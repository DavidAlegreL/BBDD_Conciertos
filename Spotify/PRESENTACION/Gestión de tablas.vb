Public Class GestorTablas
    Private a As Artista
    Private alb As Album
    Private c As Cancion
    Private p As Pais
    Private s As Sitio

    Private Sub GestorTablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pAux As Pais
        Me.p = New Pais
        Dim aAux As Artista
        Me.a = New Artista
        Dim albAux As Album
        Me.alb = New Album
        Dim cAux As Cancion
        Me.c = New Cancion
        Dim sAux As Sitio
        Me.s = New Sitio

        Me.PaisListBox.Items.Clear()
        Me.GestionarPaisComboBox.Items.Clear()
        Me.ArtistasListBox.Items.Clear()
        Me.ArtistaAlbumComboBox.Items.Clear()
        Me.AlbumesListBox.Items.Clear()
        Me.AlbumCancionComboBox.Items.Clear()
        Me.CancionesListBox.Items.Clear()
        Me.PaisSitioComboBox.Items.Clear()
        Me.SitioListBox.Items.Clear()
        Me.ArtAlbumListbox.Items.Clear()
        Me.AlbumCancionComboBox.Items.Clear()
        Me.NAlbumesListbox.Items.Clear()

        Me.ModificarArtistaButton.Enabled = False
        Me.LimpiarArtistaButton.Enabled = True
        Me.EliminarArtistaButton.Enabled = False
        Me.LimpiarPaisButton.Enabled = True
        Me.EliminarPaisButton.Enabled = False
        Me.ModificarAlbumButton.Enabled = False
        Me.LimpiarAlbumButton.Enabled = True
        Me.EliminarAlbumButton.Enabled = False
        Me.ModificarCancionesButton.Enabled = False
        Me.LimpiarCancionesButton.Enabled = True
        Me.EliminarCancionesButton.Enabled = False
        Me.ModificarSitioButton.Enabled = False
        Me.LimpiarSitiosButton.Enabled = True
        Me.EliminarSitioButton.Enabled = False

        Try
            Me.p.LeerTodosPaises()
            Me.a.LeerTodosArtistas()
            Me.alb.LeerTodosAlbumes()
            Me.c.LeerTodasCanciones()
            Me.s.LeerTodosSitios()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In p.PaisDAO.Pais
            Me.PaisListBox.Items.Add(pAux.Nombre)
            Me.GestionarPaisComboBox.Items.Add(pAux.IdPais)
            Me.PaisSitioComboBox.Items.Add(pAux.IdPais)
        Next
        For Each aAux In a.ArtisDAO.Artista
            Me.ArtistasListBox.Items.Add(aAux.Nombre)
            Me.ArtistaAlbumComboBox.Items.Add(aAux.Id)
            Me.ArtAlbumListbox.Items.Add(aAux.Id & " = " & aAux.Nombre)
        Next
        For Each albAux In alb.AlbDAO.Albumes
            Me.AlbumesListBox.Items.Add(albAux.Titulo)
            Me.AlbumCancionComboBox.Items.Add(albAux.Id)
            Me.NAlbumesListbox.Items.Add(albAux.Id & " = " & albAux.Titulo)
        Next
        For Each cAux In c.CancDAO.Canciones
            Me.CancionesListBox.Items.Add(cAux.Titulo)
        Next
        For Each sAux In s.SitiDAO.Sitio
            Me.SitioListBox.Items.Add(sAux.Nombre)
        Next
    End Sub

    '----------------------------------------------ARTISTA----------------------------------------------
    Private Sub ArtistasListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArtistasListBox.SelectedIndexChanged
        If Not Me.ArtistasListBox.SelectedItem Is Nothing Then
            Me.AnadirArtistaButton.Enabled = False
            Me.ModificarArtistaButton.Enabled = True
            Me.LimpiarArtistaButton.Enabled = True
            Me.EliminarArtistaButton.Enabled = True
            Me.a.Nombre = ArtistasListBox.SelectedItem.ToString
            Try
                Me.a.LeerArtista()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.NombreArtistaTextBox.Text = a.Nombre
            Me.IdArtistaTextBox.Text = a.Id
            Me.GestionarPaisComboBox.SelectedItem = a.PaisA.IdPais

        Else
            Me.LimpiarPaisButton.PerformClick()
        End If

    End Sub
    Private Sub AnadirArtistaButton_Click(sender As Object, e As EventArgs) Handles AnadirArtistaButton.Click
        If IdArtistaTextBox.Text <> String.Empty And NombreArtistaTextBox.Text <> String.Empty And GestionarPaisComboBox.SelectedItem <> String.Empty Then
            a = New Artista
            a.Id = IdArtistaTextBox.Text
            a.Nombre = NombreArtistaTextBox.Text
            a.PaisA.IdPais = GestionarPaisComboBox.SelectedItem
            Try
                If a.InsertarArtista <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            GestorTablas_Load(sender, e)
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub ModificarArtistaButton_Click(sender As Object, e As EventArgs) Handles ModificarArtistaButton.Click
        If Me.ArtistasListBox.SelectedItem <> String.Empty Then
            If IdArtistaTextBox.Text <> String.Empty And NombreArtistaTextBox.Text <> String.Empty And GestionarPaisComboBox.SelectedItem <> String.Empty Then
                a = New Artista
                a.Id = IdArtistaTextBox.Text
                a.Nombre = NombreArtistaTextBox.Text
                a.PaisA.IdPais = GestionarPaisComboBox.SelectedItem
                Try
                    If a.ActualizarArtista() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", "Error al modificar", MessageBoxButtons.OK)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                    Exit Sub
                End Try
                MessageBox.Show(a.Nombre & " actualizado correctamente")
                GestorTablas_Load(sender, e)
            Else
                MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al modificar", MessageBoxButtons.OK)
            End If
        Else
            MsgBox("Debe seleccionar un Artista de la lista para modificar", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub EliminarArtistaButton_Click(sender As Object, e As EventArgs) Handles EliminarArtistaButton.Click
        If IdArtistaTextBox.Text <> String.Empty And NombreArtistaTextBox.Text <> String.Empty And GestionarPaisComboBox.SelectedItem <> String.Empty Then
            a.Id = IdArtistaTextBox.Text
            a.Nombre = NombreArtistaTextBox.Text
            a.PaisA.IdPais = GestionarPaisComboBox.SelectedItem
            Try
                If a.BorrarArtista <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS
            Me.ArtistasListBox.Items.Remove(a.Nombre)
            Me.ArtistaAlbumComboBox.Items.Remove(a.Id)
            GestorTablas_Load(sender, e)
            Me.AnadirArtistaButton.Enabled = True
            IdArtistaTextBox.Text = String.Empty
            NombreArtistaTextBox.Text = String.Empty
            GestionarPaisComboBox.Text = String.Empty
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al eleminar", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub LimpiarArtistaButton_Click(sender As Object, e As EventArgs) Handles LimpiarArtistaButton.Click
        Me.AnadirArtistaButton.Enabled = True
        Me.LimpiarArtistaButton.Enabled = True
        Me.ModificarArtistaButton.Enabled = False
        Me.EliminarArtistaButton.Enabled = False
        IdArtistaTextBox.Text = String.Empty
        NombreArtistaTextBox.Text = String.Empty
        GestionarPaisComboBox.SelectedItem = -1
    End Sub

    '----------------------------------------------PAIS----------------------------------------------
    Private Sub PaisListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaisListBox.SelectedIndexChanged
        If Not Me.PaisListBox.SelectedItem Is Nothing Then
            Me.AnadirPaisButton.Enabled = False
            Me.LimpiarPaisButton.Enabled = True
            Me.EliminarPaisButton.Enabled = True
            Me.p.Nombre = PaisListBox.SelectedItem.ToString
            Try
                Me.p.LeerPais()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.NombrePaisTextBox.Text = p.Nombre
            Me.IdPaisTextBox.Text = p.IdPais
        Else
            Me.LimpiarPaisButton.PerformClick()
        End If

    End Sub
    Private Sub AnadirPaisButton_Click_1(sender As Object, e As EventArgs) Handles AnadirPaisButton.Click
        If IdPaisTextBox.Text <> String.Empty And NombrePaisTextBox.Text <> String.Empty Then
            p.IdPais = IdPaisTextBox.Text.Substring(0, 3).ToUpper
            p.Nombre = NombrePaisTextBox.Text
            Try
                If p.InsertarPais <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS
            GestorTablas_Load(sender, e)

        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub LimpiarPaisButton_Click(sender As Object, e As EventArgs) Handles LimpiarPaisButton.Click
        Me.AnadirPaisButton.Enabled = True
        Me.LimpiarPaisButton.Enabled = True
        Me.EliminarPaisButton.Enabled = False
        IdPaisTextBox.Text = String.Empty
        NombrePaisTextBox.Text = String.Empty
    End Sub
    Private Sub EliminarPaisButton_Click(sender As Object, e As EventArgs) Handles EliminarPaisButton.Click
        If IdPaisTextBox.Text <> String.Empty And NombrePaisTextBox.Text <> String.Empty Then
            p.IdPais = IdPaisTextBox.Text.Substring(0, 3).ToUpper
            p.Nombre = NombrePaisTextBox.Text
            Try
                If p.BorrarPais <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS
            Me.PaisListBox.Items.Remove(p.Nombre)
            Me.GestionarPaisComboBox.Items.Remove(p.IdPais)
            Me.PaisSitioComboBox.Items.Remove(p.IdPais)
            GestorTablas_Load(sender, e)
            IdPaisTextBox.Text = String.Empty
            NombrePaisTextBox.Text = String.Empty
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al elminar", MessageBoxButtons.OK)
        End If
    End Sub

    '----------------------------------------------ALBUMES----------------------------------------------
    Private Sub AlbumesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlbumesListBox.SelectedIndexChanged
        If Not Me.AlbumesListBox.SelectedItem Is Nothing Then
            Me.AnadirAlbumButton.Enabled = False
            Me.ModificarAlbumButton.Enabled = True
            Me.LimpiarAlbumButton.Enabled = True
            Me.EliminarAlbumButton.Enabled = True
            Me.alb.Titulo = AlbumesListBox.SelectedItem.ToString
            Try
                Me.alb.LeerAlbum()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.TituloAlbumTextBox.Text = alb.Titulo
            Me.IdAlbumTextBox.Text = alb.Id
            Me.AnoAlbumTextBox.Text = alb.Año
            Me.ArtistaAlbumComboBox.SelectedItem = alb.ArtistaDelAlbum.Id
        Else
            Me.LimpiarAlbumButton.PerformClick()
        End If

    End Sub
    Private Sub AnadirAlbumButton_Click(sender As Object, e As EventArgs) Handles AnadirAlbumButton.Click
        If IdAlbumTextBox.Text <> String.Empty And TituloAlbumTextBox.Text <> String.Empty And AnoAlbumTextBox.Text <> String.Empty And ArtistaAlbumComboBox.Text <> String.Empty Then
            alb = New Album
            alb.Id = IdAlbumTextBox.Text
            alb.Titulo = TituloAlbumTextBox.Text
            alb.Año = AnoAlbumTextBox.Text
            alb.ArtistaDelAlbum.Id = ArtistaAlbumComboBox.SelectedItem
            Try
                If alb.InsertarAlbum <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS
            GestorTablas_Load(sender, e)
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub LimpiarAlbumButton_Click(sender As Object, e As EventArgs) Handles LimpiarAlbumButton.Click
        Me.AnadirAlbumButton.Enabled = True
        Me.ModificarAlbumButton.Enabled = False
        Me.LimpiarAlbumButton.Enabled = True
        Me.EliminarAlbumButton.Enabled = False
        IdAlbumTextBox.Text = String.Empty
        TituloAlbumTextBox.Text = String.Empty
        AnoAlbumTextBox.Text = String.Empty
        ArtistaAlbumComboBox.SelectedItem = -1
    End Sub
    Private Sub ModificarAlbumButton_Click(sender As Object, e As EventArgs) Handles ModificarAlbumButton.Click
        If Me.AlbumesListBox.SelectedItem <> String.Empty Then
            If IdAlbumTextBox.Text <> String.Empty And TituloAlbumTextBox.Text <> String.Empty And AnoAlbumTextBox.Text <> String.Empty And ArtistaAlbumComboBox.Text <> String.Empty Then
                alb = New Album
                alb.Id = IdAlbumTextBox.Text
                alb.Titulo = TituloAlbumTextBox.Text
                alb.Año = AnoAlbumTextBox.Text
                alb.ArtistaDelAlbum.Id = ArtistaAlbumComboBox.SelectedItem
                Try
                    If alb.ActualizarAlbum() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", "Error al modificar", MessageBoxButtons.OK)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                    Exit Sub
                End Try
                MessageBox.Show(alb.Titulo & " actualizado correctamente")
                GestorTablas_Load(sender, e)
            Else
                MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al modificar", MessageBoxButtons.OK)
            End If
        Else
            MsgBox("Debe seleccionar una jugadora de la lista para modificar", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub EliminarAlbumButton_Click(sender As Object, e As EventArgs) Handles EliminarAlbumButton.Click
        If IdAlbumTextBox.Text <> String.Empty And TituloAlbumTextBox.Text <> String.Empty And AnoAlbumTextBox.Text <> String.Empty And ArtistaAlbumComboBox.Text <> String.Empty Then
            alb.Id = IdAlbumTextBox.Text
            alb.Titulo = TituloAlbumTextBox.Text
            alb.Año = AnoAlbumTextBox.Text
            alb.ArtistaDelAlbum.Id = ArtistaAlbumComboBox.SelectedItem
            Try
                If alb.BorrarAlbum <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS
            Me.AlbumesListBox.Items.Remove(alb.Titulo)
            GestorTablas_Load(sender, e)
            Me.AnadirAlbumButton.Enabled = True
            IdAlbumTextBox.Text = String.Empty
            TituloAlbumTextBox.Text = String.Empty
            AnoAlbumTextBox.Text = String.Empty
            ArtistaAlbumComboBox.Text = String.Empty
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub

    '----------------------------------------------CANCIONES----------------------------------------------
    Private Sub CancionesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CancionesListBox.SelectedIndexChanged
        If Not Me.CancionesListBox.SelectedItem Is Nothing Then
            Me.AnadirCancionesButton.Enabled = False
            Me.ModificarCancionesButton.Enabled = True
            Me.LimpiarCancionesButton.Enabled = True
            Me.EliminarCancionesButton.Enabled = True
            Me.c.Titulo = CancionesListBox.SelectedItem.ToString
            Try
                Me.c.LeerCancion()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.TituloCancionTextBox.Text = c.Titulo
            Me.IdCancionTextBox.Text = c.Id
            Me.DuracionCancionTextBox.Text = c.Duracion
            Me.AlbumCancionComboBox.SelectedItem = c.cancioAlbum.Id
            Me.OrdenCancionTextBox.Text = c.ordenCancion
        Else
            Me.LimpiarAlbumButton.PerformClick()
        End If
    End Sub
    Private Sub AnadirCancionesButton_Click(sender As Object, e As EventArgs) Handles AnadirCancionesButton.Click
        If IdCancionTextBox.Text <> String.Empty And TituloCancionTextBox.Text <> String.Empty And DuracionCancionTextBox.Text <> String.Empty And AlbumCancionComboBox.Text <> String.Empty And OrdenCancionTextBox.Text <> String.Empty Then
            c = New Cancion
            c.Id = IdCancionTextBox.Text
            c.Titulo = TituloCancionTextBox.Text
            c.Duracion = DuracionCancionTextBox.Text
            c.cancioAlbum.Id = AlbumCancionComboBox.SelectedItem
            c.ordenCancion = OrdenCancionTextBox.Text
            Try
                If c.InsertarCancion <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS
            Me.CancionesListBox.Items.Add(c.Titulo)
            GestorTablas_Load(sender, e)
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub ModificarCancionesButton_Click(sender As Object, e As EventArgs) Handles ModificarCancionesButton.Click
        If Me.CancionesListBox.SelectedItem <> String.Empty Then
            If IdCancionTextBox.Text <> String.Empty And TituloCancionTextBox.Text <> String.Empty And DuracionCancionTextBox.Text <> String.Empty And AlbumCancionComboBox.Text <> String.Empty And OrdenCancionTextBox.Text <> String.Empty Then
                c = New Cancion
                c.Id = IdCancionTextBox.Text
                c.Titulo = TituloCancionTextBox.Text
                c.Duracion = DuracionCancionTextBox.Text
                c.cancioAlbum.Id = AlbumCancionComboBox.SelectedItem
                c.ordenCancion = OrdenCancionTextBox.Text
                Try
                    If c.ActualizarCancion() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", "Error al modificar", MessageBoxButtons.OK)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                    Exit Sub
                End Try
                MessageBox.Show(c.Titulo & " actualizado correctamente")
                GestorTablas_Load(sender, e)
            Else
                MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al modificar", MessageBoxButtons.OK)
            End If
        Else
            MsgBox("Debe seleccionar una jugadora de la lista para modificar", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub LimpiarCancionesButton_Click(sender As Object, e As EventArgs) Handles LimpiarCancionesButton.Click
        Me.AnadirCancionesButton.Enabled = True
        Me.ModificarCancionesButton.Enabled = False
        Me.LimpiarCancionesButton.Enabled = True
        Me.EliminarCancionesButton.Enabled = False
        IdCancionTextBox.Text = String.Empty
        TituloCancionTextBox.Text = String.Empty
        DuracionCancionTextBox.Text = String.Empty
        AlbumCancionComboBox.SelectedItem = -1
        OrdenCancionTextBox.Text = String.Empty
    End Sub
    Private Sub EliminarCancionesButton_Click(sender As Object, e As EventArgs) Handles EliminarCancionesButton.Click
        If IdCancionTextBox.Text <> String.Empty And TituloCancionTextBox.Text <> String.Empty And DuracionCancionTextBox.Text <> String.Empty And AlbumCancionComboBox.Text <> String.Empty And OrdenCancionTextBox.Text <> String.Empty Then
            c.Id = IdCancionTextBox.Text
            c.Titulo = TituloCancionTextBox.Text
            c.Duracion = DuracionCancionTextBox.Text
            c.cancioAlbum.Id = AlbumCancionComboBox.SelectedItem
            c.ordenCancion = OrdenCancionTextBox.Text
            Try
                If c.BorrarCancion <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS
            Me.CancionesListBox.Items.Remove(c.Titulo)
            GestorTablas_Load(sender, e)
            Me.AnadirCancionesButton.Enabled = True
            IdCancionTextBox.Text = String.Empty
            TituloCancionTextBox.Text = String.Empty
            DuracionCancionTextBox.Text = String.Empty
            AlbumCancionComboBox.Text = String.Empty
            OrdenCancionTextBox.Text = String.Empty
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub

    '----------------------------------------------SITIOS----------------------------------------------
    Private Sub SitioListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SitioListBox.SelectedIndexChanged
        If Not Me.SitioListBox.SelectedItem Is Nothing Then
            Me.AnadirSitioButton.Enabled = False
            Me.ModificarSitioButton.Enabled = True
            Me.LimpiarSitiosButton.Enabled = True
            Me.EliminarSitioButton.Enabled = True
            Me.s.Nombre = SitioListBox.SelectedItem.ToString
            Try
                Me.s.LeerSitio()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.NombreSitioTextBox.Text = s.Nombre
            Me.IdSitioTextBox.Text = s.Id
            Me.PaisSitioComboBox.SelectedItem = s.PaisS.IdPais
            Me.TipoSitioTextBox.Text = s.Tipo
        Else
            Me.LimpiarSitiosButton.PerformClick()
        End If
    End Sub
    Private Sub AnadirSitioButton_Click(sender As Object, e As EventArgs) Handles AnadirSitioButton.Click
        If IdSitioTextBox.Text <> String.Empty And NombreSitioTextBox.Text <> String.Empty And PaisSitioComboBox.Text <> String.Empty And TipoSitioTextBox.Text <> String.Empty Then
            s = New Sitio
            s.Id = IdSitioTextBox.Text
            s.Nombre = NombreSitioTextBox.Text
            s.PaisS.IdPais = PaisSitioComboBox.SelectedItem
            s.Tipo = TipoSitioTextBox.Text
            Try
                If s.InsertarSitio <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS
            Me.SitioListBox.Items.Add(s.Nombre)
            GestorTablas_Load(sender, e)
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub ModificarSitioButton_Click(sender As Object, e As EventArgs) Handles ModificarSitioButton.Click
        If Me.SitioListBox.SelectedItem <> String.Empty Then
            If IdSitioTextBox.Text <> String.Empty And NombreSitioTextBox.Text <> String.Empty And PaisSitioComboBox.Text <> String.Empty And TipoSitioTextBox.Text <> String.Empty Then
                s = New Sitio
                s.Id = IdSitioTextBox.Text
                s.Nombre = NombreSitioTextBox.Text
                s.PaisS.IdPais = PaisSitioComboBox.SelectedItem
                s.Tipo = TipoSitioTextBox.Text
                Try
                    If s.ActualizarSitio() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", "Error al modificar", MessageBoxButtons.OK)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                    Exit Sub
                End Try
                MessageBox.Show(s.Nombre & " actualizado correctamente")
                GestorTablas_Load(sender, e)
            Else
                MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al modificar", MessageBoxButtons.OK)
            End If
        Else
            MsgBox("Debe seleccionar una jugadora de la lista para modificar", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub LimpiarSitiosButton_Click(sender As Object, e As EventArgs) Handles LimpiarSitiosButton.Click
        Me.AnadirSitioButton.Enabled = True
        Me.ModificarSitioButton.Enabled = False
        Me.LimpiarSitiosButton.Enabled = True
        Me.EliminarSitioButton.Enabled = False
        IdSitioTextBox.Text = String.Empty
        NombreSitioTextBox.Text = String.Empty
        PaisSitioComboBox.SelectedItem = -1
        TipoSitioTextBox.Text = String.Empty
    End Sub
    Private Sub EliminarSitioButton_Click(sender As Object, e As EventArgs) Handles EliminarSitioButton.Click
        If IdSitioTextBox.Text <> String.Empty And NombreSitioTextBox.Text <> String.Empty And PaisSitioComboBox.Text <> String.Empty And TipoSitioTextBox.Text <> String.Empty Then
            s.Id = IdSitioTextBox.Text
            s.Nombre = NombreSitioTextBox.Text
            s.PaisS.IdPais = PaisSitioComboBox.SelectedItem
            s.Tipo = TipoSitioTextBox.Text
            Try
                If s.BorrarSitio <> 1 Then
                    MessageBox.Show("INSERT return <> 1", "Error al añadir", MessageBoxButtons.OK)
                    Exit Sub

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
                Exit Sub
            End Try
            ''AÑADIR AQUI A DONDE QUIERO QUE VAYAN ESTOS DATOS SALA PABELLON ESTADIO FESTIVAL
            Me.SitioListBox.Items.Remove(s.Nombre)
            GestorTablas_Load(sender, e)
        Else
            MessageBox.Show("Por favor rellene correctamente todos los campos", "Error al añadir", MessageBoxButtons.OK)
        End If
    End Sub
End Class
