<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearConcierto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ConciertoTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.OrdenSetlistNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CancionesListBox = New System.Windows.Forms.ListBox()
        Me.SetlistListBox = New System.Windows.Forms.ListBox()
        Me.EliminarCancionSetlistButton = New System.Windows.Forms.Button()
        Me.AnadirCancionSetlistButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateConciertoTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdConciertoTextBox = New System.Windows.Forms.TextBox()
        Me.SitioConciertoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ArtistaConciertoComboBox = New System.Windows.Forms.ComboBox()
        Me.ConciertosListView = New System.Windows.Forms.ListView()
        Me.IdColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ArtistaColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SitioColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EliminarConciertoButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LimpiarConciertoButton = New System.Windows.Forms.Button()
        Me.CrearConciertoBoton = New System.Windows.Forms.Button()
        Me.ModificarConciertoButton = New System.Windows.Forms.Button()
        Me.IDNOMBREListBox = New System.Windows.Forms.ListBox()
        Me.NombreCListBox = New System.Windows.Forms.ListBox()
        Me.NombresListBox = New System.Windows.Forms.ListBox()
        Me.NombresSListBox = New System.Windows.Forms.ListBox()
        Me.ConciertoTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.OrdenSetlistNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConciertoTabControl
        '
        Me.ConciertoTabControl.Controls.Add(Me.TabPage1)
        Me.ConciertoTabControl.Location = New System.Drawing.Point(2, 1)
        Me.ConciertoTabControl.Name = "ConciertoTabControl"
        Me.ConciertoTabControl.RightToLeftLayout = True
        Me.ConciertoTabControl.SelectedIndex = 0
        Me.ConciertoTabControl.Size = New System.Drawing.Size(706, 374)
        Me.ConciertoTabControl.TabIndex = 26
        Me.ConciertoTabControl.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NombresSListBox)
        Me.TabPage1.Controls.Add(Me.NombresListBox)
        Me.TabPage1.Controls.Add(Me.NombreCListBox)
        Me.TabPage1.Controls.Add(Me.IDNOMBREListBox)
        Me.TabPage1.Controls.Add(Me.OrdenSetlistNumericUpDown)
        Me.TabPage1.Controls.Add(Me.CancionesListBox)
        Me.TabPage1.Controls.Add(Me.SetlistListBox)
        Me.TabPage1.Controls.Add(Me.EliminarCancionSetlistButton)
        Me.TabPage1.Controls.Add(Me.AnadirCancionSetlistButton)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.DateConciertoTimePicker)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.IdConciertoTextBox)
        Me.TabPage1.Controls.Add(Me.SitioConciertoComboBox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ArtistaConciertoComboBox)
        Me.TabPage1.Controls.Add(Me.ConciertosListView)
        Me.TabPage1.Controls.Add(Me.EliminarConciertoButton)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.LimpiarConciertoButton)
        Me.TabPage1.Controls.Add(Me.CrearConciertoBoton)
        Me.TabPage1.Controls.Add(Me.ModificarConciertoButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(698, 348)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Concierto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'OrdenSetlistNumericUpDown
        '
        Me.OrdenSetlistNumericUpDown.Location = New System.Drawing.Point(477, 231)
        Me.OrdenSetlistNumericUpDown.Name = "OrdenSetlistNumericUpDown"
        Me.OrdenSetlistNumericUpDown.Size = New System.Drawing.Size(45, 20)
        Me.OrdenSetlistNumericUpDown.TabIndex = 37
        '
        'CancionesListBox
        '
        Me.CancionesListBox.FormattingEnabled = True
        Me.CancionesListBox.Location = New System.Drawing.Point(276, 223)
        Me.CancionesListBox.Name = "CancionesListBox"
        Me.CancionesListBox.Size = New System.Drawing.Size(171, 108)
        Me.CancionesListBox.TabIndex = 36
        '
        'SetlistListBox
        '
        Me.SetlistListBox.FormattingEnabled = True
        Me.SetlistListBox.Location = New System.Drawing.Point(6, 192)
        Me.SetlistListBox.Name = "SetlistListBox"
        Me.SetlistListBox.Size = New System.Drawing.Size(246, 69)
        Me.SetlistListBox.TabIndex = 35
        '
        'EliminarCancionSetlistButton
        '
        Me.EliminarCancionSetlistButton.Location = New System.Drawing.Point(452, 296)
        Me.EliminarCancionSetlistButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EliminarCancionSetlistButton.Name = "EliminarCancionSetlistButton"
        Me.EliminarCancionSetlistButton.Size = New System.Drawing.Size(92, 36)
        Me.EliminarCancionSetlistButton.TabIndex = 34
        Me.EliminarCancionSetlistButton.Text = "ELIMINAR CANCION"
        Me.EliminarCancionSetlistButton.UseVisualStyleBackColor = True
        '
        'AnadirCancionSetlistButton
        '
        Me.AnadirCancionSetlistButton.Location = New System.Drawing.Point(452, 256)
        Me.AnadirCancionSetlistButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AnadirCancionSetlistButton.Name = "AnadirCancionSetlistButton"
        Me.AnadirCancionSetlistButton.Size = New System.Drawing.Size(92, 36)
        Me.AnadirCancionSetlistButton.TabIndex = 33
        Me.AnadirCancionSetlistButton.Text = "AÑADIR CANCION"
        Me.AnadirCancionSetlistButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "CANCIONES DEL ARTISTA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(467, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 26)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "ORDEN DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LA CANCION "
        '
        'DateConciertoTimePicker
        '
        Me.DateConciertoTimePicker.Location = New System.Drawing.Point(404, 20)
        Me.DateConciertoTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.DateConciertoTimePicker.Name = "DateConciertoTimePicker"
        Me.DateConciertoTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.DateConciertoTimePicker.TabIndex = 2
        Me.DateConciertoTimePicker.Value = New Date(2023, 4, 30, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ELEGIR FECHA DEL CONCIERTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ELEGIR SITIO DEL CONCIERTO"
        '
        'IdConciertoTextBox
        '
        Me.IdConciertoTextBox.Location = New System.Drawing.Point(257, 20)
        Me.IdConciertoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IdConciertoTextBox.Name = "IdConciertoTextBox"
        Me.IdConciertoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.IdConciertoTextBox.TabIndex = 23
        '
        'SitioConciertoComboBox
        '
        Me.SitioConciertoComboBox.FormattingEnabled = True
        Me.SitioConciertoComboBox.Location = New System.Drawing.Point(257, 59)
        Me.SitioConciertoComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SitioConciertoComboBox.Name = "SitioConciertoComboBox"
        Me.SitioConciertoComboBox.Size = New System.Drawing.Size(140, 21)
        Me.SitioConciertoComboBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ID DEL CONCIERTO"
        '
        'ArtistaConciertoComboBox
        '
        Me.ArtistaConciertoComboBox.FormattingEnabled = True
        Me.ArtistaConciertoComboBox.Location = New System.Drawing.Point(401, 59)
        Me.ArtistaConciertoComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ArtistaConciertoComboBox.Name = "ArtistaConciertoComboBox"
        Me.ArtistaConciertoComboBox.Size = New System.Drawing.Size(140, 21)
        Me.ArtistaConciertoComboBox.TabIndex = 4
        '
        'ConciertosListView
        '
        Me.ConciertosListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdColumnHeader, Me.ArtistaColumnHeader, Me.SitioColumnHeader, Me.FechaColumnHeader})
        Me.ConciertosListView.HideSelection = False
        Me.ConciertosListView.Location = New System.Drawing.Point(6, 8)
        Me.ConciertosListView.Name = "ConciertosListView"
        Me.ConciertosListView.Size = New System.Drawing.Size(246, 103)
        Me.ConciertosListView.TabIndex = 25
        Me.ConciertosListView.UseCompatibleStateImageBehavior = False
        Me.ConciertosListView.View = System.Windows.Forms.View.Details
        '
        'IdColumnHeader
        '
        Me.IdColumnHeader.Text = "IdConcierto"
        '
        'ArtistaColumnHeader
        '
        Me.ArtistaColumnHeader.Text = "Artista"
        '
        'SitioColumnHeader
        '
        Me.SitioColumnHeader.Text = "Sitio"
        '
        'FechaColumnHeader
        '
        Me.FechaColumnHeader.Text = "Fecha"
        '
        'EliminarConciertoButton
        '
        Me.EliminarConciertoButton.Location = New System.Drawing.Point(565, 161)
        Me.EliminarConciertoButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EliminarConciertoButton.Name = "EliminarConciertoButton"
        Me.EliminarConciertoButton.Size = New System.Drawing.Size(128, 67)
        Me.EliminarConciertoButton.TabIndex = 19
        Me.EliminarConciertoButton.Text = "ELIMINAR CONCIERO"
        Me.EliminarConciertoButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(420, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ELEGIR ARTISTA"
        '
        'LimpiarConciertoButton
        '
        Me.LimpiarConciertoButton.Location = New System.Drawing.Point(564, 268)
        Me.LimpiarConciertoButton.Name = "LimpiarConciertoButton"
        Me.LimpiarConciertoButton.Size = New System.Drawing.Size(128, 63)
        Me.LimpiarConciertoButton.TabIndex = 22
        Me.LimpiarConciertoButton.Text = "Limpiar"
        Me.LimpiarConciertoButton.UseVisualStyleBackColor = True
        '
        'CrearConciertoBoton
        '
        Me.CrearConciertoBoton.Location = New System.Drawing.Point(565, 8)
        Me.CrearConciertoBoton.Margin = New System.Windows.Forms.Padding(2)
        Me.CrearConciertoBoton.Name = "CrearConciertoBoton"
        Me.CrearConciertoBoton.Size = New System.Drawing.Size(128, 72)
        Me.CrearConciertoBoton.TabIndex = 7
        Me.CrearConciertoBoton.Text = "CREAR CONCIERTO"
        Me.CrearConciertoBoton.UseVisualStyleBackColor = True
        '
        'ModificarConciertoButton
        '
        Me.ModificarConciertoButton.Location = New System.Drawing.Point(565, 88)
        Me.ModificarConciertoButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ModificarConciertoButton.Name = "ModificarConciertoButton"
        Me.ModificarConciertoButton.Size = New System.Drawing.Size(128, 69)
        Me.ModificarConciertoButton.TabIndex = 18
        Me.ModificarConciertoButton.Text = "MODIFICAR CONCIERTO"
        Me.ModificarConciertoButton.UseVisualStyleBackColor = True
        '
        'IDNOMBREListBox
        '
        Me.IDNOMBREListBox.FormattingEnabled = True
        Me.IDNOMBREListBox.Location = New System.Drawing.Point(6, 113)
        Me.IDNOMBREListBox.Name = "IDNOMBREListBox"
        Me.IDNOMBREListBox.Size = New System.Drawing.Size(246, 69)
        Me.IDNOMBREListBox.TabIndex = 54
        '
        'NombreCListBox
        '
        Me.NombreCListBox.FormattingEnabled = True
        Me.NombreCListBox.Location = New System.Drawing.Point(3, 273)
        Me.NombreCListBox.Name = "NombreCListBox"
        Me.NombreCListBox.Size = New System.Drawing.Size(246, 69)
        Me.NombreCListBox.TabIndex = 55
        '
        'NombresListBox
        '
        Me.NombresListBox.FormattingEnabled = True
        Me.NombresListBox.Location = New System.Drawing.Point(403, 88)
        Me.NombresListBox.Name = "NombresListBox"
        Me.NombresListBox.Size = New System.Drawing.Size(138, 95)
        Me.NombresListBox.TabIndex = 58
        '
        'NombresSListBox
        '
        Me.NombresSListBox.FormattingEnabled = True
        Me.NombresSListBox.Location = New System.Drawing.Point(258, 88)
        Me.NombresSListBox.Name = "NombresSListBox"
        Me.NombresSListBox.Size = New System.Drawing.Size(140, 95)
        Me.NombresSListBox.TabIndex = 59
        '
        'CrearConcierto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 366)
        Me.Controls.Add(Me.ConciertoTabControl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CrearConcierto"
        Me.Text = "Form2"
        Me.ConciertoTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.OrdenSetlistNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConciertoTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents OrdenSetlistNumericUpDown As NumericUpDown
    Friend WithEvents CancionesListBox As ListBox
    Friend WithEvents SetlistListBox As ListBox
    Friend WithEvents EliminarCancionSetlistButton As Button
    Friend WithEvents AnadirCancionSetlistButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateConciertoTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IdConciertoTextBox As TextBox
    Friend WithEvents SitioConciertoComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ArtistaConciertoComboBox As ComboBox
    Friend WithEvents ConciertosListView As ListView
    Friend WithEvents IdColumnHeader As ColumnHeader
    Friend WithEvents ArtistaColumnHeader As ColumnHeader
    Friend WithEvents SitioColumnHeader As ColumnHeader
    Friend WithEvents FechaColumnHeader As ColumnHeader
    Friend WithEvents EliminarConciertoButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LimpiarConciertoButton As Button
    Friend WithEvents CrearConciertoBoton As Button
    Friend WithEvents ModificarConciertoButton As Button
    Friend WithEvents IDNOMBREListBox As ListBox
    Friend WithEvents NombreCListBox As ListBox
    Friend WithEvents NombresListBox As ListBox
    Friend WithEvents NombresSListBox As ListBox
End Class
