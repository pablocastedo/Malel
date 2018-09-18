<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHorarioEncargado = New System.Windows.Forms.TextBox()
        Me.txtTelefonoEncargado = New System.Windows.Forms.TextBox()
        Me.txtNombreEncargado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.cmbImportancia = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHorarioNegocio = New System.Windows.Forms.TextBox()
        Me.txtTelefonoNegocio = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombreNegocio = New System.Windows.Forms.TextBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefono Negocio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Direccion Negocio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Horario Negocio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtHorarioEncargado)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoEncargado)
        Me.GroupBox1.Controls.Add(Me.txtNombreEncargado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 382)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 139)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encargado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(133, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "+54"
        '
        'txtHorarioEncargado
        '
        Me.txtHorarioEncargado.Location = New System.Drawing.Point(136, 82)
        Me.txtHorarioEncargado.Name = "txtHorarioEncargado"
        Me.txtHorarioEncargado.Size = New System.Drawing.Size(373, 20)
        Me.txtHorarioEncargado.TabIndex = 2
        '
        'txtTelefonoEncargado
        '
        Me.txtTelefonoEncargado.Location = New System.Drawing.Point(161, 58)
        Me.txtTelefonoEncargado.Name = "txtTelefonoEncargado"
        Me.txtTelefonoEncargado.Size = New System.Drawing.Size(161, 20)
        Me.txtTelefonoEncargado.TabIndex = 1
        '
        'txtNombreEncargado
        '
        Me.txtNombreEncargado.Location = New System.Drawing.Point(136, 32)
        Me.txtNombreEncargado.Name = "txtNombreEncargado"
        Me.txtNombreEncargado.Size = New System.Drawing.Size(373, 20)
        Me.txtNombreEncargado.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Horario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Telefono"
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.txtObservaciones)
        Me.Panel.Controls.Add(Me.Label7)
        Me.Panel.Controls.Add(Me.cmbEstado)
        Me.Panel.Controls.Add(Me.txtMail)
        Me.Panel.Controls.Add(Me.Label13)
        Me.Panel.Controls.Add(Me.Label12)
        Me.Panel.Controls.Add(Me.cmbVendedor)
        Me.Panel.Controls.Add(Me.Vendedor)
        Me.Panel.Controls.Add(Me.cmbImportancia)
        Me.Panel.Controls.Add(Me.Label11)
        Me.Panel.Controls.Add(Me.cmbCategoria)
        Me.Panel.Controls.Add(Me.Label10)
        Me.Panel.Controls.Add(Me.txtHorarioNegocio)
        Me.Panel.Controls.Add(Me.txtTelefonoNegocio)
        Me.Panel.Controls.Add(Me.txtDireccion)
        Me.Panel.Controls.Add(Me.txtNombreNegocio)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.Label5)
        Me.Panel.Controls.Add(Me.Label3)
        Me.Panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel.Location = New System.Drawing.Point(24, 61)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(611, 315)
        Me.Panel.TabIndex = 1
        Me.Panel.TabStop = False
        Me.Panel.Text = "Negocio"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(136, 251)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(319, 58)
        Me.txtObservaciones.TabIndex = 20
        Me.txtObservaciones.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Observaciones"
        '
        'cmbEstado
        '
        Me.cmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(136, 225)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(319, 21)
        Me.cmbEstado.TabIndex = 9
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(136, 101)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(319, 20)
        Me.txtMail.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(41, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Correo Electronico"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Estado"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(136, 200)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(319, 21)
        Me.cmbVendedor.TabIndex = 8
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vendedor.Location = New System.Drawing.Point(41, 206)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(53, 13)
        Me.Vendedor.TabIndex = 13
        Me.Vendedor.Text = "Vendedor"
        '
        'cmbImportancia
        '
        Me.cmbImportancia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbImportancia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbImportancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImportancia.FormattingEnabled = True
        Me.cmbImportancia.Location = New System.Drawing.Point(136, 175)
        Me.cmbImportancia.Name = "cmbImportancia"
        Me.cmbImportancia.Size = New System.Drawing.Size(65, 21)
        Me.cmbImportancia.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(41, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Importancia"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(136, 149)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(319, 21)
        Me.cmbCategoria.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Categoria"
        '
        'txtHorarioNegocio
        '
        Me.txtHorarioNegocio.Location = New System.Drawing.Point(136, 125)
        Me.txtHorarioNegocio.Name = "txtHorarioNegocio"
        Me.txtHorarioNegocio.Size = New System.Drawing.Size(319, 20)
        Me.txtHorarioNegocio.TabIndex = 5
        '
        'txtTelefonoNegocio
        '
        Me.txtTelefonoNegocio.Location = New System.Drawing.Point(136, 76)
        Me.txtTelefonoNegocio.Name = "txtTelefonoNegocio"
        Me.txtTelefonoNegocio.Size = New System.Drawing.Size(186, 20)
        Me.txtTelefonoNegocio.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(136, 52)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(319, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtNombreNegocio
        '
        Me.txtNombreNegocio.Location = New System.Drawing.Point(136, 28)
        Me.txtNombreNegocio.Name = "txtNombreNegocio"
        Me.txtNombreNegocio.Size = New System.Drawing.Size(319, 20)
        Me.txtNombreNegocio.TabIndex = 1
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(150, 532)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 3
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdAtras
        '
        Me.cmdAtras.Location = New System.Drawing.Point(348, 532)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 23)
        Me.cmdAtras.TabIndex = 4
        Me.cmdAtras.Text = "Atras"
        Me.cmdAtras.UseVisualStyleBackColor = True
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(160, 28)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(218, 20)
        Me.txtfecha.TabIndex = 0
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 581)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AgregarCliente"
        Me.Text = "AgregarCliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel As GroupBox
    Friend WithEvents txtHorarioEncargado As TextBox
    Friend WithEvents txtTelefonoEncargado As TextBox
    Friend WithEvents txtNombreEncargado As TextBox
    Friend WithEvents txtHorarioNegocio As TextBox
    Friend WithEvents txtTelefonoNegocio As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombreNegocio As TextBox
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdAtras As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbImportancia As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbVendedor As ComboBox
    Friend WithEvents Vendedor As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservaciones As RichTextBox
End Class
