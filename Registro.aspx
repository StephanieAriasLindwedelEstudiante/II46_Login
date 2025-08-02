<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Registro.aspx.vb" Inherits="PROYECTO_Progra3.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div class="d-flex justify-content-center align-items-center vh-95 bg-light">
        <div class="card shadow-lg p-4" style="max-width: 400px; width: 100%; border-radius: 1rem;">
            <div class="card-body">
                <h2 class="h4 mb-3 text-center fw-bold">Crear cuenta</h2>

                <div class="form-floating mb-3">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre" />
                    <label for="MainContent_txtNombre">Nombre</label>
                </div>

                <div class="form-floating mb-3">
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido" />
                    <label for="MainContent_txtApellido">Apellido</label>
                </div>

                <div class="form-floating mb-3">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="Correo electrónico" />
                    <label for="MainContent_txtEmail">Correo electrónico</label>
                </div>

                <div class="form-floating mb-3">
                    <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" TextMode="Password" placeholder="Contraseña" />
                    <label for="MainContent_txtPass">Contraseña</label>
                </div>

                <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-success w-100 py-2" Text="Registrarse" OnClick="btnRegistrar_Click" />

                <div class="text-center mt-3">
                    <a href="Login.aspx" class="text-decoration-none">¿Ya estás registrado?</a>
                </div>

                <asp:Label ID="lblError" runat="server" CssClass="alert alert-danger mt-3 d-block text-center" Visible="false" />
                <asp:Label ID="lblDebug" runat="server" CssClass="text-info mt-2 d-block text-center" Visible="false" />
            </div>
        </div>
    </div>
</asp:Content>
