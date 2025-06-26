Imports System.Data.SqlClient

Public Class RegistrarVuelo
    Inherits conexion
    Protected cmd As SqlCommand
    Protected dr As SqlDataReader
    Public Function RegistrarVuelo(ByVal xnumeroVuelo As String, ByVal xOrigen As String, ByVal xDestino As String, ByVal xfechaSalida As DateTime, ByVal xfechaLlegada As DateTime, ByVal xhoraSalida As TimeSpan, ByVal xhoraLlegada As TimeSpan, ByVal xclase As String) As Boolean

        ' VARIABLES DE VUELOS
        'Public Shared numeroVuelo As String
        'Public Shared Origen As String
        'Public Shared Destino As String
        'Public Shared FechaSalida As DateTime
        'Public Shared FechaLlegada As DateTime
        'Public Shared HoraSalida As TimeZone
        'Public Shared horaLlegada As TimeZone
        'Public Shared Clase As String

        Try
            If Not Conectado() Then
                MsgBox("No se pudo conectar a la base de datos.")
                Return False
            End If

            cmd = New SqlCommand("RegistrarVuelo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@numeroVuelo", xnumeroVuelo)
            cmd.Parameters.AddWithValue("@Origen", xOrigen)
            cmd.Parameters.AddWithValue("@Destino", xDestino)
            cmd.Parameters.AddWithValue("@FechaSalida", xfechaSalida)
            cmd.Parameters.AddWithValue("@FechaLlegada", xfechaLlegada)
            cmd.Parameters.AddWithValue("@HoraSalida", xhoraSalida)
            cmd.Parameters.AddWithValue("@HoraLlegada", xhoraLlegada)
            cmd.Parameters.AddWithValue("@Clase", xclase)


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
