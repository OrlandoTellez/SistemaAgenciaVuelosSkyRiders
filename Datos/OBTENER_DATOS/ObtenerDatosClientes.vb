Imports System.Data.SqlClient

Public Class ObtenerDatosClientes
    Inherits conexion

    Public Function ObtenerDatosCliente(ByVal numeroCliente As String) As DataTable
        Dim tablaCliente As New DATASETCAPADATOS.dtClienteDataTable()

        If Conectado() Then
            Try
                Dim query As String = "SELECT * FROM clientes WHERE numeroCliente = @numeroCliente"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@numeroCliente", numeroCliente)

                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(tablaCliente)
            Catch ex As Exception
                MessageBox.Show("Error al obtener los datos del cliente: " & ex.Message)
            Finally
                Desconectado()
            End Try
        End If

        Return tablaCliente
    End Function
End Class
