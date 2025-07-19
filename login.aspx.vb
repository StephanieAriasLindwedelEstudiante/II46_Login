Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)

        Dim email As String = txtEmail.Text
        Dim password As String = txtPass.Text
        Dim usuario As New Usurario() With {
            .Email = email,
            .Password = password
        }
        Dim helper As New DatabaseHelper()
        ' Validar el usuario
        If usuario.Validar() Then
            If email = "test@example.com" And password = "password" Then
                Response.Redirect("Default.aspx")
            Else
                lblError.Text = "Usuario o contraseña incorrectos."
                lblError.Visible = True
            End If
        Else

            lblError.Text = "Por favor, complete ambos campos."
            lblError.Visible = True
        End If

    End Sub
End Class