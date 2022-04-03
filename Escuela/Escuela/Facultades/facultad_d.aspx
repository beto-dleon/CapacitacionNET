﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_d.aspx.cs" Inherits="Escuela.Facultades.facultad_d" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>ID: </td>
            <td>
                <asp:label ID="lblIDFacultad" runat="server" Text=""></asp:label>
            </td>
        </tr>
        <tr>
            <td>Codigo: </td>
            <td>
                <asp:label ID="lblCodigo" runat="server" Text=""></asp:label>
            </td>
        </tr>
        <tr>
            <td>Nombre: </td>
            <td>
                <asp:label ID="lblNombre" runat="server" Text=""></asp:label>
            </td>
        </tr>
        <tr>
            <td>Fecha de creacion: </td>
            <td>
                <asp:label ID="lblFechaCreacion" runat="server" Text=""></asp:label>
            </td>
        </tr>
        <tr>
            <td>Universidad: </td>
            <td>
                <asp:DropDownList ID="ddlUniversidad" runat="server" Enabled="false"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"  ></asp:Button>
            </td>
        </tr>
    </table>

</asp:Content>
