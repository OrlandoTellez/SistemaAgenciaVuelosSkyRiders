Imports System.Data.SqlClient

Public Class ObtenerDatosReservacionVuelo
    Inherits conexion

    Public Function ObtenerDatosReservacionVuelo(ByVal numeroCliente As String) As DataTable
        Dim tablaReservacionVuelo As New DATASETCAPADATOS.dtTablaRevervacionDataTable()

        If Conectado() Then
            Try
                Dim query As String = "SELECT r.codigoReserva, c.numeroCliente, c.nombre AS nombreCliente, 
                           c.apellido AS apellidoCliente, v.numeroVuelo, v.origen, 
                           v.destino, v.fechaSalida, v.fechaLlegada, v.horaSalida, 
                           v.horaLlegada, p.numeroPasajero, p.nombrePasajero, 
                           p.apellidoPasajero, p.pasaportePasajero, p.correoPasajero, 
                           p.asiento 
                           FROM reservas r 
                           JOIN clientes c ON r.numeroCliente = c.numeroCliente 
                           JOIN vuelos v ON r.numeroVuelo = v.numeroVuelo 
                           JOIN pasajeros p ON r.codigoReserva = p.codigoReserva 
                           WHERE c.numeroCliente = @numeroCliente"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@numeroCliente", numeroCliente)

                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(tablaReservacionVuelo)
            Catch ex As Exception
                MessageBox.Show("Error al obtener los datos del cliente: " & ex.Message)
            Finally
                Desconectado()
            End Try
        End If

        Return tablaReservacionVuelo
    End Function
End Class
