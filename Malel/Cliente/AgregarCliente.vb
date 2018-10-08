Public Class AgregarCliente

    Private Function conectarBD(ByVal nombreTabla As String)
        Dim tabla As New DataTable
        Dim consulta As String = "select * from " & nombreTabla
        Dim conexion As New conexion
        tabla = conexion.executeReader(consulta)
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
        Dim consulta As String
        Dim consulta2 As String
        Dim consulta3 As String
        Dim conexion As New conexion
        Dim tabla As New DataTable
        Try
            If validarDatosCliente() = True Then

                If MsgBox("¿Registrar nuevo cliente?", vbYesNo, "Aviso") = MsgBoxResult.Yes Then
                    consulta = "insert into Encargado values ('" & txtNombreEncargado.Text & "','" & txtHorarioEncargado.Text & "','" & txtTelefonoEncargado.Text & "')"
                    conexion.executeNonQuery(consulta)
                    consulta3 = "select MAX(id_encargado) as 'id_encargado' from Encargado"
                    Dim tabla2 As New DataTable
                    tabla2 = conexion.executeReader(consulta3)
                    Dim id_enc As Integer
                    If tabla2.Rows.Count > 0 Then
                        id_enc = tabla2.Rows.Item(0).Item("id_encargado")
                        consulta2 = "insert into Cliente values('" & txtNombreNegocio.Text & "','" & txtDireccion.Text & "','" & txtTelefonoNegocio.Text & "','" & txtHorarioNegocio.Text & "','" & txtMail.Text & "','" & txtObservaciones.Text & "','" & Convert.ToDateTime(txtfecha.Text) & "', " & id_enc & ", " & cmbCategoria.SelectedValue & "," & cmbEstado.SelectedValue & "," & cmbVendedor.SelectedValue & "," & cmbImportancia.SelectedValue & ")"
                        conexion.executeNonQuery(consulta2)
                        MsgBox("Cliente registrado con éxito:" & vbCrLf & txtNombreNegocio.Text & MsgBoxStyle.Information)
                    End If
                End If
            Else
                MsgBox("Complete los datos obligatorios", vbExclamation, "Atención")
            End If
        Catch ex As Exception
            MsgBox("ERROR" & vbCrLf & ex.Message)
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
        'acaes
        'cambios prueba
    End Sub

    Public Sub New(ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String,
                   ByVal horario As String, ByVal cmbCatIndex As Integer, ByVal cmbImpIndex As Integer, ByVal cmbVenIndex As Integer,
                   ByVal cmbEstIndex As Integer, ByVal encargado As String, ByVal telefonoEnc As String, ByVal horarioEnc As String)
        InitializeComponent()
        txtNombreNegocio.Text = nombre
        txtDireccion.Text = direccion
        txtTelefonoNegocio.Text = telefono
        txtMail.Text = email
        txtHorarioNegocio.Text = horario
        cmbCategoria.SelectedIndex = cmbCatIndex
        cmbImportancia.SelectedIndex = cmbImpIndex
        cmbVendedor.SelectedIndex = cmbVenIndex
        cmbEstado.SelectedIndex = cmbEstIndex
        txtNombreEncargado.Text = encargado
        txtTelefonoEncargado.Text = telefonoEnc
        txtHorarioEncargado.Text = horarioEnc
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
End Class