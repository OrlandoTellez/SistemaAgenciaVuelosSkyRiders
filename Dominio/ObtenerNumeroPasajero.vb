Public Class ObtenerNumeroPasajero
    Public obtenerNumero As New Datos.ObtenerNumeroPasajero()

    Public Function GenerarNuevoCodigo() As String
        Dim ultimoCodigo As String = obtenerNumero.ObtenerUltimoNumeroPasajero()
        Dim prefijo As String = "P"
        Dim numero As Integer = 0

        If Not String.IsNullOrEmpty(ultimoCodigo) AndAlso ultimoCodigo.StartsWith(prefijo) Then
            numero = Integer.Parse(ultimoCodigo.Substring(1))
        End If

        Dim nuevoCodigo As String = prefijo & (numero + 1).ToString("D3")
        Return nuevoCodigo
    End Function
End Class

