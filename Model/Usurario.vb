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
    Public Function dtToUsurario(dataTable As DataTable) As Usurario
        If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
            Return Nothing
        End If

        Dim row As DataRow = dataTable.Rows(0)
        Dim usuario As New Usurario With {
            .Id = Convert.ToInt32(row("ID")),
            .Nombre = Convert.ToString(row("NOMBRE")),
            .Apellido = Convert.ToString(row("APELLIDO")),
            .Email = Convert.ToString(row("EMAIL")),
            .Password = Convert.ToString(row("CONTRASENIA"))
        }
        Return usuario
    End Function
End Class
