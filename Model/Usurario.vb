Public Class Usurario

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Email As String
    Public Property Password As String
    ' Constructor por defecto
    Public Sub New()
        ' Inicializar propiedades si es necesario
    End Sub

    Public Function Validar() As Boolean
        Return Not String.IsNullOrEmpty(Email) AndAlso Not String.IsNullOrEmpty(Password)
    End Function

End Class
