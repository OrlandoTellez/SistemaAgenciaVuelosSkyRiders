Public Class PaginaPrincipalDeInicio
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim iniciarSesion As New frmLogin()
        iniciarSesion.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Dim registrarse As New frmRegistro()

        registrarse.Show()
        Me.Hide()
    End Sub

End Class