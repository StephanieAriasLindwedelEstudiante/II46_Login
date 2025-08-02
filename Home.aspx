<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="PROYECTO_Progra3.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-95 bg-light" style="background-image: url('Images/fondo.jpg'); background-size: cover; background-position: center;">
        <div class="card shadow-lg p-4" style="max-width: 400px; width: 100%; border-radius: 1rem;">
            <div class="card shadow-lg p-4" style="max-width: 600px; width: 100%; border-radius: 1rem;">
                <h1 class="h3 mb-3 fw-bold">Bienvenido a la Página Principal</h1>
            </div>
        </div>
    </div>
    <div class="d-flex justify-content-center align-items-center vh-95 bg-light">
        <h2 class="h4 mb-3 text-center fw-bold">Información del Usuario</h2>
    </div>
    <div class="d-flex justify-content-center align-items-center vh-95 bg-light">
        <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
    </div>
    <div class="d-flex justify-content-center align-items-center vh-95 bg-light">
        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
