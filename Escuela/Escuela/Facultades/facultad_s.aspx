<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_s.aspx.cs" Inherits="Escuela.Facultades.facultad_s" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="grd_facultades" AutoGenerateColumns="false" runat="server" OnRowCommand="grd_facultades_RowCommand">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Imagenes/pencil.png" Height="20px" Width="20px"
                        CommandName="Editar" CommandArgument='<%# Eval("ID_Facultad") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/Imagenes/trash.png" Height="20px" Width="20px"
                        CommandName="Eliminar" CommandArgument='<%# Eval("ID_Facultad") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="ID" DataField="ID_Facultad"/>
            <asp:BoundField HeaderText="Codigo" DataField="codigo"/>
            <asp:BoundField HeaderText="Nombre" DataField="nombre"/>
            <asp:BoundField HeaderText="Fecha de creacion" DataField="fechaCreacion" DataFormatString="{0:dd/MM/yyyy}"/>
            <asp:BoundField HeaderText="Universidad" DataField="nombreUniversidad"/>
        </Columns>
    </asp:GridView>

</asp:Content>
