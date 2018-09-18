Public Class BuscarVendedor


    Dim stringConexion As String = "Data Source=DESKTOP-IMS6DKK\SQLEXPRESS;Initial Catalog=Malel;Integrated Security=True"


    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click

        Dim cmd As New SqlClient.SqlCommand
        Dim conexion As New SqlClient.SqlConnection
        Dim tabla As New DataTable


        If txtDNI.Text = "" And txtNombre.Text = "" Then

            MsgBox("No se puede realizar la busqueda con un filtro vacio", MsgBoxStyle.Exclamation, "Aviso")

        Else
            Try
                If rbnNombre.Checked = True Then
                    conexion.ConnectionString = stringConexion
                    conexion.Open()
                    cmd.Connection = conexion
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from Vendedor where nomape like '%" & txtNombre.Text & "%'"
                    tabla.Load(cmd.ExecuteReader)
                    grillaVendedor.DataSource = tabla
                    conexion.Close()

                Else
                    If rbnDni.Checked = True Then
                        conexion.ConnectionString = stringConexion
                        conexion.Open()
                        cmd.Connection = conexion
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "select * from Vendedor where dni=" & txtDNI.Text & ""
                        tabla.Load(cmd.ExecuteReader)
                        grillaVendedor.DataSource = tabla
                        'GrillaProductos.DataSource = tabla
                        ' GrillaProductos.Columns(19).HeaderText = "Categoria de Producto"
                        conexion.Close()
                        'GrillaProductos.Columns(2).Visible = False
                        'GrillaProductos.Columns(3).Visible = False

                    End If
                    txtNombre.Clear()
                    txtDNI.Clear()
                End If

            Catch ex As Exception
                MsgBox("Datos incorrectos", MsgBoxStyle.Exclamation, "Aviso")
            Finally
                conexion.Close()
            End Try

        End If

    End Sub

    Private Sub rbnNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbnNombre.CheckedChanged
        txtNombre.Enabled = True
        txtDNI.Enabled = False
        txtNombre.Clear()
        txtDNI.Clear()

    End Sub

    Private Sub rbnDni_CheckedChanged(sender As Object, e As EventArgs) Handles rbnDni.CheckedChanged
        txtDNI.Enabled = True
        txtNombre.Enabled = False
        txtNombre.Clear()
        txtDNI.Clear()
    End Sub

    Private Sub txtMostrar_Click(sender As Object, e As EventArgs) Handles txtMostrar.Click
        Dim cmd As New SqlClient.SqlCommand
        Dim conexion As New SqlClient.SqlConnection
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = stringConexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Vendedor"
            tabla.Load(cmd.ExecuteReader)
            grillaVendedor.DataSource = tabla
            conexion.Close()

            'GrillaProductos.Columns(2).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub grilla_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaVendedor.CellContentDoubleClick, grillaVendedor.CellDoubleClick

        Dim vendedor As New AgregarVendedor
        ' turno.txtFechaa.Text = Date.Today
        vendedor.lblLegajo.Text = grillaVendedor.CurrentRow.Cells(0).Value
        vendedor.txtDni.Text = grillaVendedor.CurrentRow.Cells(1).Value
        vendedor.txtNomApe.Text = grillaVendedor.CurrentRow.Cells(2).Value
        vendedor.txtTelefono.Text = grillaVendedor.CurrentRow.Cells(3).Value

        vendedor.lblLegajo.Visible = True
        vendedor.Label3.Visible = True
        vendedor.cmdAgregar.Enabled = False
        vendedor.cmdModificar.Enabled = True
        vendedor.txtDni.Enabled = False

        vendedor.ShowDialog()


    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click

        Try
            If MsgBox("Esta Seguro que desea quitar este vendedor?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                grillaVendedor.Rows.Remove(grillaVendedor.CurrentRow)
            End If
        Catch ex As Exception
        End Try


    End Sub

    Private Sub BuscarVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtDNI.Text = ""
        'txtNombre.Text = ""
        txtNombre.Clear()
        txtDNI.Clear()
        'grilla.Rows.Clear()


    End Sub

    Private Sub cmdAtras_Click(sender As Object, e As EventArgs) Handles cmdAtras.Click
        If MsgBox("¿Realmente desea volver atras y perder los cambios no guardados?", vbYesNo + vbExclamation, "Atención") = MsgBoxResult.Yes Then Me.Close()
    End Sub


End Class