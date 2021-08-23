<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblpromedio = New System.Windows.Forms.Label()
        Me.lblRendimiento = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarRegresar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Promedio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rendimiento:"
        '
        'lblpromedio
        '
        Me.lblpromedio.AutoSize = True
        Me.lblpromedio.Location = New System.Drawing.Point(326, 40)
        Me.lblpromedio.Name = "lblpromedio"
        Me.lblpromedio.Size = New System.Drawing.Size(41, 15)
        Me.lblpromedio.TabIndex = 3
        Me.lblpromedio.Text = "Label4"
        '
        'lblRendimiento
        '
        Me.lblRendimiento.AutoSize = True
        Me.lblRendimiento.Location = New System.Drawing.Point(326, 69)
        Me.lblRendimiento.Name = "lblRendimiento"
        Me.lblRendimiento.Size = New System.Drawing.Size(41, 15)
        Me.lblRendimiento.TabIndex = 4
        Me.lblRendimiento.Text = "Label5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblRendimiento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblpromedio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FELICIDADES SU RENDIMIENTO A SIDO EXCELENTE "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiarRegresar)
        Me.GroupBox2.Controls.Add(Me.btnRegresar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 100)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnLimpiarRegresar
        '
        Me.btnLimpiarRegresar.Location = New System.Drawing.Point(317, 46)
        Me.btnLimpiarRegresar.Name = "btnLimpiarRegresar"
        Me.btnLimpiarRegresar.Size = New System.Drawing.Size(163, 23)
        Me.btnLimpiarRegresar.TabIndex = 1
        Me.btnLimpiarRegresar.Text = "LIMPIAR Y REGRESAR"
        Me.btnLimpiarRegresar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(139, 47)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 0
        Me.btnRegresar.Text = "REGRESAR"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(631, 232)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "FELICIDADES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblpromedio As Label
    Friend WithEvents lblRendimiento As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLimpiarRegresar As Button
    Friend WithEvents btnRegresar As Button
End Class
