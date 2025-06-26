Imports Dominio

Public Class PerfilDelCliente


    Private Sub PerfilDelCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obtenerDatos As New ObtenerDatosUsuario()

        Dim numeroCliente As String = VariablesPublicas.numeroCliente

        Dim dt As DataTable = obtenerDatos.ObtenerDatosUsuario(numeroCliente)


        lblNombre.Text = VariablesPublicas.ClienteNombre + " " + VariablesPublicas.ClienteApellido
        lblTelefono.Text = VariablesPublicas.ClienteTelefono

        If dt.Rows.Count > 0 Then
            Dim fila As DataRow = dt.Rows(0)
            lblCorreo.Text = fila("correoUsuario").ToString()
        Else
            MessageBox.Show("No se encontraron datos para el cliente especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class