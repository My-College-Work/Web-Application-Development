<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckViewState.aspx.cs" Inherits="BookingApp.CheckViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            The ViewState can not travel from one page to another page.<br />
            You may try Time Travel<br />
            <br />
            Do you want to check your past?<br />
            <asp:RadioButtonList ID="rbChoice" runat="server">
                <asp:ListItem Selected="True">no</asp:ListItem>
                <asp:ListItem>yes</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Sure" />
        </div>
    </form>
</body>
</html>
