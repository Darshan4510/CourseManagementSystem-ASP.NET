using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace CourseManagementSystem.Pages
{
    public partial class ViewCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCourses();
            }
        }

        void LoadCourses()
        {
            string cs = System.Configuration.ConfigurationManager
                        .ConnectionStrings["CS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Courses", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv.DataSource = dt;
                gv.DataBind();
            }
        }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv.EditIndex = e.NewEditIndex;
            LoadCourses();
        }

        protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv.EditIndex = -1;
            LoadCourses();
        }

        protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(gv.DataKeys[e.RowIndex].Value);

            GridViewRow row = gv.Rows[e.RowIndex];
            string title = ((TextBox)row.Cells[1].Controls[0]).Text;
            string desc = ((TextBox)row.Cells[2].Controls[0]).Text;
            string fee = ((TextBox)row.Cells[3].Controls[0]).Text;

            string cs = System.Configuration.ConfigurationManager
                        .ConnectionStrings["CS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Courses SET Title=@t, Description=@d, Fee=@f WHERE CourseId=@id", con);

                cmd.Parameters.AddWithValue("@t", title);
                cmd.Parameters.AddWithValue("@d", desc);
                cmd.Parameters.AddWithValue("@f", fee);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            gv.EditIndex = -1;
            LoadCourses();
        }

        protected void gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gv.DataKeys[e.RowIndex].Value);

            string cs = System.Configuration.ConfigurationManager
                        .ConnectionStrings["CS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Courses WHERE CourseId=@id", con);

                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadCourses();
        }
    }
}