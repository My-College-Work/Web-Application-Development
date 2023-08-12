<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDemo.aspx.cs" Inherits="CookieImpl.CookieDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 329px;
        }
        .auto-style3 {
            width: 188px;
        }
        .auto-style4 {
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="input" runat="server" Width="318px">Enter your name</asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnSaveCookie" runat="server" OnClick="btnSave_Click" Text="Save" Width="185px" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnRetriveCookie" runat="server" OnClick="btnRetrive_Click" Text="Retrive" Width="176px" />
                    </td>
                    <td>
                        <asp:Label ID="lblDispay" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnDeleteCookie" runat="server" OnClick="btnDeleteCookie_Click" Text="Delete Cookie" Width="323px" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
