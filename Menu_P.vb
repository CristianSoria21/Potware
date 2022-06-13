Public Class Menu_P
    Private Sub Menu_P_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        Form1.Visible = False
    End Sub


    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Form1.Enabled = True
        Form1.Visible = True
        Close()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        Proveedores.ID_Proveedores.Enabled = False
        Proveedores.Direccion.Enabled = True
        Proveedores.Ciudad.Enabled = True
        Proveedores.Tel.Enabled = True
        Proveedores.Encargado.Enabled = True
        Proveedores.RazonSocial.Enabled = True

        Proveedores.Insertar.Enabled = True
        Proveedores.Eliminar.Enabled = False
        Proveedores.Consultar.Enabled = False
        Proveedores.Modificar.Enabled = False
        Proveedores.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        Proveedores.Show()

        Proveedores.ID_Proveedores.Enabled = True
        Proveedores.Direccion.Enabled = True
        Proveedores.Ciudad.Enabled = True
        Proveedores.Tel.Enabled = True
        Proveedores.Encargado.Enabled = True
        Proveedores.RazonSocial.Enabled = True

        Proveedores.Insertar.Enabled = False
        Proveedores.Eliminar.Enabled = False
        Proveedores.Consultar.Enabled = True
        Proveedores.Modificar.Enabled = True
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        Proveedores.Show()
        Proveedores.ID_Proveedores.Enabled = True
        Proveedores.Direccion.Enabled = False
        Proveedores.Ciudad.Enabled = False
        Proveedores.Tel.Enabled = False
        Proveedores.Encargado.Enabled = False
        Proveedores.RazonSocial.Enabled = False


        Proveedores.Insertar.Enabled = False
        Proveedores.Eliminar.Enabled = False
        Proveedores.Consultar.Enabled = True
        Proveedores.Modificar.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        Proveedores.Show()
        Proveedores.ID_Proveedores.Enabled = True
        Proveedores.Direccion.Enabled = False
        Proveedores.Ciudad.Enabled = False
        Proveedores.Tel.Enabled = False
        Proveedores.Encargado.Enabled = False
        Proveedores.RazonSocial.Enabled = False


        Proveedores.Insertar.Enabled = False
        Proveedores.Eliminar.Enabled = True
        Proveedores.Consultar.Enabled = True
        Proveedores.Modificar.Enabled = False
    End Sub

    Private Sub INSERTAR_Click(sender As Object, e As EventArgs) Handles INSERTAR.Click
        Productos.Show()

    End Sub


    Private Sub InsertCompras_Click(sender As Object, e As EventArgs) Handles InsertCompras.Click

        Compras.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Ventas.Show()

    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        MateriasPrimas.Show()

    End Sub
End Class