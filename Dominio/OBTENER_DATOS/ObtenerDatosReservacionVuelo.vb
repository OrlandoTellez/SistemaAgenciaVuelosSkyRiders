Public Class ObtenerDatosReservacionVuelo
    Private datosReservacionVuelo As New Datos.ObtenerDatosReservacionVuelo()

    Public Function ObtenerDatosReserva(ByVal numeroCliente As String) As DataTable
        Return datosReservacionVuelo.ObtenerDatosReservacionVuelo(numeroCliente)
    End Function
End Class
