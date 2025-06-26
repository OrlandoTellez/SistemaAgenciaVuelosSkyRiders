Imports System.Data
Imports System.Data.SqlClient

Public Class IniciarSesion
    Inherits conexion
    Protected cmd As SqlCommand
    Protected dr As SqlDataReader

    Public Function ConfirmarSesion(ByVal xcodigo As String, ByVal xpass As String) As Boolean
        Try
            If Not Conectado() Then
                MsgBox("No se pudo conectar a la base de datos.")
                Return False
            End If

            cmd = New SqlCommand("VerificarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@NombreUsuario", xcodigo)
            cmd.Parameters.AddWithValue("@Password", xpass)

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            If dr IsNot Nothing Then
                dr.Close()
            End If

            Desconectado()
        End Try
    End Function
End Class

