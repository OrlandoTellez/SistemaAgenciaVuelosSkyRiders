Public Class RegistrarPagos
    Dim Datos As New Datos.RegistrarPagos()
    Public Function RegistrarPagos(ByVal xcodigoReserva As String, ByVal xmetodoPago As String, ByVal xtarjeta As String, ByVal xmontoTotal As String) As Boolean
        Dim resultado As Boolean

        resultado = Datos.RegistrarPagos(xcodigoReserva, xmetodoPago, xtarjeta, xmontoTotal)

        Return resultado
    End Function
End Class
