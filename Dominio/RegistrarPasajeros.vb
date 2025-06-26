Public Class RegistrarPasajeros
    Dim Datos As New Datos.RegistrarPasajeros()
    Public Function RegistrarPasajeros(ByVal xnumeroPasajero As String, ByVal xcodigoReserva As String, ByVal xpasajeroNombre As String, ByVal xpasajeroApellido As String, ByVal xpasajeroPasaporte As String, ByVal xpasajeroCorreo As String, ByVal xasiento As String) As Boolean
        Dim resultado As Boolean

        resultado = Datos.RegistrarPasajeros(xnumeroPasajero, xcodigoReserva, xpasajeroNombre, xpasajeroApellido, xpasajeroPasaporte, xpasajeroCorreo, xasiento)

        Return resultado
    End Function
End Class
