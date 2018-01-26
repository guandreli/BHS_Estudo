<%@ page title="" language="C#" masterpagefile="~/Site.Master" autoeventwireup="true" codebehind="Pedidos.aspx.cs" inherits="BHS_Treinamento.Web.Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="dsPedidos" runat="server" TypeName="BHS_Treinamento.Negocio.PedidoBO" SelectMethod="GetAll"></asp:ObjectDataSource>
    <asp:GridView ID="gdvPedidos" runat="server" DataSourceID="dsPedidos"></asp:GridView>
</asp:Content>
