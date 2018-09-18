<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCliente
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
        Me.grillaCliente = New System.Windows.Forms.DataGridView()
        Me.rbnNombre = New System.Windows.Forms.RadioButton()
        Me.rbnVendedor = New System.Windows.Forms.RadioButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmdBuscarCliente = New System.Windows.Forms.Button()
        Me.cmdMostrarClientes = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.rbnFecha = New System.Windows.Forms.RadioButton()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.rbnCategoria = New System.Windows.Forms.RadioButton()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.rbnEstado = New System.Windows.Forms.RadioButton()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmdConsultarCliente = New System.Windows.Forms.Button()
        CType(Me.grillaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grillaCliente
        '
        Me.grillaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaCliente.Location = New System.Drawing.Point(26, 180)
        Me.grillaCliente.Name = "grillaCliente"
        Me.grillaCliente.Size = New System.Drawing.Size(1052, 364)
        Me.grillaCliente.TabIndex = 0
        '
        'rbnNombre
        '
        Me.rbnNombre.AutoSize = True
        Me.rbnNombre.Location = New System.Drawing.Point(46, 36)
        Me.rbnNombre.Name = "rbnNombre"
        Me.rbnNombre.Size = New System.Drawing.Size(62, 17)
        Me.rbnNombre.TabIndex = 1
        Me.rbnNombre.TabStop = True
        Me.rbnNombre.Text = "Nombre"
        Me.rbnNombre.UseVisualStyleBackColor = True
        '
        'rbnVendedor
        '
        Me.rbnVendedor.AutoSize = True
        Me.rbnVendedor.Location = New System.Drawing.Point(46, 60)
        Me.rbnVendedor.Name = "rbnVendedor"
        Me.rbnVendedor.Size = New System.Drawing.Size(71, 17)
        Me.rbnVendedor.TabIndex = 2
        Me.rbnVendedor.TabStop = True
        Me.rbnVendedor.Text = "Vendedor"
        Me.rbnVendedor.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(118, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(202, 20)
        Me.txtNombre.TabIndex = 3
        '
        'cmdBuscarCliente
        '
        Me.cmdBuscarCliente.Location = New System.Drawing.Point(363, 29)
        Me.cmdBuscarCliente.Name = "cmdBuscarCliente"
        Me.cmdBuscarCliente.Size = New System.Drawing.Size(89, 32)
        Me.cmdBuscarCliente.TabIndex = 5
        Me.cmdBuscarCliente.Text = "Buscar"
        Me.cmdBuscarCliente.UseVisualStyleBackColor = True
        '
        'cmdMostrarClientes
        '
        Me.cmdMostrarClientes.Location = New System.Drawing.Point(709, 29)
        Me.cmdMostrarClientes.Name = "cmdMostrarClientes"
        Me.cmdMostrarClientes.Size = New System.Drawing.Size(89, 32)
        Me.cmdMostrarClientes.TabIndex = 6
        Me.cmdMostrarClientes.Text = "Mostrar todos"
        Me.cmdMostrarClientes.UseVisualStyleBackColor = True
        '
        'cmdAtras
        '
        Me.cmdAtras.Location = New System.Drawing.Point(723, 103)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 23)
        Me.cmdAtras.TabIndex = 7
        Me.cmdAtras.Text = "Atras"
        Me.cmdAtras.UseVisualStyleBackColor = True
        '
        'rbnFecha
        '
        Me.rbnFecha.AutoSize = True
        Me.rbnFecha.Location = New System.Drawing.Point(46, 85)
        Me.rbnFecha.Name = "rbnFecha"
        Me.rbnFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbnFecha.TabIndex = 8
        Me.rbnFecha.TabStop = True
        Me.rbnFecha.Text = "Fecha"
        Me.rbnFecha.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Enabled = False
        Me.fecha.Location = New System.Drawing.Point(118, 85)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(202, 20)
        Me.fecha.TabIndex = 9
        '
        'cmbVendedor
        '
        Me.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedor.Enabled = False
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(118, 60)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(202, 21)
        Me.cmbVendedor.TabIndex = 10
        '
        'rbnCategoria
        '
        Me.rbnCategoria.AutoSize = True
        Me.rbnCategoria.Location = New System.Drawing.Point(46, 109)
        Me.rbnCategoria.Name = "rbnCategoria"
        Me.rbnCategoria.Size = New System.Drawing.Size(70, 17)
        Me.rbnCategoria.TabIndex = 11
        Me.rbnCategoria.TabStop = True
        Me.rbnCategoria.Text = "Categoria"
        Me.rbnCategoria.UseVisualStyleBackColor = True
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.Enabled = False
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(118, 109)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(202, 21)
        Me.cmbCategoria.TabIndex = 12
        '
        'rbnEstado
        '
        Me.rbnEstado.AutoSize = True
        Me.rbnEstado.Location = New System.Drawing.Point(46, 134)
        Me.rbnEstado.Name = "rbnEstado"
        Me.rbnEstado.Size = New System.Drawing.Size(58, 17)
        Me.rbnEstado.TabIndex = 13
        Me.rbnEstado.TabStop = True
        Me.rbnEstado.Text = "Estado"
        Me.rbnEstado.UseVisualStyleBackColor = True
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(118, 134)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(202, 21)
        Me.cmbEstado.TabIndex = 14
        '
        'cmdConsultarCliente
        '
        Me.cmdConsultarCliente.Location = New System.Drawing.Point(691, 550)
        Me.cmdConsultarCliente.Name = "cmdConsultarCliente"
        Me.cmdConsultarCliente.Size = New System.Drawing.Size(75, 23)
        Me.cmdConsultarCliente.TabIndex = 15
        Me.cmdConsultarCliente.Text = "Consultar"
        Me.cmdConsultarCliente.UseVisualStyleBackColor = True
        '
        'BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 565)
        Me.Controls.Add(Me.cmdConsultarCliente)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.rbnEstado)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.rbnCategoria)
        Me.Controls.Add(Me.cmbVendedor)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.rbnFecha)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.cmdMostrarClientes)
        Me.Controls.Add(Me.cmdBuscarCliente)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.rbnVendedor)
        Me.Controls.Add(Me.rbnNombre)
        Me.Controls.Add(Me.grillaCliente)
        Me.Name = "BuscarCliente"
        Me.Text = "BuscarCliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grillaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grillaCliente As DataGridView
    Friend WithEvents rbnNombre As RadioButton
    Friend WithEvents rbnVendedor As RadioButton
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmdBuscarCliente As Button
    Friend WithEvents cmdMostrarClientes As Button
    Friend WithEvents cmdAtras As Button
    Friend WithEvents rbnFecha As RadioButton
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents cmbVendedor As ComboBox
    Friend WithEvents rbnCategoria As RadioButton
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents rbnEstado As RadioButton
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmdConsultarCliente As Button
End Class
