Imports System.Data.SqlClient
Public Class ObtenerNumeroPasajero
    Inherits conexion
    Public Function ObtenerUltimoNumeroPasajero() As String
        Dim ultimoCodigo As String = "P000"
        If Conectado() Then
            Try
                Dim query As String = "SELECT TOP 1 numeroPasajero FROM pasajeros ORDER BY numeroPasajero DESC"
                Dim command As New SqlCommand(query, connection)
                Dim resultado = command.ExecuteScalar()
                If resultado IsNot Nothing Then
                    ultimoCodigo = resultado.ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener el último número de pasajero: " & ex.Message)
            Finally
                Desconectado()
            End Try
        End If
        Return ultimoCodigo
    End Function
End Class