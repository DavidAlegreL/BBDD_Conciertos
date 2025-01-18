Public Class Principaal
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Crear una instancia de la interfaz de destino
        Dim interfazDestino As New CrearConcierto() ' Reemplaza "Form2" con el nombre de la interfaz de destino

        ' Mostrar la interfaz de destino
        interfazDestino.Visible() = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Crear una instancia de la interfaz de destino
        Dim interfazDestino As New GestorTablas() ' Reemplaza "Form2" con el nombre de la interfaz de destino

        ' Mostrar la interfaz de destino
        interfazDestino.Visible() = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Crear una instancia de la interfaz de destino
        Dim interfazDestino As New Navegacion() ' Reemplaza "Form2" con el nombre de la interfaz de destino

        ' Mostrar la interfaz de destino
        interfazDestino.Visible() = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Crear una instancia de la interfaz de destino
        Dim interfazDestino As New ConsultasForm() ' Reemplaza "Form2" con el nombre de la interfaz de destino

        ' Mostrar la interfaz de destino
        interfazDestino.Visible() = True
    End Sub

End Class