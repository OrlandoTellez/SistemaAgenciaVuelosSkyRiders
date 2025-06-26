Imports Datos
Public Class RegistrarUsuario
    Dim Datos As New Datos.RegistrarUsuario()
    Public Function RegistrarUsuario(ByVal xnumeroCliente As String, ByVal xnombre As String, ByVal xcorreoUsuario As String, ByVal xpassword As String) As Boolean
        Dim resultado As Boolean

        resultado = Datos.RegistrarUsuario(xnumeroCliente, xnombre, xcorreoUsuario, xpassword)

        Return resultado
    End Function
End Class
