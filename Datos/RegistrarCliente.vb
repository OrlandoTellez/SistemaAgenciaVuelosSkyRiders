Imports System.Data.SqlClient
Public Class RegistrarCliente
    Inherits conexion
    Protected cmd As SqlCommand
    Protected dr As SqlDataReader
    Public Function RegistrarCliente(ByVal xnumeroCliente As String, ByVal xclienteNombre As String, ByVal xclienteApellido As String, ByVal xclienteTelefono As String) As Boolean
        'Public Shared numeroCliente As Long
        'Public Shared ClienteNombre As String
        'Public Shared ClienteApellido As String
        'Public Shared ClienteCorreo As String
        'Public Shared ClienteTelefono As String

        Try
            If Not Conectado() Then
                MsgBox("No se pudo conectar a la base de datos.")
                Return False
            End If

            cmd = New SqlCommand("RegistrarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@numeroCliente", xnumeroCliente)
            cmd.Parameters.AddWithValue("@clienteNombre", xclienteNombre)
            cmd.Parameters.AddWithValue("@clienteApellido", xclienteApellido)
            cmd.Parameters.AddWithValue("@clienteTelefono", xclienteTelefono)


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
