Imports System.Data.SqlClient

Public Class RegistrarPasajeros
    Inherits conexion
    Protected cmd As SqlCommand
    Protected dr As SqlDataReader
    Public Function RegistrarPasajeros(ByVal xnumeroPasajero As String, ByVal xcodigoReserva As String, ByVal xpasajeroNombre As String, ByVal xpasajeroApellido As String, ByVal xpasajeroPasaporte As String, ByVal xpasajeroCorreo As String, ByVal xasiento As String) As Boolean
        'VARIABLES DE PASAJEROS
        'Public Shared numeroDePasajero As Integer
        'Public Shared pasajeroNombre As String
        'Public Shared pasajeroApellido As String
        'Public Shared pasajeroPasaporte As String
        'Public Shared pasajeroCorreo As String
        'Public Shared asiento As String

        Try
            If Not Conectado() Then
                MsgBox("No se pudo conectar a la base de datos.")
                Return False
            End If

            cmd = New SqlCommand("RegistrarPasajeros")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@numeroPasajeros", xnumeroPasajero)
            cmd.Parameters.AddWithValue("@codigoReserva", xcodigoReserva)

            cmd.Parameters.AddWithValue("@pasajeroNombre", xpasajeroNombre)
            cmd.Parameters.AddWithValue("@pasajeroApellido", xpasajeroApellido)
            cmd.Parameters.AddWithValue("@pasajeroPasaporte", xpasajeroPasaporte)
            cmd.Parameters.AddWithValue("@pasajeroCorreo", xpasajeroCorreo)
            cmd.Parameters.AddWithValue("@asiento", xasiento)




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
