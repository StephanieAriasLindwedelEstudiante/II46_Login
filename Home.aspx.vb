Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UsuarioId") Is Nothing Then
            ' Si no hay usuario en sesión, redirigir al login
            Response.Redirect("Login.aspx")
        Else
            ' Usuario está autenticado, puedes mostrar información del usuario
            lblNombre.Text = Session("UsuarioNombre").ToString() + " " + Session("UsuarioApellido").ToString() + " "
            lblEmail.Text = Session("UsuarioEmail").ToString()
        End If
    End Sub

End Class