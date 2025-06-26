Imports Dominio
Public Class VerReservas
    Private Sub VerReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obtenerDatos As New ObtenerDatosReservacionVuelo()

        Dim numeroCliente As String = VariablesPublicas.numeroCliente
        Dim dt As DataTable = obtenerDatos.ObtenerDatosReserva(numeroCliente)

        If dt.Rows.Count > 0 Then
            VerReservar.DataSource = dt
        Else
            MessageBox.Show("No se encontraron datos para el cliente especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class