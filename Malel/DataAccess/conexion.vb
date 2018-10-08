Public Class conexion
    Dim stringConexionSanti As String = ""
    Dim connection As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Public Shared ReadOnly Property Instance As conexion
        Get
            Static INST As conexion = New conexion
            Return INST
        End Get
    End Property

    Private Sub setConexion()
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection
        Select Case Environment.MachineName
            Case "DESKTOP-JBOLI9G"
                connection.ConnectionString = "Data Source=DESKTOP-JBOLI9G\SQLEXPRESS;Initial Catalog=Malel;Integrated Security=True"
            Case "DESKTOP-IMS6DKK"
                connection.ConnectionString = "Data Source=DESKTOP-IMS6DKK\SQLEXPRESS;Initial Catalog=Malel;Integrated Security=True"
        End Select
    End Sub

    Public Sub executeNonQuery(cmdText As String)
        setConexion()
        cmd.CommandText = cmdText
        Try
            connection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ERROR" & vbCrLf & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Function executeReader(cmdText As String)
        setConexion()
        Dim table As New DataTable
        cmd.CommandText = cmdText
        Try
            connection.Open()
            table.Load(cmd.ExecuteReader)
        Catch ex As Exception
            MsgBox("ERROR" & vbCrLf & ex.Message)
        Finally
            connection.Close()
        End Try
        Return table
    End Function

End Class
