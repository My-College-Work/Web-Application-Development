<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADO_DisConnected.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewMV" runat="server">
            </asp:GridView>
        </div>
        <asp:Button ID="btnAddTime" runat="server" Text="Add Time Slot" OnClick="btnAddTime_Click" />
        <asp:Panel ID="PanelTime" runat="server">
            Slot: <asp:TextBox ID="tbSlot" runat="server"></asp:TextBox>
            <asp:Button ID="btnCommitT" runat="server" Text="Commit" OnClick="btnCommitT_Click"/>
        </asp:Panel>
    </form>
</body>
</html>
