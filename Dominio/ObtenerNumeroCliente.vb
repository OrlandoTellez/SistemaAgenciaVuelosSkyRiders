Imports Datos
Public Class ObtenerNumeroCliente
    Public obtenerNumero As New Datos.ObtenerNumeroCliente()

    Public Function GenerarNuevoCodigo() As String
        Dim ultimoCodigo As String = obtenerNumero.ObtenerUltimoNumeroCliente()
        Dim prefijo As String = "A"
        Dim numero As Integer = 0

        If Not String.IsNullOrEmpty(ultimoCodigo) AndAlso ultimoCodigo.StartsWith(prefijo) Then
            numero = Integer.Parse(ultimoCodigo.Substring(1))
        End If

        Dim nuevoCodigo As String = prefijo & (numero + 1).ToString("D3")
        Return nuevoCodigo
    End Function
End Class
