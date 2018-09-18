Public Class BuscarGastos

    Dim stringConexion As String = "Data Source=DESKTOP-IMS6DKK\SQLEXPRESS;Initial Catalog=Malel;Integrated Security=True"




    Private Sub cmdAtrasGastos_Click(sender As Object, e As EventArgs) Handles cmdAtrasGastos.Click
        If MsgBox("¿Realmente desea volver atras?", vbYesNo + vbExclamation, "Atención") = MsgBoxResult.Yes Then Me.Close()
    End Sub


    Private Sub cmdBuscarGasto_Click(sender As Object, e As EventArgs) Handles cmdBuscarGasto.Click

        Dim cmd As New SqlClient.SqlCommand
        Dim conexion As New SqlClient.SqlConnection
        Dim tabla As New DataTable
        conexion.ConnectionString = stringConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Gastos where fecha between '" & Convert.ToDateTime(calendarioDesde.Text) & "' and '" & Convert.ToDateTime(calendarioHasta.Text) & "'"
        tabla.Load(cmd.ExecuteReader)
        grillaGasto.DataSource = tabla
        conexion.Close()


    End Sub

    Private Sub cmdAgregarGasto_Click(sender As Object, e As EventArgs) Handles cmdAgregarGasto.Click

        AgragarGastos.ShowDialog()
    End Sub
End Class