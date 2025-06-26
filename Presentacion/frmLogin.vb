Imports Dominio

Public Class frmLogin
    Private dominioCliente As New ObtenerDatosClientes()

    Private Sub btnEntrar_Click_3(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim xacceder As New IniciarSesion()
        Dim xaccederNumero As New VerificarCliente()
        Dim formularioMenu As Papumenu = New Papumenu()
        Dim entro As Boolean
        Dim numeroCliente As String

        Dim xusuario As String
        Dim xpass As String
        xusuario = txtUsuario.Text
        xpass = txtContrasena.Text

        entro = xacceder.AccederSistema(xusuario, xpass)
        numeroCliente = xaccederNumero.ObtenerNumeroCliente(xusuario, xpass)


        If entro Then

            VariablesPublicas.numeroCliente = numeroCliente

            If String.IsNullOrWhiteSpace(numeroCliente) Then
                MessageBox.Show("Por favor, ingrese un número de cliente válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim tablaCliente As DataTable = dominioCliente.ObtenerDatosDelCliente(numeroCliente)

            If tablaCliente.Rows.Count > 0 Then
                Dim fila As DataRow = tablaCliente.Rows(0)

                VariablesPublicas.ClienteNombre = fila("nombre").ToString()
                VariablesPublicas.ClienteApellido = fila("apellido").ToString()
                VariablesPublicas.ClienteTelefono = fila("telefono").ToString()

            Else
                MessageBox.Show("No se encontraron datos para el cliente con el número " & numeroCliente & ".")
            End If
            formularioMenu.Show()
            Me.Hide()
        Else
            MsgBox("Ni para introducir una contraseña llegas a servir, @borrando System.32@")
        End If
    End Sub



    Private Sub btnsalir_Click_1(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim principal As New PaginaPrincipalDeInicio()
        principal.Show()
        Me.Close()
    End Sub
End Class