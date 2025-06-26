Imports Dominio

Public Class frmReservarVuelos
    Dim generarNumeroVuelo As New ObtenerNumeroVuelo

    Public Sub guardarDatos()
        VariablesPublicas.fechaReserva = Date.Today
        VariablesPublicas.numeroVuelo = generarNumeroVuelo.GenerarNuevoCodigo()

        VariablesPublicas.Origen = cbOrigen.SelectedItem.ToString()
        VariablesPublicas.Destino = cbDestino.SelectedItem.ToString()
        VariablesPublicas.Clase = cbClase.SelectedItem.ToString()
        VariablesPublicas.cantidadPasajeros = nupPasajeros.Value
        VariablesPublicas.FechaSalida = dtpFecha.Value.Date
        If cbClase.SelectedIndex = 0 Then
            VariablesPublicas.Precio = 100
        ElseIf cbClase.SelectedIndex = 1 Then
            VariablesPublicas.Precio = 200
        ElseIf cbClase.SelectedIndex = 2 Then
            VariablesPublicas.Precio = 500
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim vuelosDisponibles As New VuelosDisponibles()

        If cbOrigen.SelectedIndex = -1 Or cbDestino.SelectedIndex = -1 Or cbClase.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        guardarDatos()
        vuelosDisponibles.Show()

    End Sub

    Private Sub frmReservarVuelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class