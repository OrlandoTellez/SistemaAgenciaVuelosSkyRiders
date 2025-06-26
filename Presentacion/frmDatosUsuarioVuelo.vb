Imports Dominio
Imports System.Net
Imports System.Net.Mail

Public Class frmDatosUsuarioVuelo
    Dim generarCodigoPasajero As New ObtenerNumeroPasajero()
    Dim tickets As String = VariablesPublicas.cantidadPasajeros

    Private Sub frmDatosUsuarioVuelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGridCliente.DataSource = VariablesPublicas.dataTablePasajeros
        btnComprar.Enabled = False

        lblTickets.Text = tickets


    End Sub
    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim pasarelaDePago As New PasarelaDePago()

        pasarelaDePago.Show()
        Me.Close()
    End Sub
    Public Sub DatosDelCliente()
        Dim registrarPasajeros As New RegistrarPasajeros()

        VariablesPublicas.numeroDePasajero = generarCodigoPasajero.GenerarNuevoCodigo()
        VariablesPublicas.pasajeroNombre = txtNombre.Text
        VariablesPublicas.pasajeroApellido = txtApellido.Text
        VariablesPublicas.pasajeroPasaporte = txtPasaporte.Text
        VariablesPublicas.pasajeroCorreo = txtCorreo.Text
        VariablesPublicas.asiento = "Ab3"

        VariablesPublicas.filaPasajeros = VariablesPublicas.dataTablePasajeros.NewdtPasajerosRow
        VariablesPublicas.filaPasajeros.numeroPasajero = VariablesPublicas.numeroDePasajero
        VariablesPublicas.filaPasajeros.pasajeroNombre = txtNombre.Text
        VariablesPublicas.filaPasajeros.pasajeroApellido = txtApellido.Text
        VariablesPublicas.filaPasajeros.pasajeroPasaporte = txtPasaporte.Text
        VariablesPublicas.filaPasajeros.pasajeroCorreo = txtCorreo.Text
        VariablesPublicas.filaPasajeros.asiento = VariablesPublicas.asiento
        VariablesPublicas.filaPasajeros.codigoReserva = VariablesPublicas.codigoReserva

        VariablesPublicas.dataTablePasajeros.AdddtPasajerosRow(VariablesPublicas.filaPasajeros)
        VariablesPublicas.dataTablePasajeros.AcceptChanges()



        Dim registro = registrarPasajeros.RegistrarPasajeros(VariablesPublicas.numeroDePasajero, VariablesPublicas.codigoReserva, VariablesPublicas.pasajeroNombre, VariablesPublicas.pasajeroApellido, VariablesPublicas.pasajeroPasaporte, VariablesPublicas.pasajeroCorreo, VariablesPublicas.asiento)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click



        If String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtApellido.Text) Or String.IsNullOrWhiteSpace(txtPasaporte.Text) Or String.IsNullOrWhiteSpace(txtCorreo.Text) Then
            MessageBox.Show("Todos lso campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            DatosDelCliente()
            If tickets > 0 Then
                tickets = tickets - 1
                lblTickets.Text = tickets
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtPasaporte.Text = ""

            End If

            If tickets = 0 Then
                btnComprar.Enabled = True
                btnGuardar.Enabled = False
                txtNombre.Enabled = False
                txtApellido.Enabled = False
                txtPasaporte.Enabled = False
            End If

            txtCorreo.Enabled = False
        End If





    End Sub
End Class