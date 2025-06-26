Imports Dominio
Public Class VuelosDisponibles
    Dim variablesPublicas As New VariablesPublicas()
    Dim generarCodigoReserva As New ObtenerNumeroReserva()
    Public Sub guardarDatosVueloNumero1()
        Dim registrarVuelos As New RegistrarVuelo()
        Dim registrarReserva As New RegistrarReserva()
        VariablesPublicas.codigoReserva = generarCodigoReserva.GenerarNuevoCodigo()
        VariablesPublicas.HoraSalida = New TimeSpan(8, 0, 0)
        VariablesPublicas.horaLlegada = New TimeSpan(1, 0, 0)
        Dim registroVuelo = registrarVuelos.RegistrarVuelo(VariablesPublicas.numeroVuelo, VariablesPublicas.Origen, VariablesPublicas.Destino, VariablesPublicas.FechaSalida, VariablesPublicas.FechaSalida, VariablesPublicas.HoraSalida, VariablesPublicas.horaLlegada, VariablesPublicas.Clase)

        Dim registro = registrarReserva.RegistrarReserva(VariablesPublicas.codigoReserva, VariablesPublicas.numeroCliente, VariablesPublicas.numeroVuelo, VariablesPublicas.fechaReserva, VariablesPublicas.cantidadPasajeros)

    End Sub

    Public Sub guardarDatosVueloNumero2()
        Dim registrarVuelos As New RegistrarVuelo()
        Dim registrarReserva As New RegistrarReserva()
        VariablesPublicas.codigoReserva = generarCodigoReserva.GenerarNuevoCodigo()
        VariablesPublicas.Clase = "Economica"
        VariablesPublicas.Precio = 100
        VariablesPublicas.HoraSalida = New TimeSpan(12, 0, 0)
        VariablesPublicas.horaLlegada = New TimeSpan(4, 0, 0)
        Dim registroVuelo = registrarVuelos.RegistrarVuelo(VariablesPublicas.numeroVuelo, VariablesPublicas.Origen, VariablesPublicas.Destino, VariablesPublicas.FechaSalida, VariablesPublicas.FechaSalida, VariablesPublicas.HoraSalida, VariablesPublicas.horaLlegada, VariablesPublicas.Clase)

        Dim registro = registrarReserva.RegistrarReserva(VariablesPublicas.codigoReserva, VariablesPublicas.numeroCliente, VariablesPublicas.numeroVuelo, VariablesPublicas.fechaReserva, VariablesPublicas.cantidadPasajeros)

    End Sub



    Public Sub guardarDatosVueloNumero3()
        Dim registrarVuelos As New RegistrarVuelo()
        Dim registrarReserva As New RegistrarReserva()
        VariablesPublicas.codigoReserva = generarCodigoReserva.GenerarNuevoCodigo()
        VariablesPublicas.Clase = "Primera Clase"
        VariablesPublicas.Precio = 500
        VariablesPublicas.HoraSalida = New TimeSpan(2, 0, 0)
        VariablesPublicas.horaLlegada = New TimeSpan(6, 0, 0)
        Dim registroVuelo = registrarVuelos.RegistrarVuelo(VariablesPublicas.numeroVuelo, VariablesPublicas.Origen, VariablesPublicas.Destino, VariablesPublicas.FechaSalida, VariablesPublicas.FechaSalida, VariablesPublicas.HoraSalida, VariablesPublicas.horaLlegada, VariablesPublicas.Clase)

        Dim registro = registrarReserva.RegistrarReserva(VariablesPublicas.codigoReserva, VariablesPublicas.numeroCliente, VariablesPublicas.numeroVuelo, VariablesPublicas.fechaReserva, VariablesPublicas.cantidadPasajeros)
    End Sub

    Private Sub btnAgendarVuelo_Click(sender As Object, e As EventArgs) Handles btnAgendarVuelo.Click
        Dim confirmarVuelo As New frmDatosUsuarioVuelo()
        guardarDatosVueloNumero1()
        confirmarVuelo.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgendarVuelo2_Click(sender As Object, e As EventArgs) Handles btnAgendarVuelo2.Click
        Dim confirmarVuelo As New frmDatosUsuarioVuelo()
        guardarDatosVueloNumero2()
        confirmarVuelo.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgendarVuelo3_Click(sender As Object, e As EventArgs) Handles btnAgendarVuelo3.Click
        Dim confirmarVuelo As New frmDatosUsuarioVuelo()
        guardarDatosVueloNumero3()
        confirmarVuelo.Show()
        Me.Hide()
    End Sub

    Private Sub VuelosDisponibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOrigen.Text = VariablesPublicas.Origen
        lblDestino.Text = VariablesPublicas.Destino
        lblClase.Text = VariablesPublicas.Clase
        lblPrecio.Text = VariablesPublicas.Precio.ToString()

        lblOrigen2.Text = VariablesPublicas.Origen

        lblDestino2.Text = VariablesPublicas.Destino
        lblOrigen3.Text = VariablesPublicas.Origen

        lblDestino3.Text = VariablesPublicas.Destino


    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub


End Class