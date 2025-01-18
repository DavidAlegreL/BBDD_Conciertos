<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultasForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CancionesListBox = New System.Windows.Forms.ListBox()
        Me.Artista = New System.Windows.Forms.Label()
        Me.ComboBoxArtista = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AlbumesListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ArtistaComboBox = New System.Windows.Forms.ComboBox()
        Me.AlbumCompleto = New System.Windows.Forms.TabPage()
        Me.Recargar = New System.Windows.Forms.Button()
        Me.AlbumesCompletos = New System.Windows.Forms.ListBox()
        Me.MejoresCanciones = New System.Windows.Forms.TabPage()
        Me.ConciertosListView = New System.Windows.Forms.ListView()
        Me.IdColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DuracionColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AlbumColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OrdenCancionColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Buscado = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.FechaFinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicialDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TopArtistas = New System.Windows.Forms.ListBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TopPaises = New System.Windows.Forms.ListBox()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.AlbumCompleto.SuspendLayout()
        Me.MejoresCanciones.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.AlbumCompleto)
        Me.TabControl.Controls.Add(Me.MejoresCanciones)
        Me.TabControl.Controls.Add(Me.TabPage5)
        Me.TabControl.Controls.Add(Me.TabPage6)
        Me.TabControl.Location = New System.Drawing.Point(-3, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(805, 452)
        Me.TabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CancionesListBox)
        Me.TabPage1.Controls.Add(Me.Artista)
        Me.TabPage1.Controls.Add(Me.ComboBoxArtista)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(797, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TopCanciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CancionesListBox
        '
        Me.CancionesListBox.FormattingEnabled = True
        Me.CancionesListBox.Location = New System.Drawing.Point(62, 32)
        Me.CancionesListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CancionesListBox.Name = "CancionesListBox"
        Me.CancionesListBox.Size = New System.Drawing.Size(225, 277)
        Me.CancionesListBox.TabIndex = 6
        '
        'Artista
        '
        Me.Artista.AutoSize = True
        Me.Artista.Location = New System.Drawing.Point(381, 148)
        Me.Artista.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Artista.Name = "Artista"
        Me.Artista.Size = New System.Drawing.Size(41, 13)
        Me.Artista.TabIndex = 5
        Me.Artista.Text = "Artistas"
        '
        'ComboBoxArtista
        '
        Me.ComboBoxArtista.FormattingEnabled = True
        Me.ComboBoxArtista.Location = New System.Drawing.Point(328, 172)
        Me.ComboBoxArtista.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxArtista.Name = "ComboBoxArtista"
        Me.ComboBoxArtista.Size = New System.Drawing.Size(146, 21)
        Me.ComboBoxArtista.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AlbumesListBox)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.ArtistaComboBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(797, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TopAlbumes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AlbumesListBox
        '
        Me.AlbumesListBox.FormattingEnabled = True
        Me.AlbumesListBox.Location = New System.Drawing.Point(57, 29)
        Me.AlbumesListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AlbumesListBox.Name = "AlbumesListBox"
        Me.AlbumesListBox.Size = New System.Drawing.Size(229, 264)
        Me.AlbumesListBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Artistas"
        '
        'ArtistaComboBox
        '
        Me.ArtistaComboBox.FormattingEnabled = True
        Me.ArtistaComboBox.Location = New System.Drawing.Point(327, 153)
        Me.ArtistaComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ArtistaComboBox.Name = "ArtistaComboBox"
        Me.ArtistaComboBox.Size = New System.Drawing.Size(146, 21)
        Me.ArtistaComboBox.TabIndex = 7
        '
        'AlbumCompleto
        '
        Me.AlbumCompleto.Controls.Add(Me.Recargar)
        Me.AlbumCompleto.Controls.Add(Me.AlbumesCompletos)
        Me.AlbumCompleto.Location = New System.Drawing.Point(4, 22)
        Me.AlbumCompleto.Margin = New System.Windows.Forms.Padding(2)
        Me.AlbumCompleto.Name = "AlbumCompleto"
        Me.AlbumCompleto.Padding = New System.Windows.Forms.Padding(2)
        Me.AlbumCompleto.Size = New System.Drawing.Size(797, 426)
        Me.AlbumCompleto.TabIndex = 2
        Me.AlbumCompleto.Text = "AlbumCompleto"
        Me.AlbumCompleto.UseVisualStyleBackColor = True
        '
        'Recargar
        '
        Me.Recargar.Location = New System.Drawing.Point(342, 176)
        Me.Recargar.Margin = New System.Windows.Forms.Padding(2)
        Me.Recargar.Name = "Recargar"
        Me.Recargar.Size = New System.Drawing.Size(117, 64)
        Me.Recargar.TabIndex = 1
        Me.Recargar.Text = "Recargar"
        Me.Recargar.UseVisualStyleBackColor = True
        '
        'AlbumesCompletos
        '
        Me.AlbumesCompletos.FormattingEnabled = True
        Me.AlbumesCompletos.Location = New System.Drawing.Point(31, 29)
        Me.AlbumesCompletos.Margin = New System.Windows.Forms.Padding(2)
        Me.AlbumesCompletos.Name = "AlbumesCompletos"
        Me.AlbumesCompletos.Size = New System.Drawing.Size(262, 316)
        Me.AlbumesCompletos.TabIndex = 0
        '
        'MejoresCanciones
        '
        Me.MejoresCanciones.Controls.Add(Me.ConciertosListView)
        Me.MejoresCanciones.Controls.Add(Me.Buscado)
        Me.MejoresCanciones.Location = New System.Drawing.Point(4, 22)
        Me.MejoresCanciones.Margin = New System.Windows.Forms.Padding(2)
        Me.MejoresCanciones.Name = "MejoresCanciones"
        Me.MejoresCanciones.Padding = New System.Windows.Forms.Padding(2)
        Me.MejoresCanciones.Size = New System.Drawing.Size(797, 426)
        Me.MejoresCanciones.TabIndex = 3
        Me.MejoresCanciones.Text = "MejoresCanciones"
        Me.MejoresCanciones.UseVisualStyleBackColor = True
        '
        'ConciertosListView
        '
        Me.ConciertosListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdColumnHeader, Me.NombreColumnHeader, Me.DuracionColumnHeader, Me.AlbumColumnHeader, Me.OrdenCancionColumnHeader})
        Me.ConciertosListView.HideSelection = False
        Me.ConciertosListView.Location = New System.Drawing.Point(38, 40)
        Me.ConciertosListView.Name = "ConciertosListView"
        Me.ConciertosListView.Size = New System.Drawing.Size(471, 296)
        Me.ConciertosListView.TabIndex = 26
        Me.ConciertosListView.UseCompatibleStateImageBehavior = False
        Me.ConciertosListView.View = System.Windows.Forms.View.Details
        '
        'IdColumnHeader
        '
        Me.IdColumnHeader.Text = "Id Cancion"
        Me.IdColumnHeader.Width = 74
        '
        'NombreColumnHeader
        '
        Me.NombreColumnHeader.Text = "Nombre Cancion"
        Me.NombreColumnHeader.Width = 112
        '
        'DuracionColumnHeader
        '
        Me.DuracionColumnHeader.Text = "Duracion"
        '
        'AlbumColumnHeader
        '
        Me.AlbumColumnHeader.Text = "Album"
        Me.AlbumColumnHeader.Width = 69
        '
        'OrdenCancionColumnHeader
        '
        Me.OrdenCancionColumnHeader.Text = "OrdenCancion"
        Me.OrdenCancionColumnHeader.Width = 86
        '
        'Buscado
        '
        Me.Buscado.Location = New System.Drawing.Point(536, 178)
        Me.Buscado.Margin = New System.Windows.Forms.Padding(2)
        Me.Buscado.Name = "Buscado"
        Me.Buscado.Size = New System.Drawing.Size(113, 63)
        Me.Buscado.TabIndex = 1
        Me.Buscado.Text = "Buscar"
        Me.Buscado.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label42)
        Me.TabPage5.Controls.Add(Me.Label41)
        Me.TabPage5.Controls.Add(Me.FechaFinalDateTimePicker)
        Me.TabPage5.Controls.Add(Me.FechaInicialDateTimePicker)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.TopArtistas)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Size = New System.Drawing.Size(797, 426)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TopArtistas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(191, 311)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(59, 13)
        Me.Label42.TabIndex = 20
        Me.Label42.Text = "Fecha final"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(191, 281)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(66, 13)
        Me.Label41.TabIndex = 19
        Me.Label41.Text = "Fecha inicial"
        '
        'FechaFinalDateTimePicker
        '
        Me.FechaFinalDateTimePicker.Location = New System.Drawing.Point(264, 311)
        Me.FechaFinalDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker"
        Me.FechaFinalDateTimePicker.Size = New System.Drawing.Size(202, 20)
        Me.FechaFinalDateTimePicker.TabIndex = 18
        '
        'FechaInicialDateTimePicker
        '
        Me.FechaInicialDateTimePicker.Location = New System.Drawing.Point(264, 277)
        Me.FechaInicialDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.FechaInicialDateTimePicker.Name = "FechaInicialDateTimePicker"
        Me.FechaInicialDateTimePicker.Size = New System.Drawing.Size(202, 20)
        Me.FechaInicialDateTimePicker.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(523, 176)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 62)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TopArtistas
        '
        Me.TopArtistas.FormattingEnabled = True
        Me.TopArtistas.Location = New System.Drawing.Point(264, 13)
        Me.TopArtistas.Margin = New System.Windows.Forms.Padding(2)
        Me.TopArtistas.Name = "TopArtistas"
        Me.TopArtistas.Size = New System.Drawing.Size(202, 251)
        Me.TopArtistas.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label2)
        Me.TabPage6.Controls.Add(Me.Label3)
        Me.TabPage6.Controls.Add(Me.DateTimePicker1)
        Me.TabPage6.Controls.Add(Me.DateTimePicker2)
        Me.TabPage6.Controls.Add(Me.Button3)
        Me.TabPage6.Controls.Add(Me.TopPaises)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage6.Size = New System.Drawing.Size(797, 426)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TopPaises"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 341)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 311)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha inicial"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(249, 341)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(249, 307)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker2.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(508, 206)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 62)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TopPaises
        '
        Me.TopPaises.FormattingEnabled = True
        Me.TopPaises.Location = New System.Drawing.Point(249, 16)
        Me.TopPaises.Margin = New System.Windows.Forms.Padding(2)
        Me.TopPaises.Name = "TopPaises"
        Me.TopPaises.Size = New System.Drawing.Size(202, 264)
        Me.TopPaises.TabIndex = 4
        '
        'ConsultasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "ConsultasForm"
        Me.Text = "Form1"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.AlbumCompleto.ResumeLayout(False)
        Me.MejoresCanciones.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CancionesListBox As ListBox
    Friend WithEvents Artista As Label
    Friend WithEvents ComboBoxArtista As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AlbumesListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ArtistaComboBox As ComboBox
    Friend WithEvents AlbumCompleto As TabPage
    Friend WithEvents Recargar As Button
    Friend WithEvents AlbumesCompletos As ListBox
    Friend WithEvents MejoresCanciones As TabPage
    Friend WithEvents Buscado As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TopArtistas As ListBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TopPaises As ListBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents FechaFinalDateTimePicker As DateTimePicker
    Friend WithEvents FechaInicialDateTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents ConciertosListView As ListView
    Friend WithEvents IdColumnHeader As ColumnHeader
    Friend WithEvents NombreColumnHeader As ColumnHeader
    Friend WithEvents DuracionColumnHeader As ColumnHeader
    Friend WithEvents AlbumColumnHeader As ColumnHeader
    Friend WithEvents OrdenCancionColumnHeader As ColumnHeader
End Class
