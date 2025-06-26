Imports System.Net
Imports System.Net.Mail
Imports Dominio
Public Class frmRegistro
    Dim generarCodidgoCliente As New ObtenerNumeroCliente()
    Public Sub DatosDelCliente()
        Dim registrarCliente As New RegistrarCliente()

        VariablesPublicas.numeroCliente = generarCodidgoCliente.GenerarNuevoCodigo()
        VariablesPublicas.ClienteNombre = txtNombre.Text
        VariablesPublicas.ClienteApellido = txtApellido.Text
        VariablesPublicas.ClienteTelefono = lblTelefono.Text

        Dim registro = registrarCliente.RegistrarCliente(VariablesPublicas.numeroCliente, VariablesPublicas.ClienteNombre, VariablesPublicas.ClienteApellido, VariablesPublicas.ClienteTelefono)
    End Sub



    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim registrar As New RegistrarUsuario()
        Dim random As New Random()
        Dim nombre As String = txtUsuario.Text
        Dim password As String = txtContrasena.Text
        Dim Correo As String = txtCorreo.Text
        VariablesPublicas.ClienteCorreo = txtCorreo.Text
        VariablesPublicas.codigoConfirmacion = random.Next(100000, 1000000).ToString()

        DatosDelCliente()

        If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(Correo) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If registrar.RegistrarUsuario(VariablesPublicas.numeroCliente, nombre, Correo, password) Then
            Dim verificar As New VerificarUsuario()
            Dim asunto As String = "Codigo de confirmación"

            Dim mensajeHtml As String =
            "<html>" &
                "<head>" &
                    "<style>" &
                    "body { font-family: Arial, sans-serif; margin: 0; padding: 0; background-color: #f5f5f5; color: #333; }" &
                    ".container { max-width: 600px; margin: 20px auto; background: #fff; border: 1px solid #ddd; border-radius: 8px; padding: 20px; box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1); }" &
                    ".header { text-align: center; color: #0078d7; }" &
                    ".header h1 { margin: 0; font-size: 32px; }" &
                    ".content { margin-top: 20px; text-align: center; }" &
                    ".content h2 { margin: 0 0 10px; font-size: 24px; color: #555; }" &
                    ".code-box { margin: 20px 0; background: #f7f7f7; padding: 15px; font-size: 24px; font-weight: bold; border-radius: 8px; color: #333; border: 1px dashed #ccc; display: inline-block; }" &
                    ".footer { text-align: center; font-size: 14px; color: #777; margin-top: 20px; }" &
                    ".footer a { color: #007bff; text-decoration: none; }" &
                    ".footer a:hover { text-decoration: underline; }" &
                    "</style>" &
                "</head>" &
                "<body>" &
                    "<div class='container'>" &
                    "<div class='header'>" &
                    "<h1>¡Código de Confirmación!</h1>" &
                    "<p>Gracias por utilizar nuestros servicios</p>" &
                    "</div>" &
                    "<div class='content'>" &
                    "<h2>Tu Código de Confirmación</h2>" &
                    "<div class='code-box'>" + VariablesPublicas.codigoConfirmacion.ToString() + "</div>" &
                    "<p>Por favor, introduce este código en el sistema para completar tu proceso.</p>" &
                    "<p>Si no solicitaste este código, ignora este mensaje o contacta con nuestro soporte.</p>" &
                    "</div>" &
                    "<div class='footer'>" &
                    "<p>¿Necesitas ayuda? Contáctanos al skyridersoficial@gmail.com</p>" &
                    "</div>" &
                    "</div>" &
                "</body>" &
             "</html>"



            EnviarCorreo(Correo, asunto, mensajeHtml)


            verificar.Show()
            Me.Close()
        Else
            MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub EnviarCorreo(destinatario As String, asunto As String, mensajeHtml As String)
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("skyrydersoficial@gmail.com", "gphv tkfm kclp tqid")
            smtp.EnableSsl = True

            Dim mail As New MailMessage()
            mail.From = New MailAddress("skyrydersoficial@gmail.com")
            mail.To.Add(destinatario)
            mail.Subject = asunto
            mail.Body = mensajeHtml
            mail.IsBodyHtml = True

            smtp.Send(mail)
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim principal As New PaginaPrincipalDeInicio()
        principal.Show()
        Me.Close()
    End Sub

    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class