Public Class VerificarCliente
    Dim datos As New Datos.VerificarCliente()

    Public Function ObtenerNumeroCliente(ByVal xusuario As String, ByVal xpassword As String) As String
        Return datos.ObtenerNumeroCliente(xusuario, xpassword)
    End Function
End Class

