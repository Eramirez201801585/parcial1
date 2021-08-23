Imports System.Math
Public Class Form1
    Private Sub chqCurso1_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso1.CheckedChanged
        If chqCurso1.Checked Then
            chqCurso1.Text = "EQV"
            txtCurso1.Enabled = False
            txtCurso1.Clear()
            EQV1 = 1
        Else
            chqCurso1.Text = ""
            txtCurso1.Enabled = True
            txtCurso1.Focus()
            EQV1 = 0
        End If
    End Sub

    Private Sub chqCurso2_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso2.CheckedChanged
        If chqCurso2.Checked Then
            chqCurso2.Text = "EQV"
            txtCurso2.Enabled = False
            txtCurso2.Clear()
            EQV2 = 1
        Else
            chqCurso2.Text = ""
            txtCurso2.Enabled = True
            txtCurso2.Focus()
            EQV2 = 0
        End If
    End Sub

    Private Sub chqCurso3_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso3.CheckedChanged
        If chqCurso3.Checked Then
            chqCurso3.Text = "EQV"
            txtCurso3.Enabled = False
            txtCurso3.Clear()
            EQV3 = 1
        Else
            chqCurso3.Text = ""
            txtCurso3.Enabled = True
            txtCurso3.Focus()
            EQV3 = 0
        End If
    End Sub

    Private Sub chqCurso4_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso4.CheckedChanged
        If chqCurso4.Checked Then
            chqCurso4.Text = "EQV"
            txtCurso4.Enabled = False
            txtCurso4.Clear()
            EQV4 = 1
        Else
            chqCurso4.Text = ""
            txtCurso4.Enabled = True
            txtCurso4.Focus()
            EQV4 = 0
        End If
    End Sub

    Private Sub chqCurso5_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso5.CheckedChanged
        If chqCurso5.Checked Then
            chqCurso5.Text = "EQV"
            txtCurso5.Enabled = False
            txtCurso5.Clear()
            EQV5 = 1
        Else
            chqCurso5.Text = ""
            txtCurso5.Enabled = True
            txtCurso5.Focus()
            EQV5 = 0
        End If
    End Sub

    Private Sub chqCurso6_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso6.CheckedChanged
        If chqCurso6.Checked Then
            chqCurso6.Text = "EQV"
            txtCurso6.Enabled = False
            txtCurso6.Clear()
            EQV6 = 1
        Else
            chqCurso6.Text = ""
            txtCurso6.Enabled = True
            txtCurso6.Focus()
            EQV6 = 0
        End If
    End Sub

    Private Sub chqCurso7_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso7.CheckedChanged
        If chqCurso7.Checked Then
            chqCurso7.Text = "EQV"
            txtCurso7.Enabled = False
            txtCurso7.Clear()
            EQV7 = 1
        Else
            chqCurso7.Text = ""
            txtCurso7.Enabled = True
            txtCurso7.Focus()
            EQV7 = 0
        End If
    End Sub

    Private Sub chqCurso8_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso8.CheckedChanged
        If chqCurso8.Checked Then
            chqCurso8.Text = "EQV"
            txtCurso8.Enabled = False
            txtCurso8.Clear()
            EQV8 = 1
        Else
            chqCurso8.Text = ""
            txtCurso8.Enabled = True
            txtCurso8.Focus()
            EQV8 = 0
        End If
    End Sub

    Private Sub chqCurso9_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso9.CheckedChanged
        If chqCurso9.Checked Then
            chqCurso9.Text = "EQV"
            txtCurso9.Enabled = False
            txtCurso9.Clear()
            EQV9 = 1
        Else
            chqCurso9.Text = ""
            txtCurso9.Enabled = True
            txtCurso9.Focus()
            EQV9 = 0
        End If
    End Sub

    Private Sub chqCurso10_CheckedChanged(sender As Object, e As EventArgs) Handles chqCurso10.CheckedChanged
        If chqCurso10.Checked Then
            chqCurso10.Text = "EQV"
            txtCurso10.Enabled = False
            txtCurso10.Clear()
            EQV10 = 1
        Else
            chqCurso10.Text = ""
            txtCurso10.Enabled = True
            txtCurso10.Focus()
            EQV10 = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        N1 = Round(Val(txtCurso1.Text), 2)
        N2 = Round(Val(txtCurso2.Text), 2)
        N3 = Round(Val(txtCurso3.Text), 2)
        N4 = Round(Val(txtCurso4.Text), 2)
        N5 = Round(Val(txtCurso5.Text), 2)
        N6 = Round(Val(txtCurso6.Text), 2)
        N7 = Round(Val(txtCurso7.Text), 2)
        N8 = Round(Val(txtCurso8.Text), 2)
        N9 = Round(Val(txtCurso9.Text), 2)
        N10 = Round(Val(txtCurso10.Text), 2)
        TEQV = EQV1 + EQV2 + EQV3 + EQV4 + EQV5 + EQV6 + EQV7 + EQV8 + EQV9 + EQV10
        Promedio = Round(((N1 + N2 + N3 + N4 + N5 + N6 + N7 + N8 + N9 + N10) / (10 - TEQV)), 2)
        If Promedio >= 61 And Promedio < 71 Then
            Rendimiento = "Bajo"
        ElseIf Promedio >= 71 And Promedio < 81 Then
            Rendimiento = "Bueno"
        ElseIf Promedio >= 81 And Promedio < 90 Then
            Rendimiento = "Muy bueno"
        ElseIf Promedio >= 90 And Promedio <= 100 Then
            Rendimiento = "Excelente"
            Me.Hide()
            Form3.Show()
            Exit Sub
        ElseIf Promedio < 61 Then
            Rendimiento = "Reprobado"
        Else
            MsgBox("Verifique los datos que ingreso",, "Error")
            Exit Sub
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "LIMPIEZA DE DATOS") = vbYes Then
            Limpiar()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIR DEL PROGRAMA") = vbYes Then
            'Cierre del programa
            Me.Close()
        End If
    End Sub
End Class
