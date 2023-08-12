<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="SessionImpl.Items" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="menu" runat="server">
                <asp:ListItem Value="pizza">Pizza</asp:ListItem>
                <asp:ListItem Value="burger">Burger</asp:ListItem>
                <asp:ListItem Value="vada_pav">Vada Pav</asp:ListItem>
                <asp:ListItem Value="cold_drink">Cold Drink</asp:ListItem>
                <asp:ListItem Value="french_fries">French Fries</asp:ListItem>
                <asp:ListItem Value="coffee">Coffee</asp:ListItem>
                <asp:ListItem Value="tea">Tea</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
