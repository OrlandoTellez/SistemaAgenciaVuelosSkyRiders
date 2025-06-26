Imports System.ComponentModel
Imports Datos

Public Class VariablesPublicas
    'DATASET
    Public Shared dataTableCliente As New DATASETAGENCIAVUELOS.dtClienteDataTable
    Public Shared fila As DATASETAGENCIAVUELOS.dtClienteRow

    Public Shared dataTablePasajeros As New DATASETAGENCIAVUELOS.dtPasajerosDataTable
    Public Shared filaPasajeros As DATASETAGENCIAVUELOS.dtPasajerosRow



    ' VARIABLES DE CLIENTES
    Public Shared numeroCliente As String
    Public Shared ClienteNombre As String
    Public Shared ClienteApellido As String
    Public Shared ClienteCorreo As String
    Public Shared ClienteTelefono As String

    ' VARIABLES DE VUELOS
    Public Shared numeroVuelo As String
    Public Shared Origen As String
    Public Shared Destino As String
    Public Shared FechaSalida As Date
    Public Shared FechaLlegada As Date
    Public Shared HoraSalida As TimeSpan
    Public Shared horaLlegada As TimeSpan
    Public Shared Clase As String

    'VARIABLES DE RESERVA
    Public Shared codigoReserva As String
    Public Shared fechaReserva As Date
    Public Shared cantidadPasajeros As Integer = 0

    'VARIABLES DE PASAJEROS
    Public Shared numeroDePasajero As String
    Public Shared pasajeroNombre As String
    Public Shared pasajeroApellido As String
    Public Shared pasajeroPasaporte As String
    Public Shared pasajeroCorreo As String
    Public Shared asiento As String

    'VARIABLES DE PAGOS
    Public Shared metodoPago As String
    Public Shared tarjeta As String
    Public Shared Precio As Decimal
    Public Shared precioTotal As Decimal = Precio * cantidadPasajeros

    'Hoteles

    Public Shared HotelNombre As String
    Public Shared HotelCliente As String
    Public Shared HotelFechaEntrada As String
    Public Shared HotelFechaSalido As String
    Public Shared HotelDescripcion As String
    Public Shared HotelCalificacion As String
    Public Shared HotelPrecio As Decimal


    'Carros
    Public Shared CarroModelo As String
    Public Shared CarroPlaca As String
    Public Shared CarroCliente As String
    Public Shared CarroFechaDeUso As String
    Public Shared CarroFechaDeDevolucion As String
    Public Shared CarroDescripcion As String
    Public Shared CarroPrecio As Decimal


    'Codigo confirmacion
    Public Shared codigoConfirmacion As String
End Class
