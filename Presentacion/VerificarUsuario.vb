Imports Dominio

Public Class VerificarUsuario
    Private Sub btnCodigo_Click(sender As Object, e As EventArgs) Handles btnCodigo.Click
        If txtCodigo.Text = VariablesPublicas.codigoConfirmacion Then
            Dim menu As New Papumenu()
            MessageBox.Show("Usuario Verificado Exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            menu.Show()
            Me.Hide()
        End If
    End Sub
End Class