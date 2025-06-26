Public Class ObtenerDatosUsuario
    Private datosUsuario As New Datos.ObtenerDatosUsuario()

    Public Function ObtenerDatosUsuario(ByVal numeroCliente As String) As DataTable
        Return datosUsuario.ObtenerDatosUsuario(numeroCliente)
    End Function
End Class
