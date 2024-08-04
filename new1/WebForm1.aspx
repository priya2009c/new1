<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="new1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Registeration Form"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
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
        <asp:Label ID="Label5" runat="server" Text="Department : "></asp:Label>
        <asp:DropDownList ID="ddl_dept" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Course : "></asp:Label>
        <asp:DropDownList ID="ddl_course" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <div>
            <asp:Button ID="btn_submit" runat="server" Text="Register" />
        </div>
    </form>
</body>
</html>
