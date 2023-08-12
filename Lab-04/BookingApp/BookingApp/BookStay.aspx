<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookStay.aspx.cs" Inherits="BookingApp.BookStay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 257px;
        }
        .auto-style3 {
            width: 257px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 169px;
        }
        .auto-style6 {
            height: 26px;
            width: 169px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">What&#39;s your name?</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbName" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">How many adults?</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbACount" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbACount" ErrorMessage="Number required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbACount" ErrorMessage="Number must between 1 to 6" ForeColor="Red" MaximumValue="6" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">You are interested in...</td>
                    <td class="auto-style5">
                        <asp:RadioButtonList ID="rblistRoomType" runat="server">
                            <asp:ListItem Selected="True" Value="studio">Studio</asp:ListItem>
                            <asp:ListItem Value="suite">Suite</asp:ListItem>
                            <asp:ListItem Value="deluxe">Deluxe</asp:ListItem>
                            <asp:ListItem Value="double">Double</asp:ListItem>
                            <asp:ListItem Value="single">Single</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Actully interested in...</td>
                    <td class="auto-style5">
                        <asp:CheckBoxList ID="cklistOpFacility" runat="server">
                            <asp:ListItem Value="swimmingpool">Swimming Pool</asp:ListItem>
                            <asp:ListItem Value="gym">Gym</asp:ListItem>
                            <asp:ListItem Value="tenniscourt">Tennis Court</asp:ListItem>
                            <asp:ListItem Value="horseridding">Horse Ridding</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">we enjoy</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ddlFoodPref" runat="server">
                            <asp:ListItem Value="0">Please Select</asp:ListItem>
                            <asp:ListItem Value="veg">Veg</asp:ListItem>
                            <asp:ListItem Value="nonveg">Non-Veg</asp:ListItem>
                            <asp:ListItem Value="jain">Jain</asp:ListItem>
                            <asp:ListItem Value="swaminarayan">Swaminarayan</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="ddlFoodPref" ErrorMessage="Select your food prefrence" ForeColor="Red" Operator="NotEqual" ValueToCompare="0"></asp:CompareValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">My secret is</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbPassword" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbPassword" ErrorMessage="Password must be alphanumeric with length 6" ForeColor="Red" ValidationExpression="[0-9|a-z|A-Z]{6}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Book" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hlViewState" runat="server" NavigateUrl="~/CheckViewState.aspx">Can ViewState travel?</asp:HyperLink>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
