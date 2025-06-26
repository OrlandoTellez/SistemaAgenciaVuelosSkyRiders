Imports System.Data.SqlClient

Public Class RegistrarReserva
    Inherits conexion
    Protected cmd As SqlCommand
    Protected dr As SqlDataReader
    Public Function RegistrarReserva(ByVal xcodigoReserva As String, ByVal xnumeroCliente As String, ByVal xnumeroVuelo As String, ByVal xfechaReserva As Date, ByVal xcantidadPasajero As Integer) As Boolean
        Try
            If Not Conectado() Then
                MsgBox("No se pudo conectar a la base de datos.")
                Return False
            End If

            cmd = New SqlCommand("RegistrarReserva")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@codigoReserva", xcodigoReserva)
            cmd.Parameters.AddWithValue("@numeroCliente", xnumeroCliente)
            cmd.Parameters.AddWithValue("@numeroVuelo", xnumeroVuelo)
            cmd.Parameters.AddWithValue("@fechaReserva", xfechaReserva)
            cmd.Parameters.AddWithValue("@cantidadPasajeros", xcantidadPasajero)



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
