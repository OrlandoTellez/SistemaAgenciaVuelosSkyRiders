Imports Dominio

Public Class EscogerCantidadPasajeros

    Dim generarNumeroVuelo As New ObtenerNumeroVuelo()
    Dim generarCodigoReservas As New ObtenerNumeroReserva()
    Dim RegistrarVuelo As New RegistrarVuelo()
    Dim RegistrarReserva As New RegistrarReserva()

    Public Sub guardarDatos()
        VariablesPublicas.numeroVuelo = generarNumeroVuelo.GenerarNuevoCodigo()
        VariablesPublicas.codigoReserva = generarCodigoReservas.GenerarNuevoCodigo()
        VariablesPublicas.cantidadPasajeros = NumericUpDown1.Value

        'Dim registro = RegistrarVuelo.RegistrarVuelo(VariablesPublicas.numeroVuelo, VariablesPublicas.Origen, VariablesPublicas.Destino, VariablesPublicas.FechaSalida, VariablesPublicas.FechaLlegada, VariablesPublicas.HoraSalida, VariablesPublicas.horaLlegada, VariablesPublicas.Clase)
        'Dim registroReserva = RegistrarReserva.RegistrarReserva(VariablesPublicas.codigoReserva, VariablesPublicas.numeroCliente, VariablesPublicas.numeroVuelo, VariablesPublicas.fechaReserva, VariablesPublicas.cantidadPasajeros)

    End Sub
    Private Sub btnComprarBoletos_Click(sender As Object, e As EventArgs) Handles btnComprarBoletos.Click
        Dim vuelosDisponibles As New VuelosDisponibles()
        guardarDatos()

        vuelosDisponibles.Show()
        Me.Hide()
    End Sub


End Class