<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Final.aspx.cs" Inherits="SessionImpl.Final" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <ul>
        <% foreach (string item in (List<string>)Session["order"]) { %>
            <li><%= item %></li>
        <% } %>
    </ul>
    <h2>Total Price: <%= Session["bill"] %></h2>
</body>
</html>
