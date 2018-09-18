Public Class AgregarVendedor

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

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click

        If txtNomApe.Text = "" And txtDni.Text = "" Then

            MsgBox("No se puede ingresar un nuevo vendedor sin Nombre o DNI", MsgBoxStyle.Exclamation, "Aviso")

        Else

            Dim cmd As New SqlClient.SqlCommand
            Dim tabla As New DataTable
            Dim conexion As New SqlClient.SqlConnection
            Try

                conexion.ConnectionString = stringConexion
                conexion.Open()
                cmd.Connection = conexion

                If MsgBox("¿Registrar nuevo Vendedor?", vbYesNo, "Aviso") = MsgBoxResult.Yes Then
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "insert into Vendedor values(" & txtDni.Text & ",'" & txtNomApe.Text & "','" & txtTelefono.Text & "')"
                    cmd.ExecuteNonQuery()
                    'MsgBox("Vendedor registrado con éxito:" & vbCrLf & txtNomApe.Text & ", DNI: " & txtDni.Text, MsgBoxStyle.Information, "Aviso")
                    'MsgBox("Vendedor registrado con éxito: " & vbCrLf & txtNomApe.Text)
                    Dim tabla2 As New DataTable
                    Dim cmd3 As New SqlClient.SqlCommand
                    cmd3.Connection = conexion
                    cmd3.CommandText = "select MAX(legajo) as 'legajo' from Vendedor"
                    tabla2.Load(cmd3.ExecuteReader)
                    If tabla2.Rows.Count > 0 Then

                        lblLegajo.Text = tabla2.Rows.Item(0).Item("legajo")
                        MsgBox("Vendedor registrado con éxito:" & vbCrLf & txtNomApe.Text & ", Legajo: " & lblLegajo.Text, MsgBoxStyle.Information, "Aviso")
                        ' MsgBox("Legajo: " & vbCrLf & lblLegajo.Text)
                        'lblLegajo.Visible = True
                        'Label3.Visible = True


                    End If
                End If
                txtDni.Text = ""
                txtNomApe.Text = ""
                txtTelefono.Text = ""

            Catch ex As Exception
                MsgBox("ERROR" & vbCrLf & ex.Message)
            Finally
                conexion.Close()
            End Try
        End If
    End Sub


    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click

        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim conexion As New SqlClient.SqlConnection

        Try
            conexion.ConnectionString = stringConexion
            conexion.Open()
            cmd.Connection = conexion

            If MsgBox("¿Modificar datos del vendedor?", vbYesNo, "Aviso") = MsgBoxResult.Yes Then

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update Vendedor set nomape='" & txtNomApe.Text & "',telefono='" & txtTelefono.Text & "' where legajo=" & lblLegajo.Text
                cmd.ExecuteNonQuery()
                MsgBox("Vendedor modificado con éxito:" & vbCrLf & txtNomApe.Text & ", " & txtDni.Text, MsgBoxStyle.Information, "Aviso")

            End If

        Catch ex As Exception
            MsgBox("ERROR" & vbCrLf & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        If MsgBox("¿Realmente desea volver atras y perder los cambios no guardados?", vbYesNo + vbExclamation, "Atención") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub AgregarVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtNomApe.Text = ""
        'txtTelefono.Text = ""
        'txtDni.Text = ""
        'txtUsuario.Text = ""
    End Sub


End Class