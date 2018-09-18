<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarVendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rbnNombre = New System.Windows.Forms.RadioButton()
        Me.rbnDni = New System.Windows.Forms.RadioButton()
        Me.grillaVendedor = New System.Windows.Forms.DataGridView()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.txtMostrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAtras = New System.Windows.Forms.Button()
        CType(Me.grillaVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbnNombre
        '
        Me.rbnNombre.AutoSize = True
        Me.rbnNombre.Location = New System.Drawing.Point(59, 49)
        Me.rbnNombre.Name = "rbnNombre"
        Me.rbnNombre.Size = New System.Drawing.Size(114, 17)
        Me.rbnNombre.TabIndex = 0
        Me.rbnNombre.TabStop = True
        Me.rbnNombre.Text = "Buscar por nombre"
        Me.rbnNombre.UseVisualStyleBackColor = True
        '
        'rbnDni
        '
        Me.rbnDni.AutoSize = True
        Me.rbnDni.Location = New System.Drawing.Point(59, 85)
        Me.rbnDni.Name = "rbnDni"
        Me.rbnDni.Size = New System.Drawing.Size(98, 17)
        Me.rbnDni.TabIndex = 1
        Me.rbnDni.TabStop = True
        Me.rbnDni.Text = "Buscar por DNI"
        Me.rbnDni.UseVisualStyleBackColor = True
        '
        'grillaVendedor
        '
        Me.grillaVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaVendedor.Location = New System.Drawing.Point(59, 131)
        Me.grillaVendedor.Name = "grillaVendedor"
        Me.grillaVendedor.Size = New System.Drawing.Size(729, 263)
        Me.grillaVendedor.TabIndex = 2
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(456, 47)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(204, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtDNI
        '
        Me.txtDNI.Enabled = False
        Me.txtDNI.Location = New System.Drawing.Point(204, 82)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(182, 20)
        Me.txtDNI.TabIndex = 6
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(564, 445)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEliminar.TabIndex = 9
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'txtMostrar
        '
        Me.txtMostrar.Location = New System.Drawing.Point(591, 46)
        Me.txtMostrar.Name = "txtMostrar"
        Me.txtMostrar.Size = New System.Drawing.Size(88, 23)
        Me.txtMostrar.TabIndex = 10
        Me.txtMostrar.Text = "Mostrar Todos"
        Me.txtMostrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "* Haga doble click en el vendedor para modificar los datos"
        '
        'cmdAtras
        '
        Me.cmdAtras.Location = New System.Drawing.Point(713, 445)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 23)
        Me.cmdAtras.TabIndex = 13
        Me.cmdAtras.Text = "Atras"
        Me.cmdAtras.UseVisualStyleBackColor = True
        '
        'BuscarVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 526)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMostrar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.grillaVendedor)
        Me.Controls.Add(Me.rbnDni)
        Me.Controls.Add(Me.rbnNombre)
        Me.Name = "BuscarVendedor"
        Me.Text = "BuscarVendedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grillaVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbnNombre As RadioButton
    Friend WithEvents rbnDni As RadioButton
    Friend WithEvents grillaVendedor As DataGridView
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents txtMostrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdAtras As Button
End Class
