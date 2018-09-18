<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgragarGastos
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
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Gasto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdGuardarGasto = New System.Windows.Forms.Button()
        Me.cmdAtrasGasto = New System.Windows.Forms.Button()
        Me.calendarioGasto = New System.Windows.Forms.DateTimePicker()
        Me.txtGasto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(164, 149)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(173, 20)
        Me.txtMonto.TabIndex = 1
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(164, 189)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(175, 43)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.Text = ""
        '
        'Gasto
        '
        Me.Gasto.AutoSize = True
        Me.Gasto.Location = New System.Drawing.Point(50, 112)
        Me.Gasto.Name = "Gasto"
        Me.Gasto.Size = New System.Drawing.Size(35, 13)
        Me.Gasto.TabIndex = 5
        Me.Gasto.Text = "Gasto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Monto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Observaciones"
        '
        'cmdGuardarGasto
        '
        Me.cmdGuardarGasto.Location = New System.Drawing.Point(43, 280)
        Me.cmdGuardarGasto.Name = "cmdGuardarGasto"
        Me.cmdGuardarGasto.Size = New System.Drawing.Size(94, 30)
        Me.cmdGuardarGasto.TabIndex = 9
        Me.cmdGuardarGasto.Text = "Guardar Gasto"
        Me.cmdGuardarGasto.UseVisualStyleBackColor = True
        '
        'cmdAtrasGasto
        '
        Me.cmdAtrasGasto.Location = New System.Drawing.Point(304, 280)
        Me.cmdAtrasGasto.Name = "cmdAtrasGasto"
        Me.cmdAtrasGasto.Size = New System.Drawing.Size(94, 30)
        Me.cmdAtrasGasto.TabIndex = 10
        Me.cmdAtrasGasto.Text = "Atras"
        Me.cmdAtrasGasto.UseVisualStyleBackColor = True
        '
        'calendarioGasto
        '
        Me.calendarioGasto.Location = New System.Drawing.Point(164, 64)
        Me.calendarioGasto.Name = "calendarioGasto"
        Me.calendarioGasto.Size = New System.Drawing.Size(200, 20)
        Me.calendarioGasto.TabIndex = 11
        '
        'txtGasto
        '
        Me.txtGasto.Location = New System.Drawing.Point(164, 109)
        Me.txtGasto.Name = "txtGasto"
        Me.txtGasto.Size = New System.Drawing.Size(173, 20)
        Me.txtGasto.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha"
        '
        'AgragarGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 398)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGasto)
        Me.Controls.Add(Me.calendarioGasto)
        Me.Controls.Add(Me.cmdAtrasGasto)
        Me.Controls.Add(Me.cmdGuardarGasto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Gasto)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtMonto)
        Me.Name = "AgragarGastos"
        Me.Text = "AgragarGastos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtObservaciones As RichTextBox
    Friend WithEvents Gasto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdGuardarGasto As Button
    Friend WithEvents cmdAtrasGasto As Button
    Friend WithEvents calendarioGasto As DateTimePicker
    Friend WithEvents txtGasto As TextBox
    Friend WithEvents Label1 As Label
End Class
