Public Class BuscarCliente

    Dim stringConexion As String = "Data Source=DESKTOP-IMS6DKK\SQLEXPRESS;Initial Catalog=Malel;Integrated Security=True"
    Dim tabla As New DataTable

    Private Function conectarBD(ByVal nombreTabla As String)

        Dim tabla As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        Dim conexion As New SqlClient.SqlConnection
        Try
            conexion.ConnectionString = stringConexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from " & nombreTabla
            tabla.Load(cmd.ExecuteReader)
        Catch
        Finally
            conexion.Close()
        End Try
        Return tabla

    End Function

    Private Sub limpiarRbn()
        txtNombre.Enabled = False
        cmbCategoria.Enabled = False
        cmbVendedor.Enabled = False
        cmbEstado.Enabled = False
        txtNombre.Clear()
        cmbVendedor.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
        cmbCategoria.SelectedIndex = -1

    End Sub


    Private Sub cmdMostrarClientes_Click(sender As Object, e As EventArgs) Handles cmdMostrarClientes.Click
        Dim cmd As New SqlClient.SqlCommand
        Dim conexion As New SqlClient.SqlConnection
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = stringConexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select s.id_estado as'estadoid', c.nombre as 'Nombre Negocio',c.telefonoLocal as 'Telefono',c.direccion as 'Direccion Negocio',e.nombre as 'Encargado',a.categoria,s.descripcion as 'estado',v.nomape as 'Vendedor' from Cliente c, Importancia i,Encargado e,CategoriaNegocio a,EstadoCliente s,Vendedor v where c.encargado=e.id_encargado and s.id_estado=c.estado and c.categoria=a.id_categoria and c.importancia=i.id_importancia and c.vendedor=v.legajo"
            'cmd.CommandText = "select *,estado as 'estadoid' from Cliente"
            'cmd.CommandText = "select s.id_estado, c.nombre as 'Nombre Negocio',c.telefonoLocal as 'Telefono',c.direccion as 'Direccion Negocio',e.nombre as 'Encargado',a.categoria,s.descripcion as 'Estado',v.nomape as 'Vendedor' from Cliente c, Importancia i,Encargado e,CategoriaNegocio a,EstadoCliente s,Vendedor v where c.encargado=e.id_encargado and s.id_estado=c.estado and c.categoria=a.id_categoria and c.importancia=i.id_importancia and c.vendedor=v.legajo"

            tabla.Load(cmd.ExecuteReader)
            grillaCliente.DataSource = tabla
            conexion.Close()

            grillaCliente.Columns(0).Visible = False
            asignarColoresTabla()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub cmdBuscarCliente_Click(sender As Object, e As EventArgs) Handles cmdBuscarCliente.Click


        If txtNombre.Text = "" And cmbVendedor.SelectedIndex = -1 And cmbCategoria.SelectedIndex = -1 And cmbEstado.SelectedIndex = -1 Then

            MsgBox("No se puede realizar la busqueda con un filtro vacio", MsgBoxStyle.Exclamation, "Aviso")
        Else
            Dim cmd As New SqlClient.SqlCommand
            Dim conexion As New SqlClient.SqlConnection
            Dim tabla As New DataTable
            Try
                If rbnNombre.Checked = True Then
                    conexion.ConnectionString = stringConexion
                    conexion.Open()
                    cmd.Connection = conexion
                    cmd.CommandType = CommandType.Text
                    'cmd.CommandText = "select * from Cliente where nombre like '%" & txtNombre.Text & "%'"
                    cmd.CommandText = "select s.id_estado as 'estadoid', c.nombre as 'Nombre Negocio',c.telefonoLocal as 'Telefono',c.direccion as 'Direccion Negocio',e.nombre as 'Encargado',a.categoria,s.descripcion as 'Estado',v.nomape as 'Vendedor' from Cliente c, Importancia i,Encargado e,CategoriaNegocio a,EstadoCliente s,Vendedor v where c.encargado=e.id_encargado and s.id_estado=c.estado and c.categoria=a.id_categoria and c.importancia=i.id_importancia and c.vendedor=v.legajo and c.nombre like '%" & txtNombre.Text & "%'"
                    tabla.Load(cmd.ExecuteReader)
                    grillaCliente.DataSource = tabla
                    conexion.Close()
                Else
                    If rbnVendedor.Checked = True Then
                        conexion.ConnectionString = stringConexion
                        conexion.Open()
                        cmd.Connection = conexion
                        cmd.CommandType = CommandType.Text
                        'cmd.CommandText = "select * from Cliente where vendedor=" & cmbVendedor.SelectedValue
                        cmd.CommandText = "select s.id_estado as'estadoid', c.nombre as 'Nombre Negocio',c.telefonoLocal as 'Telefono',c.direccion as 'Direccion Negocio',e.nombre as 'Encargado',a.categoria,s.descripcion as 'estado',v.nomape as 'Vendedor' from Cliente c, Importancia i,Encargado e,CategoriaNegocio a,EstadoCliente s,Vendedor v where c.encargado=e.id_encargado and s.id_estado=c.estado and c.categoria=a.id_categoria and c.importancia=i.id_importancia and c.vendedor=v.legajo and v.legajo=" & cmbVendedor.SelectedValue
                        tabla.Load(cmd.ExecuteReader)
                        grillaCliente.DataSource = tabla
                        conexion.Close()

                        '                'GrillaProductos.Columns(2).Visible = False
                    Else
                        If rbnCategoria.Checked = True Then
                            conexion.ConnectionString = stringConexion
                            conexion.Open()
                            cmd.Connection = conexion
                            cmd.CommandType = CommandType.Text
                            'cmd.CommandText = "select * from Cliente where categoria =" & cmbCategoria.SelectedValue
                            cmd.CommandText = "select s.id_estado as 'estadoid', c.nombre as 'Nombre Negocio',c.telefonoLocal as 'Telefono',c.direccion as 'Direccion Negocio',e.nombre as 'Encargado',a.categoria,s.descripcion as 'Estado',v.nomape as 'Vendedor' from Cliente c, Importancia i,Encargado e,CategoriaNegocio a,EstadoCliente s,Vendedor v where c.encargado=e.id_encargado and s.id_estado=c.estado and c.categoria=a.id_categoria and c.importancia=i.id_importancia and c.vendedor=v.legajo and a.id_categoria=" & cmbCategoria.SelectedValue
                            tabla.Load(cmd.ExecuteReader)
                            grillaCliente.DataSource = tabla
                            'GrillaProductos.DataSource = tabla
                            ' GrillaProductos.Columns(19).HeaderText = "Categoria de Producto"
                            conexion.Close()
                        Else
                            If rbnEstado.Checked = True Then
                                conexion.ConnectionString = stringConexion
                                conexion.Open()
                                cmd.Connection = conexion
                                cmd.CommandType = CommandType.Text
                                'cmd.CommandText = "select * from Cliente where categoria =" & cmbCategoria.SelectedValue
                                cmd.CommandText = "select s.id_estado as 'estadoid', c.nombre as 'Nombre Negocio',c.telefonoLocal as 'Telefono',c.direccion as 'Direccion Negocio',e.nombre as 'Encargado',a.categoria,s.descripcion as 'Estado',v.nomape as 'Vendedor' from Cliente c, Importancia i,Encargado e,CategoriaNegocio a,EstadoCliente s,Vendedor v where c.encargado=e.id_encargado and s.id_estado=c.estado and c.categoria=a.id_categoria and c.importancia=i.id_importancia and c.vendedor=v.legajo and s.id_estado=" & cmbEstado.SelectedValue
                                tabla.Load(cmd.ExecuteReader)
                                grillaCliente.DataSource = tabla
                                'GrillaProductos.DataSource = tabla
                                ' GrillaProductos.Columns(19).HeaderText = "Categoria de Producto"

                                conexion.Close()

                            End If
                        End If
                    End If
                    '           
                End If

            Catch ex As Exception
                MsgBox("Datos incorrectos", MsgBoxStyle.Exclamation, "Aviso")
            Finally
                conexion.Close()
            End Try
        End If
        asignarColoresTabla()
    End Sub

    Private Sub cmdAtras_Click(sender As Object, e As EventArgs) Handles cmdAtras.Click
        If MsgBox("¿Realmente desea volver atras y perder los cambios no guardados?", vbYesNo + vbExclamation, "Atención") = MsgBoxResult.Yes Then salir()
    End Sub


    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef datos As DataTable, ByVal pk As String, ByVal des As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = des
    End Sub




    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbCategoria, conectarBD("CategoriaNegocio"), "id_categoria", "Categoria")
        cargarCombo(cmbVendedor, conectarBD("Vendedor"), "legajo", "nomape")
        cargarCombo(cmbEstado, conectarBD("EstadoCliente"), "id_estado", "descripcion")

        txtNombre.Text = ""
        cmbVendedor.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
        cmbCategoria.SelectedIndex = -1
        ' grillaCliente.Rows.Clear()

    End Sub

    Private Sub rbnNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbnNombre.CheckedChanged
        limpiarRbn()
        txtNombre.Enabled = True

    End Sub

    Private Sub rbnVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbnVendedor.CheckedChanged
        limpiarRbn()
        cmbVendedor.Enabled = True
    End Sub

    Private Sub rbnCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles rbnCategoria.CheckedChanged
        limpiarRbn()
        cmbCategoria.Enabled = True
    End Sub

    Private Sub rbnEstado_CheckedChanged(sender As Object, e As EventArgs) Handles rbnEstado.CheckedChanged
        limpiarRbn()
        cmbEstado.Enabled = True
    End Sub


    Private Sub salir()
        grillaCliente.DataSource = ""
        Me.Close()
    End Sub

    Private Sub asignarColoresTabla()
        For Each row As DataGridViewRow In grillaCliente.Rows
            If (row.Cells("estadoid").Value = 1) Then
                row.DefaultCellStyle.BackColor = Color.Aqua
            End If
            If (row.Cells("estadoid").Value = 2) Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If
            If (row.Cells("estadoid").Value = 3) Then
                row.DefaultCellStyle.BackColor = Color.LightSkyBlue
            End If
            If (row.Cells("estadoid").Value = 4) Then
                row.DefaultCellStyle.BackColor = Color.Blue
            End If
            If (row.Cells("estadoid").Value = 5) Then
                row.DefaultCellStyle.BackColor = Color.Pink

            End If
        Next
    End Sub

    Private Sub cmdConsultarCliente_Click(sender As Object, e As EventArgs) Handles cmdConsultarCliente.Click
        Dim cliente As New AgregarCliente
        'Dim cmd As New SqlClient.SqlCommand
        'Dim conexion As New SqlClient.SqlConnection
        'Dim tabla As New DataTable
        'Try
        '    conexion.ConnectionString = stringConexion
        '    conexion.Open()
        '    cmd.Connection = conexion
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "select * from Cliente"
        '    tabla.Load(cmd.ExecuteReader)
        '    grillaCliente.DataSource = tabla
        '    conexion.Close()

        '    'grillaCliente.Columns(0).Visible = False
        '    ' asignarColoresTabla()

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    conexion.Close()
        'End Try


        cliente.txtNombreNegocio.Text = grillaCliente.CurrentRow.Cells(1).Value
        cliente.txtTelefonoNegocio.Text = grillaCliente.CurrentRow.Cells(2).Value
        cliente.txtDireccion.Text = grillaCliente.CurrentRow.Cells(3).Value
        cliente.txtNombreEncargado.Text = grillaCliente.CurrentRow.Cells(4).Value
        'cliente.txtUsuario.Text = grillaCliente.CurrentRow.Cells(5).Value
        cliente.txtNombreNegocio.Enabled = False

        cliente.ShowDialog()

    End Sub
End Class
