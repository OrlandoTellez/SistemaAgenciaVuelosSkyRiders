Imports System.Data.SqlClient

Public Class RegistrarPagos
    Inherits conexion
    Protected cmd As SqlCommand
    Protected dr As SqlDataReader
    Public Function RegistrarPagos(ByVal xcodigoReserva As String, ByVal xmetodoPago As String, ByVal xtarjeta As String, ByVal xmontoTotal As String) As Boolean

        Try
            If Not Conectado() Then
                MsgBox("No se pudo conectar a la base de datos.")
                Return False
            End If

            cmd = New SqlCommand("RegistrarPagos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@codigoReserva", xcodigoReserva)
            cmd.Parameters.AddWithValue("@metodoPago", xmetodoPago)
            cmd.Parameters.AddWithValue("@tarjeta", xtarjeta)
            cmd.Parameters.AddWithValue("@montoTotal", xmontoTotal)

            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException When ex.Number = 50000
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
End Class
