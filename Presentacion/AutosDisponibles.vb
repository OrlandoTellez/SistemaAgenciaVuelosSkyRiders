Imports Dominio

Public Class AutosDisponibles
    Private Sub btnAuto1_Click(sender As Object, e As EventArgs) Handles btnAuto1.Click
        Dim pasarelaPago As New PasarelaDePagosVehiculo()
        VariablesPublicas.CarroModelo = "Toyota corolla"
        VariablesPublicas.CarroCliente = VariablesPublicas.ClienteNombre
        VariablesPublicas.CarroPlaca = "M-234-1234"
        VariablesPublicas.CarroDescripcion = "Lujo, Automatico"
        VariablesPublicas.CarroPrecio = 200

        pasarelaPago.Show()
        Me.Hide()

    End Sub

    Private Sub btnAuto2_Click(sender As Object, e As EventArgs) Handles btnAuto2.Click
        Dim pasarelaPago As New PasarelaDePagosVehiculo()
        VariablesPublicas.CarroModelo = "Toyota Agya"
        VariablesPublicas.CarroCliente = VariablesPublicas.ClienteNombre
        VariablesPublicas.CarroPlaca = "A-234-1234"
        VariablesPublicas.CarroDescripcion = "Economico, Automatico"
        VariablesPublicas.CarroPrecio = 100

        pasarelaPago.Show()
        Me.Hide()

    End Sub

    Private Sub btnAuto3_Click(sender As Object, e As EventArgs) Handles btnAuto3.Click
        Dim pasarelaPago As New PasarelaDePagosVehiculo()
        VariablesPublicas.CarroModelo = "Toyota Susuki"
        VariablesPublicas.CarroCliente = VariablesPublicas.ClienteNombre
        VariablesPublicas.CarroPlaca = "A-234-1234"
        VariablesPublicas.CarroDescripcion = "Barato, Mecanico "
        VariablesPublicas.CarroPrecio = 25

        pasarelaPago.Show()
        Me.Hide()


    End Sub


End Class