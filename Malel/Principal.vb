Public Class Principal
    Private Sub DadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DadaToolStripMenuItem.Click
        BuscarGastos.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Realmente desea salir del programa?", vbYesNo + vbExclamation, "Atención") = MsgBoxResult.Yes Then Me.Close()

    End Sub

    Private Sub AgregarNuevoVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoVendedorToolStripMenuItem.Click
        AgregarVendedor.ShowDialog()
    End Sub

    Private Sub BuscarVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarVendedorToolStripMenuItem.Click
        BuscarVendedor.ShowDialog()
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        AgregarCliente.ShowDialog()
    End Sub

    Private Sub BuscarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarClienteToolStripMenuItem.Click
        BuscarCliente.ShowDialog()
    End Sub


End Class