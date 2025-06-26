Imports Datos

Public Class IniciarSesion
    Dim datos As New Datos.IniciarSesion()
    Public Function AccederSistema(ByVal ncodigo As String, ByVal npassword As String) As Boolean
        Dim acceso As Boolean
        acceso = datos.ConfirmarSesion(ncodigo, npassword)
        Return acceso
    End Function
End Class
