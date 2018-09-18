Public Class AgregarCliente


    Dim stringConexion As String = "Data Source=DESKTOP-IMS6DKK\SQLEXPRESS;Initial Catalog=Malel;Integrated Security=True"

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

    Private Sub cmdAtras_Click(sender As Object, e As EventArgs) Handles cmdAtras.Click
        If MsgBox("¿Realmente desea volver atras y perder los cambios no guardados?", vbYesNo + vbExclamation, "Atención") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef datos As DataTable, ByVal pk As String, ByVal des As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = des
    End Sub

    Private Sub cargarCombo2(ByRef combo As ComboBox, ByRef datos As DataTable, ByVal pk As String, ByVal des As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = des
    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarCombo(cmbImportancia, conectarBD("Importancia"), "id_importancia", "descripcion")
        cargarCombo(cmbCategoria, conectarBD("CategoriaNegocio"), "id_categoria", "categoria")

        cargarCombo(cmbVendedor, conectarBD("Vendedor"), "legajo", "nomape")
        cargarCombo(cmbEstado, conectarBD("EstadoCliente"), "id_estado", "descripcion")
        cmbCategoria.SelectedIndex = -1
        cmbImportancia.SelectedIndex = -1
        cmbVendedor.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1


    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim cmd As New SqlClient.SqlCommand
        Dim cmd2 As New SqlClient.SqlCommand
        Dim cmd3 As New SqlClient.SqlCommand

        Dim tabla As New DataTable
        Dim conexion As New SqlClient.SqlConnection
        Try
            conexion.ConnectionString = stringConexion
            conexion.Open()

            cmd.Connection = conexion
            cmd2.Connection = conexion
            cmd3.Connection = conexion


            If validarDatosCliente() = True Then

                If MsgBox("¿Registrar nuevo cliente?", vbYesNo, "Aviso") = MsgBoxResult.Yes Then
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "insert into Encargado values ('" & txtNombreEncargado.Text & "','" & txtHorarioEncargado.Text & "','" & txtTelefonoEncargado.Text & "')"
                    cmd.ExecuteNonQuery()
                    cmd2.CommandType = CommandType.Text
                    cmd3.CommandType = CommandType.Text
                    cmd3.CommandText = "select MAX(id_encargado) as 'id_encargado' from Encargado"
                    Dim tabla2 As New DataTable
                    tabla2.Load(cmd3.ExecuteReader)
                    Dim id_enc As Integer
                    If tabla2.Rows.Count > 0 Then
                        id_enc = tabla2.Rows.Item(0).Item("id_encargado")
                        cmd2.CommandText = "insert into Cliente values('" & txtNombreNegocio.Text & "','" & txtDireccion.Text & "','" & txtTelefonoNegocio.Text & "','" & txtHorarioNegocio.Text & "','" & txtMail.Text & "','" & txtObservaciones.Text & "','" & Convert.ToDateTime(txtfecha.Text) & "', " & id_enc & ", " & cmbCategoria.SelectedValue & "," & cmbEstado.SelectedValue & "," & cmbVendedor.SelectedValue & "," & cmbImportancia.SelectedValue & ")"
                        cmd2.ExecuteNonQuery()
                        conexion.Close()
                        MsgBox("Cliente registrado con éxito:" & vbCrLf & txtNombreNegocio.Text & MsgBoxStyle.Information)

                    End If
                End If
            Else
                MsgBox("Complete los datos obligatorios", vbExclamation, "Atención")

            End If

        Catch ex As Exception
            MsgBox("ERROR" & vbCrLf & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Function validarDatosCliente() As Boolean
        Dim f As Boolean
        f = False
        If txtNombreNegocio.Text <> "" And txtNombreEncargado.Text <> "" Then
            f = True
        End If
        Return f
    End Function

    Private Sub mod_combo()
        cmbCategoria.SelectedIndex = 1

    End Sub
End Class