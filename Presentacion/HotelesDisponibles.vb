Imports Dominio
Public Class HotelesDisponibles

    Private Sub btnHotel1_Click(sender As Object, e As EventArgs) Handles btnHotel1.Click
        Dim pasarelapago As New PasarelaDePagoHoteles()


        VariablesPublicas.HotelNombre = "Hotel Buena vida"
        VariablesPublicas.HotelCliente = VariablesPublicas.ClienteNombre
        VariablesPublicas.HotelPrecio = 100
        VariablesPublicas.HotelDescripcion = "Buena vista al mar, wifi gratis"
        VariablesPublicas.HotelCalificacion = "4.5 estrellas"

        pasarelapago.Show()
        Me.Hide()

    End Sub

    Private Sub btnHotel2_Click(sender As Object, e As EventArgs) Handles btnHotel2.Click
        Dim pasarelapago As New PasarelaDePagoHoteles()

        VariablesPublicas.HotelNombre = "Hotel pasion de gavilan"
        VariablesPublicas.HotelCliente = VariablesPublicas.ClienteNombre
        VariablesPublicas.HotelPrecio = 500
        VariablesPublicas.HotelDescripcion = "Hotel ubicado en zona centrica"
        VariablesPublicas.HotelCalificacion = "2.5 estrellas"

        pasarelapago.Show()
        Me.Hide()
    End Sub

    Private Sub btnHotel3_Click(sender As Object, e As EventArgs) Handles btnHotel3.Click
        Dim pasarelapago As New PasarelaDePagoHoteles()

        VariablesPublicas.HotelNombre = "Hotel amores verdaderos"
        VariablesPublicas.HotelCliente = VariablesPublicas.ClienteNombre
        VariablesPublicas.HotelPrecio = 750
        VariablesPublicas.HotelDescripcion = "Hotel exclusivo "
        VariablesPublicas.HotelCalificacion = "4 estrellas"

        pasarelapago.Show()
        Me.Hide()

    End Sub


End Class