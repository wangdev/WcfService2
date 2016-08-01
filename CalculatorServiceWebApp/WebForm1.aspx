<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorServiceWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
        <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="textBox2" runat="server"></asp:TextBox>
        <asp:Button ID="button1" runat="server" Text="Add" OnClick="button1_Click" />
        <br />
        <asp:Label ID="label1" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
