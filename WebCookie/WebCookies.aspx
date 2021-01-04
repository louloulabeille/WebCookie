<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCookies.aspx.cs" Inherits="WebCookie.WebCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="TableBrowser" runat="server">
                <asp:TableRow>
                    <asp:TableCell BackColor="ForestGreen" BorderColor="Blue" BorderWidth="1px">
                        Informations sur les capacités du brower:
                    </asp:TableCell>

                </asp:TableRow>
            </asp:Table>
            <div>
                Nom : <asp:TextBox ID="TextBoxNom" runat="server"></asp:TextBox>
                Prenom : <asp:TextBox ID="TextBoxPrenom" runat="server"></asp:TextBox>
                Date de Connexion : <asp:TextBox ID="TextBoxConnexion" runat="server"></asp:TextBox>
            </div>
        </div>
    </form>
</body>
</html>