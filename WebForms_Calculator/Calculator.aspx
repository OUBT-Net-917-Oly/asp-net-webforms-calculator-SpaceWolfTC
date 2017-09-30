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
            <h1>JavaScript Calculator</h1>
            <br />

            <label>Number 1: </label>
            <asp:TextBox ID="Number1" runat="server" />
            <br />
            <br />

            <label>Number 2: </label>
            <%--convert this to an asp.net textbox--%>
            <input type="text" id="number2" />
            <br />
            <br />

            <%--convert these buttons to a asp.net button with an OnClickEvent--%>
            <asp:Button ID="btnAdd" Text="+" OnClick="btnAdd_Click" runat="server" />
            <input type="button" value="-" onclick="" />
            <input type="button" value="x" onclick="" />
            <input type="button" value="/" onclick="" />
            <br />
            <br />

            <label>Result: </label>
            <%--convert to an asp:Label--%>
            <input type="text" id="result" />
        </div>
    </form>
</body>
</html>
