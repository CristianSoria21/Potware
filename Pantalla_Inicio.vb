Public Class Form1
    Private Sub Pantalla_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        conexion.Close()
        Close()

    End Sub

    Private Sub ENTRAR_Click(sender As Object, e As EventArgs) Handles ENTRAR.Click
        Call conectar()
        Menu_P.Show()
    End Sub
End Class
