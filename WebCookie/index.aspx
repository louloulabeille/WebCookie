<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebCookie.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="WebFormCookies.aspx" method="post" >
        <div>
            Nom : <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
            Prenom : <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Btn_Envoie" runat="server" Text="Envoyer" />
    </form>
</body>
</html>
