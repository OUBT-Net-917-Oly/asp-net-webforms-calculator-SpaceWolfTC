<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebApplication1_empty.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--Implement this as a asp.net webforms application--%>
            <h1>ASP Calculator</h1>
            <br />

            <label>Number 1: </label>
            <asp:TextBox ID="Number1" runat="server" />
            <br />
            <br />

            <label>Number 2: </label>
            <%--convert this to an asp.net textbox--%>
            <asp:TextBox ID="Number2" runat="server" />
            <br />
            <br />

            <%--convert these buttons to a asp.net button with an OnClickEvent--%>
            <asp:Button ID="btnAdd" Text="+" OnClick="btnAdd_Click" runat="server" />
            <asp:Button ID="btnSub" Text="-" OnClick="btnSub_Click" runat="server" />
            <asp:Button ID="btnMul" Text="x" OnClick="btnMul_Click" runat="server" />
            <asp:Button ID="btnDiv" Text="/" OnClick="btnDiv_Click" runat="server" />

            <br />
            <br />

            <label>Result: </label>
            <%--convert to an asp:Label--%>
            <asp:TextBox ID="result" runat="server" />
        </div>
    </form>

 
   
</body>
</html>
