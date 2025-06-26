Imports Dominio

Public Class frmReservarHotel
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim hotelesDisponibles As New HotelesDisponibles()
        VariablesPublicas.pasajeroCorreo = txtCorreo.Text
        VariablesPublicas.HotelFechaEntrada = dtpFechaEntrada.Value.Date
        VariablesPublicas.HotelFechaSalido = dtpFechaSalida.Value.Date
        hotelesDisponibles.Show()
    End Sub

End Class