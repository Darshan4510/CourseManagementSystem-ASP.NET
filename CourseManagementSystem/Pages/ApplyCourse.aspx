<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ApplyCourse.aspx.cs"
    Inherits="CourseManagementSystem.Pages.ApplyCourse" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Student Dashboard</title>
    <link href="../Content/simple.css" rel="stylesheet" />
</head>
<body>
<form runat="server">

    <div class="card" style="width:90%">
        <h2>Student Dashboard</h2>

        <div class="text-center">
            <a href="ContactUs.aspx">📩 Contact Us</a> |
            <a href="Login.aspx">🚪 Logout</a>
        </div>

        <br />

        <asp:GridView ID="gvCourses" runat="server"
    AutoGenerateColumns="false"
    DataKeyNames="CourseId"
    OnRowCommand="gvCourses_RowCommand">

    <Columns>
        <asp:BoundField DataField="CourseId" HeaderText="ID" />
        <asp:BoundField DataField="Title" HeaderText="Title" />
        <asp:BoundField DataField="Description" HeaderText="Description" />
        <asp:BoundField DataField="Fee" HeaderText="Fee" />

        <asp:ButtonField Text="Apply"
            CommandName="Apply"
            ButtonType="Button" />
    </Columns>

</asp:GridView>
    </div>

</form>
</body>
</html>