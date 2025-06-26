Public Class DatosSubidosExitosamente
    Private Sub btnReservarHotel_Click(sender As Object, e As EventArgs) Handles btnReservarHotel.Click
        Dim reservarHotel As New frmReservarHotel()
        reservarHotel.Show()
        Me.Close()

    End Sub

    Private Sub btnReservarAuto_Click(sender As Object, e As EventArgs) Handles btnReservarAuto.Click
        Dim reservarAuto As New frmReservarVehiculo()
        reservarAuto.Show()
        Me.Close()
    End Sub
End Class