
Public Class ObtenerDatosClientes
    Private datosCliente As New Datos.ObtenerDatosClientes()

    Public Function ObtenerDatosDelCliente(ByVal numeroCliente As String) As DataTable
        Return datosCliente.ObtenerDatosCliente(numeroCliente)
    End Function
End Class
