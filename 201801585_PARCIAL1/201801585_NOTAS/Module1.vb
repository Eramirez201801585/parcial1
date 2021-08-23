Module Module1
    Public Promedio As Double
    Public N1, N2, N3, N4, N5, N6, N7, N8, N9, N10 As Double
    Public EQV1, EQV2, EQV3, EQV4, EQV5, EQV6, EQV7, EQV8, EQV9, EQV10 As Integer
    Public TEQV As Integer
    Public Rendimiento As String

    Public Sub Limpiar()
        Form1.chqCurso1.Checked = False
        Form1.chqCurso2.Checked = False
        Form1.chqCurso3.Checked = False
        Form1.chqCurso4.Checked = False
        Form1.chqCurso5.Checked = False
        Form1.chqCurso6.Checked = False
        Form1.chqCurso7.Checked = False
        Form1.chqCurso8.Checked = False
        Form1.chqCurso9.Checked = False
        Form1.chqCurso10.Checked = False
        Form1.txtCurso1.Clear()
        Form1.txtCurso2.Clear()
        Form1.txtCurso3.Clear()
        Form1.txtCurso4.Clear()
        Form1.txtCurso5.Clear()
        Form1.txtCurso6.Clear()
        Form1.txtCurso7.Clear()
        Form1.txtCurso8.Clear()
        Form1.txtCurso9.Clear()
        Form1.txtCurso10.Clear()
        Form2.lblpromedio.Text = ""
        Form2.lblRendimiento.Text = ""
        Form3.lblpromedio.Text = ""
        Form3.lblRendimiento.Text = ""

    End Sub



End Module
