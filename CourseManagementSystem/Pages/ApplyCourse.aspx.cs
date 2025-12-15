using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace CourseManagementSystem.Pages
{
    public partial class ApplyCourse : System.Web.UI.Page
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
                gvCourses.DataSource = dt;
                gvCourses.DataBind();
            }
        }

        protected void gvCourses_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Apply")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                int courseId = Convert.ToInt32(gvCourses.DataKeys[rowIndex].Value);
                int userId = Convert.ToInt32(Session["UserId"]);

                string cs = System.Configuration.ConfigurationManager
                            .ConnectionStrings["CS"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    string q = @"
IF NOT EXISTS
(
    SELECT 1 FROM Applications 
    WHERE UserId = @u AND CourseId = @c
)
INSERT INTO Applications (UserId, CourseId) VALUES (@u, @c)";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@u", userId);
                    cmd.Parameters.AddWithValue("@c", courseId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}