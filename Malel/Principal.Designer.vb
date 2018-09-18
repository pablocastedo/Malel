<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RRHHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.DadaToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.RRHHToolStripMenuItem, Me.SalirToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.BuscarClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        resources.ApplyResources(Me.ClientesToolStripMenuItem, "ClientesToolStripMenuItem")
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        resources.ApplyResources(Me.AgregarClienteToolStripMenuItem, "AgregarClienteToolStripMenuItem")
        '
        'BuscarClienteToolStripMenuItem
        '
        Me.BuscarClienteToolStripMenuItem.Name = "BuscarClienteToolStripMenuItem"
        resources.ApplyResources(Me.BuscarClienteToolStripMenuItem, "BuscarClienteToolStripMenuItem")
        '
        'DadaToolStripMenuItem
        '
        Me.DadaToolStripMenuItem.Name = "DadaToolStripMenuItem"
        resources.ApplyResources(Me.DadaToolStripMenuItem, "DadaToolStripMenuItem")
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoProductoToolStripMenuItem, Me.EliminarProductoToolStripMenuItem})
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        resources.ApplyResources(Me.ProductoToolStripMenuItem, "ProductoToolStripMenuItem")
        '
        'AgregarNuevoProductoToolStripMenuItem
        '
        Me.AgregarNuevoProductoToolStripMenuItem.Name = "AgregarNuevoProductoToolStripMenuItem"
        resources.ApplyResources(Me.AgregarNuevoProductoToolStripMenuItem, "AgregarNuevoProductoToolStripMenuItem")
        '
        'EliminarProductoToolStripMenuItem
        '
        Me.EliminarProductoToolStripMenuItem.Name = "EliminarProductoToolStripMenuItem"
        resources.ApplyResources(Me.EliminarProductoToolStripMenuItem, "EliminarProductoToolStripMenuItem")
        '
        'RRHHToolStripMenuItem
        '
        Me.RRHHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoVendedorToolStripMenuItem, Me.BuscarVendedorToolStripMenuItem})
        Me.RRHHToolStripMenuItem.Name = "RRHHToolStripMenuItem"
        resources.ApplyResources(Me.RRHHToolStripMenuItem, "RRHHToolStripMenuItem")
        '
        'AgregarNuevoVendedorToolStripMenuItem
        '
        Me.AgregarNuevoVendedorToolStripMenuItem.Name = "AgregarNuevoVendedorToolStripMenuItem"
        resources.ApplyResources(Me.AgregarNuevoVendedorToolStripMenuItem, "AgregarNuevoVendedorToolStripMenuItem")
        '
        'BuscarVendedorToolStripMenuItem
        '
        Me.BuscarVendedorToolStripMenuItem.Name = "BuscarVendedorToolStripMenuItem"
        resources.ApplyResources(Me.BuscarVendedorToolStripMenuItem, "BuscarVendedorToolStripMenuItem")
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        '
        'Principal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Malel.My.Resources.Resources.WhatsApp_Image_2018_08_22_at_20_44_53
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RRHHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoVendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarVendedorToolStripMenuItem As ToolStripMenuItem
End Class
