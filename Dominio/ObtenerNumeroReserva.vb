Imports Datos
Public Class ObtenerNumeroReserva
    Public obtenerNumero As New Datos.ObtenerNumeroReserva()

    Public Function GenerarNuevoCodigo() As String
        Dim ultimoCodigo As String = obtenerNumero.ObtenerUltimoNumeroReserva()
        Dim prefijo As String = "R"
        Dim numero As Integer = 0

        If Not String.IsNullOrEmpty(ultimoCodigo) AndAlso ultimoCodigo.StartsWith(prefijo) Then
            numero = Integer.Parse(ultimoCodigo.Substring(1))
        End If

        Dim nuevoCodigo As String = prefijo & (numero + 1).ToString("D3")
        Return nuevoCodigo
    End Function
End Class
