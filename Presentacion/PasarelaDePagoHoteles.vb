Imports System.Net
Imports System.Net.Mail
Imports Dominio

Public Class PasarelaDePagoHoteles

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
            MessageBox.Show("Reservación de hotel exitosa, favor verificar su correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim correoUsuario As String = VariablesPublicas.pasajeroCorreo

        Dim asunto As String = "Confirmación de Reservacion de hotel"


        Dim mensajeHtml As String =
        "<html>" &
            "<head>" &
                "<style>" &
                "body { font-family: Arial, sans-serif; margin: 0; padding: 0; background-color: #f5f5f5; color: #333; }" &
                ".container { max-width: 600px; margin: 20px auto; background: #fff; border: 1px solid #ddd; border-radius: 8px; padding: 20px; box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1); }" &
                ".header { text-align: center; color: #0078d7; }" &
                ".header h1 { margin: 0; font-size: 32px; }" &
                ".content { margin-top: 20px; }" &
                ".content h2 { margin: 0 0 10px; font-size: 24px; }" &
                ".info-table { width: 100%; border-collapse: collapse; margin-top: 20px; }" &
                ".info-table td { padding: 8px 10px; border-bottom: 1px solid #eee; }" &
                ".info-table td.label { font-weight: bold; color: #555; width: 40%; }" &
                ".items-table { width: 100%; border-collapse: collapse; margin-top: 20px; }" &
                ".items-table th, .items-table td { padding: 10px; text-align: left; border-bottom: 1px solid #eee; }" &
                ".items-table th { background: #f7f7f7; font-weight: bold; color: #555; }" &
                ".items-table td.price { text-align: right; }" &
                ".total-row td { font-size: 18px; font-weight: bold; color: #333; }" &
                ".footer { text-align: center; font-size: 14px; color: #777; margin-top: 20px; }" &
                ".footer a { color: #007bff; text-decoration: none; }" &
                ".footer a:hover { text-decoration: underline; }" &
                "</style>" &
            "</head>" &
            "<body>" &
                "<div class='container'>" &
                "<div class='header'>" &
                "<h1>¡Reserva de Hotel Confirmada!</h1>" &
                "<p>Gracias por elegir " + VariablesPublicas.HotelNombre + "</p>" &
                "</div>" &
                "<div class='content'>" &
                "<h2>Detalles de la Reserva</h2>" &
                "<table class='info-table'>" &
                "<tr><td class='label'>Número de Reserva:</td><td>1234</td></tr>" &
                "<tr><td class='label'>Nombre del Cliente:</td><td>" + VariablesPublicas.ClienteNombre + "</td></tr>" &
                "<tr><td class='label'>Fecha de Check-in:</td><td>" + VariablesPublicas.HotelFechaEntrada + "</td></tr>" &
                "<tr><td class='label'>Fecha de Check-out:</td><td> " + VariablesPublicas.HotelFechaSalido + " </td></tr>" &
                "</table>" &
                "<h2>Servicios Incluidos</h2>" &
                "<table class='items-table'>" &
                "<thead>" &
                "<tr><th>Servicio</th><th>Descripción</th></tr>" &
                "</thead>" &
                "<tbody>" &
                "<tr><td>Desayuno</td><td>Incluido en el precio</td></tr>" &
                "<tr><td>Acceso a Spa</td><td>Una sesión de cortesía por persona</td></tr>" &
                "<tr><td>Wi-Fi</td><td>Alta velocidad, gratuito</td></tr>" &
                "</tbody>" &
                "</table>" &
                "<h2>Detalles del Pago</h2>" &
                "<table class='items-table'>" &
                "<thead>" &
                "<tr><th>Descripción</th><th class='price'>Monto</th></tr>" &
                "</thead>" &
                "<tbody>" &
                "<tr><td>Alojamiento</td><td class='price'>" + "$" + VariablesPublicas.HotelPrecio.ToString() + "</td></tr>" &
                "<tr class='total-row'><td>TOTAL:</td><td class='price'>" + "$" + VariablesPublicas.HotelPrecio.ToString + "</td></tr>" &
                "</tbody>" &
                "</table>" &
                "</div>" &
                "<div class='footer'>" &
                "Para cualquier consulta, contacta con nosotros a través de nuestro sitio web o llamando al +505 75061202." &
                "</div>" &
                "</div>" &
            "</body>" &
        "</html>"


        EnviarCorreo(correoUsuario, asunto, mensajeHtml)


    End Sub

    Private Sub PasarelaDePagoHoteles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = VariablesPublicas.HotelNombre
        lblDetalle.Text = VariablesPublicas.HotelDescripcion
        lblPrecio.Text = VariablesPublicas.HotelPrecio.ToString()
        lblCalificacion.Text = VariablesPublicas.HotelCalificacion
    End Sub
End Class