<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarGastos
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
        Me.grillaGasto = New System.Windows.Forms.DataGridView()
        Me.cmdAgregarGasto = New System.Windows.Forms.Button()
        Me.cmdBuscarGasto = New System.Windows.Forms.Button()
        Me.cmdAtrasGastos = New System.Windows.Forms.Button()
        Me.calendarioDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calendarioHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.grillaGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grillaGasto
        '
        Me.grillaGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaGasto.Location = New System.Drawing.Point(48, 183)
        Me.grillaGasto.Name = "grillaGasto"
        Me.grillaGasto.Size = New System.Drawing.Size(707, 284)
        Me.grillaGasto.TabIndex = 1
        '
        'cmdAgregarGasto
        '
        Me.cmdAgregarGasto.Location = New System.Drawing.Point(78, 49)
        Me.cmdAgregarGasto.Name = "cmdAgregarGasto"
        Me.cmdAgregarGasto.Size = New System.Drawing.Size(97, 36)
        Me.cmdAgregarGasto.TabIndex = 2
        Me.cmdAgregarGasto.Text = "Agregar Gasto"
        Me.cmdAgregarGasto.UseVisualStyleBackColor = True
        '
        'cmdBuscarGasto
        '
        Me.cmdBuscarGasto.Location = New System.Drawing.Point(386, 130)
        Me.cmdBuscarGasto.Name = "cmdBuscarGasto"
        Me.cmdBuscarGasto.Size = New System.Drawing.Size(97, 36)
        Me.cmdBuscarGasto.TabIndex = 3
        Me.cmdBuscarGasto.Text = "Buscar Gasto"
        Me.cmdBuscarGasto.UseVisualStyleBackColor = True
        '
        'cmdAtrasGastos
        '
        Me.cmdAtrasGastos.Location = New System.Drawing.Point(680, 491)
        Me.cmdAtrasGastos.Name = "cmdAtrasGastos"
        Me.cmdAtrasGastos.Size = New System.Drawing.Size(75, 23)
        Me.cmdAtrasGastos.TabIndex = 4
        Me.cmdAtrasGastos.Text = "Atras"
        Me.cmdAtrasGastos.UseVisualStyleBackColor = True
        '
        'calendarioDesde
        '
        Me.calendarioDesde.Location = New System.Drawing.Point(386, 49)
        Me.calendarioDesde.Name = "calendarioDesde"
        Me.calendarioDesde.Size = New System.Drawing.Size(200, 20)
        Me.calendarioDesde.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Desde"
        '
        'calendarioHasta
        '
        Me.calendarioHasta.Location = New System.Drawing.Point(386, 91)
        Me.calendarioHasta.Name = "calendarioHasta"
        Me.calendarioHasta.Size = New System.Drawing.Size(200, 20)
        Me.calendarioHasta.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hasta"
        '
        'BuscarGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 526)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.calendarioHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calendarioDesde)
        Me.Controls.Add(Me.cmdAtrasGastos)
        Me.Controls.Add(Me.cmdBuscarGasto)
        Me.Controls.Add(Me.cmdAgregarGasto)
        Me.Controls.Add(Me.grillaGasto)
        Me.Name = "BuscarGastos"
        Me.Text = "BuscarGastos"
        CType(Me.grillaGasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grillaGasto As DataGridView
    Friend WithEvents cmdAgregarGasto As Button
    Friend WithEvents cmdBuscarGasto As Button
    Friend WithEvents cmdAtrasGastos As Button
    Friend WithEvents calendarioDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents calendarioHasta As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
