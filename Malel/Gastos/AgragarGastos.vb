Public Class AgragarGastos


    Dim stringConexion As String = "Data Source=DESKTOP-IMS6DKK\SQLEXPRESS;Initial Catalog=Malel;Integrated Security=True"

    Private Sub cmdGuardarGasto_Click(sender As Object, e As EventArgs) Handles cmdGuardarGasto.Click

        If txtGasto.Text = "" And txtMonto.Text = "" Then
            MsgBox("No se puede ingresar un nuevo gasto sin Nombre o Monto", MsgBoxStyle.Exclamation, "Aviso")
        Else

            Dim cmd As New SqlClient.SqlCommand
            Dim tabla As New DataTable
            Dim conexion As New SqlClient.SqlConnection
            Try

                conexion.ConnectionString = stringConexion
                conexion.Open()
                cmd.Connection = conexion

                If MsgBox("¿Registrar nuevo Gasto?", vbYesNo, "Aviso") = MsgBoxResult.Yes Then
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "insert into Gastos values('" & txtGasto.Text & "','" & txtMonto.Text & "','" & Convert.ToDateTime(calendarioGasto.Text) & "','" & txtObservaciones.Text & "')"
                    cmd.ExecuteNonQuery()
                    MsgBox("Gasto registrado con éxito:" & vbCrLf & txtGasto.Text & ", Monto: " & txtMonto.Text, MsgBoxStyle.Information, "Aviso")

                End If
                txtGasto.Text = ""
                txtMonto.Text = ""
                txtObservaciones.Text = ""

            Catch ex As Exception
                MsgBox("ERROR" & vbCrLf & ex.Message)
            Finally
                conexion.Close()
            End Try
        End If

    End Sub
End Class