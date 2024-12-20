<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioSala.aspx.cs" Inherits="CineWS.Catalogos.Sala.FormularioSala" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Titulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        </div>
        <div class="row">
            <div class="col-md-12">
                <%--formulario--%>
                <div class="form-group">
                    <asp:Label ID="Nombre" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Label ID="TipoSala" runat="server" Text="Tipo de Sala"></asp:Label>
                    <asp:TextBox ID="txtTipoSala" runat="server" CssClass="form-control"></asp:TextBox>                  
                    <asp:Label ID="lblAsientos_ID" runat="server" Text="Asientos_ID"></asp:Label>  
                    <asp:TextBox ID="txtIdAsiento" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btngurdar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btngurdar_Click" />
                </div>
            </div>

        </div>
    </div>
</asp:Content>
