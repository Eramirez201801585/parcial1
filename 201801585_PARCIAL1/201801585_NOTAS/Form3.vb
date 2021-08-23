Public Class Form3
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblpromedio.Text = Str(Promedio)
        lblRendimiento.Text = Rendimiento
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        If MsgBox("¿Desea regresar?", vbQuestion + vbYesNo, "Mensaje") = vbYes Then
            Me.Hide()
            Form1.Show()
        End If

    End Sub

    Private Sub btnLimpiarRegresar_Click(sender As Object, e As EventArgs) Handles btnLimpiarRegresar.Click
        If MsgBox("¿Desea regresar y limpiar los datos?", vbQuestion + vbYesNo, "Mensaje") = vbYes Then
            Me.Hide()
            Form1.Show()
            Limpiar()
        End If
    End Sub
End Class