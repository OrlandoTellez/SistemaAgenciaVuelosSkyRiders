Imports Dominio

Public Class frmReservarVehiculo
    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim formBuscarAuto As New AutosDisponibles()
        VariablesPublicas.pasajeroCorreo = txtCorreo.Text
        VariablesPublicas.CarroFechaDeUso = dtpFechaUso.Value.Date
        VariablesPublicas.CarroFechaDeDevolucion = dtpFechaDevolucion.Value.Date
        formBuscarAuto.Show()

    End Sub

End Class