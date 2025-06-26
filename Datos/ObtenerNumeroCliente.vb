Imports System.Data.SqlClient
Imports Datos

Public Class ObtenerNumeroCliente
    Inherits conexion
    Public Function ObtenerUltimoNumeroCliente() As String
        Dim ultimoCodigo As String = "A000"
        If Conectado() Then
            Try
                Dim query As String = "SELECT TOP 1 numeroCliente FROM clientes ORDER BY numeroCliente DESC"
                Dim command As New SqlCommand(query, connection)
                Dim resultado = command.ExecuteScalar()
                If resultado IsNot Nothing Then
                    ultimoCodigo = resultado.ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener el último número de cliente: " & ex.Message)
            Finally
                Desconectado()
            End Try
        End If
        Return ultimoCodigo
    End Function
End Class
