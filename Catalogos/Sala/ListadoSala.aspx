﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoSala.aspx.cs" Inherits="CineWS.Catalogos.Sala.ListadoSala" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h3>Listado de Sala</h3>
    </div>
    <div class="row">
        <asp:GridView ID="GVSala" runat="server"
            CssClass="table table-bordered table-striped table-condensed"
            AutoGenerateColumns="false"
            DataKeyNames="Id_Sala"
            OnRowDeleting="GVSala_RowDeleting"
            OnRowCommand="GVSala_RowCommand">
            <%--arriba se genera los eventos "onrow"--%>
            <Columns>
                <asp:BoundField DataField="Id_Sala" HeaderText="Numero de Genero" ItemStyle-Width="50px" ReadOnly="true" />
                <asp:BoundField DataField="NomSala" HeaderText="Sala" ItemStyle-Width="50px" />
                <asp:BoundField DataField="TipoSala" HeaderText="Tipo Sala" ItemStyle-Width="50px" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Modificar" Text="Editar" ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="50px" />
                <asp:CommandField ButtonType="Button" HeaderText="Eliminar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
