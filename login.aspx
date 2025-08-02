<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="login.aspx.vb" Inherits="PROYECTO_Progra3.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-95 bg-light">
        <main class="card shadow-lg p-4" style="max-width: 300px; width: 100%; border-radius: 1rem;">
            <h1 class="h3 mb-3 fw-bold">Iniciar sesion</h1>

            <div class="form-floating mb-3">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="SingleLine" placeholder="Email"></asp:TextBox>
                <label for="MainContent_txtEmail">Correo</label>
            </div>

            <div class="form-floating mb-3">
                <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password"></asp:TextBox>
                <label for="MainContent_txtPass">Clave</label>
            </div>

            <div class="form-check text-start mb-3">
                <input class="form-check-input" type="checkbox" value="remember-me" id="flexCheckDefault">
                <label class="form-check-label" for="flexCheckDefault">
                    Recordarme
                </label>
            </div>
            <asp:Button CssClass="btn btn-primary w-100 py-2" ID="btnLogin" runat="server" Text="Acceder" OnClick="btnLogin_Click" />
        </main>
    </div>
    <div class="text-center mt-3">
        <a href="Registro.aspx" class="text-decoration-none">¿Primera vez que ingresa?</a>
    </div>
    <asp:Label ID="lblError" runat="server" Text="" CssClass="alert alert-danger" Visible="false"></asp:Label>
</asp:Content>
