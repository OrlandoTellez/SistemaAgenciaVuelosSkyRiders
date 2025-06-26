Public Class RegistrarReserva
    Dim Datos As New Datos.RegistrarReserva()
    Public Function RegistrarReserva(ByVal xcodigoReserva As String, ByVal xnumeroCliente As String, ByVal xnumeroVuelo As String, ByVal xfechaReserva As Date, ByVal xcantidadPasajero As Integer) As Boolean
        Dim resultado As Boolean

        resultado = Datos.RegistrarReserva(xcodigoReserva, xnumeroCliente, xnumeroVuelo, xfechaReserva, xcantidadPasajero)

        Return resultado
    End Function
End Class
