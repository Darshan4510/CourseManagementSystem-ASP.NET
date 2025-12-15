<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs"
    Inherits="CourseManagementSystem.Pages.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
    <link href="../Content/simple.css" rel="stylesheet" />
</head>
<body>
<form runat="server">

    <div class="card">
        <h2>Login</h2>

        <asp:TextBox ID="txtUser" runat="server"
            CssClass="input-box"
            Placeholder="Username" />

        <asp:TextBox ID="txtPass" runat="server"
            CssClass="input-box"
            TextMode="Password"
            Placeholder="Password" />

        <asp:Button Text="Login"
            runat="server"
            CssClass="btn"
            OnClick="Login_Click" />

        <asp:Label ID="lblMsg" runat="server"
            ForeColor="Red" />

        <div class="text-center">
            New user?
            <a href="Register.aspx">Register here</a>
        </div>
    </div>

</form>
</body>
</html>