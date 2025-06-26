Imports System.Data.SqlClient

Public Class ObtenerDatosUsuario
    Inherits conexion

    Public Function ObtenerDatosUsuario(ByVal numeroCliente As String) As DataTable
        Dim tablaUsuario As New DATASETCAPADATOS.dtUsuarioDataTable()

        If Conectado() Then
            Try
                Dim query As String = "SELECT correoUsuario FROM usuario WHERE numeroCliente = @numeroCliente"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@numeroCliente", numeroCliente)

                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(tablaUsuario)
            Catch ex As Exception
                MessageBox.Show("Error al obtener los datos del cliente: " & ex.Message)
            Finally
                Desconectado()
            End Try
        End If

        Return tablaUsuario
    End Function
End Class
