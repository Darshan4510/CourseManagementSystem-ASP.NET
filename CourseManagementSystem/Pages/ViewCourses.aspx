<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ViewCourses.aspx.cs"
    Inherits="CourseManagementSystem.Pages.ViewCourses" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Admin - Manage Courses</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>Admin Dashboard</h2>

    <a href="AddCourse.aspx">➕ Add Course</a> |
    <a href="Login.aspx">🚪 Logout</a>

    <hr />

    <asp:GridView ID="gv" runat="server"
        AutoGenerateColumns="false"
        DataKeyNames="CourseId"
        OnRowEditing="gv_RowEditing"
        OnRowUpdating="gv_RowUpdating"
        OnRowCancelingEdit="gv_RowCancelingEdit"
        OnRowDeleting="gv_RowDeleting">

        <Columns>
            <asp:BoundField DataField="CourseId" HeaderText="ID" ReadOnly="true" />
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:BoundField DataField="Fee" HeaderText="Fee" />
            <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />
        </Columns>

    </asp:GridView>

</form>
</body>
</html>