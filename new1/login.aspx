<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="new1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Login Form"></asp:Label>
            <br />
            <br />

 <asp:Label ID="Label3" runat="server" Text="Email : "></asp:Label>
 <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
                        <br />
                        <br />

 <asp:Label ID="Label4" runat="server" Text="Password : "></asp:Label>
 <asp:TextBox ID="txt_pass" runat="server"></asp:TextBox>
                        <br />
            <br />

     <asp:Button ID="btn_submit" runat="server" Text="Login" OnClick="btn_submit_Click" />
        </div>
    </form>
</body>
</html>
