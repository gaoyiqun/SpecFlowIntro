<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginSP.aspx.cs" Inherits="WebBankSP.LoginSP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Account No.:
        <asp:TextBox ID="txtAccountNo" runat="server"></asp:TextBox><br />
        Password   :
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
        
        <asp:Button ID="btnLogin" runat="server" Text="Confirm Login" OnClick="btnLogin_Click" /><br />
        <asp:Label ID="Message" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
