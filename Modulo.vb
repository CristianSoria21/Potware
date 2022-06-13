
Module Modulo

    Public consulta As Recordset
    Public ban As ADODB.Parameter
    Public comando As ADODB.Command
    Public conexion As ADODB.Connection
    Public consql As String


    Public Sub conectar()
        conexion = New ADODB.Connection
        With conexion
            .Provider = "sqloledb"
            .ConnectionString = "INITIAL CATALOG=POTWARE;SERVER=CRISTIANSORIA;INTEGRATED SECURITY=SSPI;PERSIST SECURITY INFO=TRUE"
            Try
                .Open()
                MessageBox.Show("Conexión correcta")

            Catch ex As Exception
                MessageBox.Show("Conexión fallida" + ex.ToString())
            End Try


        End With
    End Sub
End Module
