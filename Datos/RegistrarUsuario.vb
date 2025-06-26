Imports System.Data.SqlClient

Public Class RegistrarUsuario
    Inherits conexion
    Protected cmd As SqlCommand
    Protected dr As SqlDataReader
    Public Function RegistrarUsuario(ByVal xnumeroCliente As String, ByVal xnombre As String, ByVal xcorreoUsuario As String, ByVal xpassword As String) As Boolean
        Try
            If Not Conectado() Then
                MsgBox("No se pudo conectar a la base de datos.")
                Return False
            End If

            cmd = New SqlCommand("RegistrarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@numeroCliente", xnumeroCliente)
            cmd.Parameters.AddWithValue("@nombre", xnombre)
            cmd.Parameters.AddWithValue("@correoUsuario", xcorreoUsuario)
            cmd.Parameters.AddWithValue("@password", xpassword)


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
