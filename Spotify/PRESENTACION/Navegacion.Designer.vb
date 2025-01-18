<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navegacion
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
        Me.ConciertosListbox = New System.Windows.Forms.ListBox()
        Me.SitiosListBox = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PaisComboBox = New System.Windows.Forms.ComboBox()
        Me.ArtistaComboBox = New System.Windows.Forms.ComboBox()
        Me.ArtistaBoton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SitioBoton = New System.Windows.Forms.Button()
        Me.SitioComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NombresListBox = New System.Windows.Forms.ListBox()
        Me.NombresSListBox = New System.Windows.Forms.ListBox()
        Me.IDNOMBREListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ConciertosListbox
        '
        Me.ConciertosListbox.FormattingEnabled = True
        Me.ConciertosListbox.Location = New System.Drawing.Point(77, 54)
        Me.ConciertosListbox.Margin = New System.Windows.Forms.Padding(2)
        Me.ConciertosListbox.Name = "ConciertosListbox"
        Me.ConciertosListbox.Size = New System.Drawing.Size(216, 82)
        Me.ConciertosListbox.TabIndex = 44
        '
        'SitiosListBox
        '
        Me.SitiosListBox.FormattingEnabled = True
        Me.SitiosListBox.Location = New System.Drawing.Point(77, 282)
        Me.SitiosListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SitiosListBox.Name = "SitiosListBox"
        Me.SitiosListBox.Size = New System.Drawing.Size(216, 82)
        Me.SitiosListBox.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(424, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "ARTISTA"
        '
        'PaisComboBox
        '
        Me.PaisComboBox.FormattingEnabled = True
        Me.PaisComboBox.Location = New System.Drawing.Point(384, 167)
        Me.PaisComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PaisComboBox.Name = "PaisComboBox"
        Me.PaisComboBox.Size = New System.Drawing.Size(128, 21)
        Me.PaisComboBox.TabIndex = 41
        '
        'ArtistaComboBox
        '
        Me.ArtistaComboBox.FormattingEnabled = True
        Me.ArtistaComboBox.Location = New System.Drawing.Point(384, 44)
        Me.ArtistaComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ArtistaComboBox.Name = "ArtistaComboBox"
        Me.ArtistaComboBox.Size = New System.Drawing.Size(128, 21)
        Me.ArtistaComboBox.TabIndex = 40
        '
        'ArtistaBoton
        '
        Me.ArtistaBoton.Location = New System.Drawing.Point(590, 79)
        Me.ArtistaBoton.Margin = New System.Windows.Forms.Padding(2)
        Me.ArtistaBoton.Name = "ArtistaBoton"
        Me.ArtistaBoton.Size = New System.Drawing.Size(149, 86)
        Me.ArtistaBoton.TabIndex = 39
        Me.ArtistaBoton.Text = "Navegación por Artista"
        Me.ArtistaBoton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(433, 152)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "PAÍS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 264)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Navegación por sitio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Navegación por artista"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(433, 248)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "SITIO"
        '
        'SitioBoton
        '
        Me.SitioBoton.Location = New System.Drawing.Point(590, 264)
        Me.SitioBoton.Margin = New System.Windows.Forms.Padding(2)
        Me.SitioBoton.Name = "SitioBoton"
        Me.SitioBoton.Size = New System.Drawing.Size(149, 76)
        Me.SitioBoton.TabIndex = 33
        Me.SitioBoton.Text = "Navegación por Sitio"
        Me.SitioBoton.UseVisualStyleBackColor = True
        '
        'SitioComboBox
        '
        Me.SitioComboBox.FormattingEnabled = True
        Me.SitioComboBox.Location = New System.Drawing.Point(384, 264)
        Me.SitioComboBox.Name = "SitioComboBox"
        Me.SitioComboBox.Size = New System.Drawing.Size(128, 21)
        Me.SitioComboBox.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "ID = NOMBRE CONCIERTTO"
        '
        'NombresListBox
        '
        Me.NombresListBox.FormattingEnabled = True
        Me.NombresListBox.Location = New System.Drawing.Point(370, 70)
        Me.NombresListBox.Name = "NombresListBox"
        Me.NombresListBox.Size = New System.Drawing.Size(156, 69)
        Me.NombresListBox.TabIndex = 51
        '
        'NombresSListBox
        '
        Me.NombresSListBox.FormattingEnabled = True
        Me.NombresSListBox.Location = New System.Drawing.Point(370, 295)
        Me.NombresSListBox.Name = "NombresSListBox"
        Me.NombresSListBox.Size = New System.Drawing.Size(156, 69)
        Me.NombresSListBox.TabIndex = 52
        '
        'IDNOMBREListBox
        '
        Me.IDNOMBREListBox.FormattingEnabled = True
        Me.IDNOMBREListBox.Location = New System.Drawing.Point(77, 168)
        Me.IDNOMBREListBox.Name = "IDNOMBREListBox"
        Me.IDNOMBREListBox.Size = New System.Drawing.Size(216, 82)
        Me.IDNOMBREListBox.TabIndex = 53
        '
        'Navegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IDNOMBREListBox)
        Me.Controls.Add(Me.NombresSListBox)
        Me.Controls.Add(Me.NombresListBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SitioComboBox)
        Me.Controls.Add(Me.ConciertosListbox)
        Me.Controls.Add(Me.SitiosListBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PaisComboBox)
        Me.Controls.Add(Me.ArtistaComboBox)
        Me.Controls.Add(Me.ArtistaBoton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SitioBoton)
        Me.Name = "Navegacion"
        Me.Text = "NavegacionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConciertosListbox As ListBox
    Friend WithEvents SitiosListBox As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PaisComboBox As ComboBox
    Friend WithEvents ArtistaComboBox As ComboBox
    Friend WithEvents ArtistaBoton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SitioBoton As Button
    Friend WithEvents SitioComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NombresListBox As ListBox
    Friend WithEvents NombresSListBox As ListBox
    Friend WithEvents IDNOMBREListBox As ListBox
End Class
