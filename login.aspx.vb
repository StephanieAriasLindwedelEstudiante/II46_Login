Imports System.Data.SqlClient

Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Function verificarUsuario(email As String, password As String) As Boolean
        Try

            Dim helper As New DatabaseHelper()
            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@Email", email),
                New SqlParameter("@Password", password)
            }

            Dim query As String = "SELECT * FROM Usuarios WHERE EMAIL = @Email AND CONTRASENIA = @Password"
            Dim dataTable As DataTable = helper.ExecuteQuery(query, parametros)
            Dim usuario As New Usurario()
            If dataTable.Rows.Count > 0 Then
                usuario = usuario.dtToUsurario(dataTable)
                ' Usuario encontrado, puedes redirigir o realizar otra acción
                Session.Add("UsuarioId", usuario.Id.ToString())
                Session.Add("UsuarioNombre", usuario.Nombre.ToString())
                Session.Add("UsuarioApellido", usuario.Apellido.ToString())
                Session.Add("UsuarioEmail", usuario.Email.ToString())
                Return True
            Else
                ' Usuario no encontrado, manejar el error
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)

        Dim email As String = txtEmail.Text
        Dim password As String = txtPass.Text
        Dim usuario As New Usurario() With {
            .Email = email,
            .Password = password
        }
        Dim helper As New DatabaseHelper()
        ' Validar el usuario
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@Email", email),
            New SqlParameter("@Password", password)
        }
        ' Ejecutar la consulta para verificar el usuario
        Dim dataTable As DataTable = helper.ExecuteQuery("SELECT * FROM Usuarios WHERE EMAIL = @Email AND CONTRASENIA = @Password", parametros)
        If usuario.Validar() Then
            If email = "test@example.com" And password = "password" Then
                Response.Redirect("Default.aspx")
            Else
                lblError.Text = "Usuario o contraseña incorrectos."
                lblError.Visible = True
            End If
        Else

            lblError.Text = "Usuario o contraseña incorrectos."
            lblError.Visible = True
        End If

    End Sub
End Class