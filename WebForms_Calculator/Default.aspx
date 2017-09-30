<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1_empty.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Webforms!</h1>
    <form id="form1" runat="server">
        <div>
            <label>What is your name?</label>
            <asp:TextBox ID="txtName" runat="server" />
            <br />
            <asp:Button ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" runat="server" />
            <asp:Label ID="lblName" runat="server" />
        </div>
    </form>
</body>
</html>
