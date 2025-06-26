Public Class RegistrarCliente
    Dim Datos As New Datos.RegistrarCliente()
    Public Function RegistrarCliente(ByVal xnumeroCliente As String, ByVal xclienteNombre As String, ByVal xclienteApellido As String, ByVal xclienteTelefono As String) As Boolean
        Dim resultado As Boolean

        resultado = Datos.RegistrarCliente(xnumeroCliente, xclienteNombre, xclienteApellido, xclienteTelefono)

        Return resultado
    End Function
End Class
