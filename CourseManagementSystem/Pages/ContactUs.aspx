<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ContactUs.aspx.cs"
    Inherits="CourseManagementSystem.Pages.ContactUs" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Contact Us</title>
    <link href="../Content/simple.css" rel="stylesheet" />
</head>
<body>
<form runat="server">

    <div class="card">
        <h2>Contact Us</h2>

        <asp:TextBox ID="txtMsg" runat="server"
            CssClass="input-box"
            TextMode="MultiLine"
            Rows="4"
            Placeholder="Your message" />

        <asp:Button Text="Send"
            runat="server"
            CssClass="btn" />

        <div class="text-center">
            <a href="ApplyCourse.aspx">Back</a>
        </div>
    </div>

</form>
</body>
</html>