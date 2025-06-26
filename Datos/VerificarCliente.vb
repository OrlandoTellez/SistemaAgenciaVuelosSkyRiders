Imports System.Data.SqlClient

Public Class VerificarCliente
    Inherits conexion
    Protected cmd As SqlCommand

    ' Método para verificar usuario y contraseña y obtener el número de cliente
    Public Function ObtenerNumeroCliente(ByVal xusuario As String, ByVal xpassword As String) As String
        Try
            If Not Conectado() Then
                MsgBox("No se pudo conectar a la base de datos.")
                Return Nothing
            End If

            cmd = New SqlCommand("VerificarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection

            ' Agregar parámetros al procedimiento almacenado
            cmd.Parameters.AddWithValue("@usuario", xusuario)
            cmd.Parameters.AddWithValue("@password", xpassword)

            ' Ejecutar la consulta y obtener el resultado
            Dim result As Object = cmd.ExecuteScalar()

            ' Verificar si se obtuvo un resultado válido
            If result IsNot Nothing Then
                Return result.ToString()
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function
End Class