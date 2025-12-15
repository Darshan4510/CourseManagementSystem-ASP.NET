<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs"
    Inherits="CourseManagementSystem.Pages.Register" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Register</title>
    <link href="../Content/simple.css" rel="stylesheet" />
</head>
<body>
<form runat="server">

    <div class="card">
        <h2>Register</h2>

        <asp:TextBox ID="txtUser" runat="server"
            CssClass="input-box"
            Placeholder="Username" />

        <asp:TextBox ID="txtPass" runat="server"
            CssClass="input-box"
            TextMode="Password"
            Placeholder="Password" />

        <asp:TextBox ID="txtConfirm" runat="server"
            CssClass="input-box"
            TextMode="Password"
            Placeholder="Confirm Password" />

        <asp:Button Text="Register"
            runat="server"
            CssClass="btn"
            OnClick="Register_Click" />

        <asp:Label ID="lblMsg" runat="server"
            ForeColor="Green" />

        <div class="text-center">
            Already have an account?
            <a href="Login.aspx">Login</a>
        </div>
    </div>

</form>
</body>
</html>