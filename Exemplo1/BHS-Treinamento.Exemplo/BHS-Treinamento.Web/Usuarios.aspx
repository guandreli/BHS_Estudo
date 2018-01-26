<%@ page title="" language="C#" masterpagefile="~/Site.Master" autoeventwireup="true" codebehind="Usuarios.aspx.cs" inherits="BHS_Treinamento.Web.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divGrid">
        <asp:ObjectDataSource ID="dsUsuarios" runat="server" TypeName="BHS_Treinamento.Negocio.UsuarioBO" SelectMethod="GetAll"></asp:ObjectDataSource>
        <asp:GridView ID="gdvUsuarios" runat="server" DataSourceID="dsUsuarios"></asp:GridView>
    </div>
</asp:Content>
