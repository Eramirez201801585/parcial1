<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRendimiento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpromedio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarRegresar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRendimiento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblpromedio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROMEDIO DE SEMESTRE"
        '
        'lblRendimiento
        '
        Me.lblRendimiento.AutoSize = True
        Me.lblRendimiento.Location = New System.Drawing.Point(99, 42)
        Me.lblRendimiento.Name = "lblRendimiento"
        Me.lblRendimiento.Size = New System.Drawing.Size(0, 15)
        Me.lblRendimiento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RENDIMIENTO"
        '
        'lblpromedio
        '
        Me.lblpromedio.AutoSize = True
        Me.lblpromedio.Location = New System.Drawing.Point(99, 23)
        Me.lblpromedio.Name = "lblpromedio"
        Me.lblpromedio.Size = New System.Drawing.Size(0, 15)
        Me.lblpromedio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROMEDIO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiarRegresar)
        Me.GroupBox2.Controls.Add(Me.btnRegresar)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 56)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCIONES"
        '
        'btnLimpiarRegresar
        '
        Me.btnLimpiarRegresar.Location = New System.Drawing.Point(89, 23)
        Me.btnLimpiarRegresar.Name = "btnLimpiarRegresar"
        Me.btnLimpiarRegresar.Size = New System.Drawing.Size(120, 23)
        Me.btnLimpiarRegresar.TabIndex = 1
        Me.btnLimpiarRegresar.Text = "Limpiar y Regresar"
        Me.btnLimpiarRegresar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(7, 23)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 0
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(255, 160)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "RESULTADOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblpromedio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRendimiento As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLimpiarRegresar As Button
    Friend WithEvents btnRegresar As Button
End Class
