Public Class RegistrarVuelo
    Dim Datos As New Datos.RegistrarVuelo()
    Public Function RegistrarVuelo(ByVal xnumeroVuelo As String, ByVal xOrigen As String, ByVal xDestino As String, ByVal xfechaSalida As DateTime, ByVal xfechaLlegada As DateTime, ByVal xhoraSalida As TimeSpan, ByVal xhoraLlegada As TimeSpan, ByVal xclase As String) As Boolean
        Dim resultado As Boolean

        resultado = Datos.RegistrarVuelo(xnumeroVuelo, xOrigen, xDestino, xfechaSalida, xfechaLlegada, xhoraSalida, xhoraLlegada, xclase)

        Return resultado
    End Function
End Class
