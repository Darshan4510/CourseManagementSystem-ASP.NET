<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="AddCourse.aspx.cs"
    Inherits="CourseManagementSystem.Pages.AddCourse" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Add Course</title>
    <link href="../Content/simple.css" rel="stylesheet" />
</head>
<body>
<form runat="server">

    <div class="card">
        <h2>Add Course</h2>

        <asp:TextBox ID="txtTitle" runat="server"
            CssClass="input-box"
            Placeholder="Course Title" />

        <asp:TextBox ID="txtDesc" runat="server"
            CssClass="input-box"
            Placeholder="Description" />

        <asp:TextBox ID="txtFee" runat="server"
            CssClass="input-box"
            Placeholder="Fee" />

        <asp:Button Text="Add Course"
            runat="server"
            CssClass="btn"
            OnClick="btnAdd_Click" />

        <asp:Label ID="lblMsg" runat="server" ForeColor="Green" />

        <div class="text-center">
            <a href="ViewCourses.aspx">Back to Dashboard</a>
        </div>
    </div>

</form>
</body>
</html>