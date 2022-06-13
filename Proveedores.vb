Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu_P.Enabled = False
        Menu_P.Visible = False

        consulta = New ADODB.Recordset
        consulta = conexion.Execute("select cvpv from proveedores order by cvpv")

        While Not consulta.EOF
            ID_Proveedores.Items.Add(consulta.Fields(0))
            consulta.MoveNext()
        End While
    End Sub

    Private Sub ID_Proveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ID_Proveedores.SelectedIndexChanged

    End Sub
End Class