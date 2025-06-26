Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration

Public Class conexion

    Private connectionString As String
    Protected connection As SqlConnection


    Public Sub New()
        Dim connString As String = "Data Source=localhost;Initial Catalog=BaseDeDatosAgenciaVuelosSkyRiders;Integrated Security=True"


        If String.IsNullOrEmpty(connString) Then
            Throw New Exception("La cadena de conexión 'cxn' no está configurada correctamente en el archivo de configuración.")
        End If

        connectionString = connString
        connection = New SqlConnection(connectionString)
    End Sub

    Protected Function Conectado() As Boolean
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            Return False
        End Try
    End Function

    Protected Function Desconectado() As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al desconectar de la base de datos: " & ex.Message)
            Return False
        End Try

    End Function
End Class
