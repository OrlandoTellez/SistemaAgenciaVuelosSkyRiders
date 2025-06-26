Imports System.Data.SqlClient
Public Class ObtenerNumeroReserva
    Inherits conexion
    Public Function ObtenerUltimoNumeroReserva() As String
        Dim ultimoCodigo As String = "R000"
        If Conectado() Then
            Try
                Dim query As String = "SELECT TOP 1 codigoReserva FROM reservas ORDER BY codigoReserva DESC;"
                Dim command As New SqlCommand(query, connection)
                Dim resultado = command.ExecuteScalar()
                If resultado IsNot Nothing Then
                    ultimoCodigo = resultado.ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener el último número de reserva: " & ex.Message)
            Finally
                Desconectado()
            End Try
        End If
        Return ultimoCodigo
    End Function
End Class
