Public Class Loguin


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

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click

        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim conexion As New SqlClient.SqlConnection

        Try
            conexion.ConnectionString = stringConexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = "select * from Usuario where usuario='" & txtUsuario.Text & "' and contraseña='" & txtContraseña.Text & "'"
            tabla.Load(cmd.ExecuteReader)
            If tabla.Rows.Count = 0 Then
                MsgBox("Usuario o Contraseña incorrecto" & vbCrLf, MsgBoxStyle.Information, "Aviso")
            Else

                Principal.ShowDialog()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("ERROR" & vbCrLf & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        If MsgBox("¿Realmente desea salir del programa?", vbYesNo + vbExclamation, "Atención") = MsgBoxResult.Yes Then Me.Close()
    End Sub


End Class
