using System;
using System.Data.SqlClient;

namespace CourseManagementSystem.Pages
{
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string cs = System.Configuration.ConfigurationManager
                        .ConnectionStrings["CS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = "INSERT INTO Courses (Title,Description,Duration,Fee) VALUES (@t,@d,'3 Months',@f)";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@t", txtTitle.Text);
                cmd.Parameters.AddWithValue("@d", txtDesc.Text);
                cmd.Parameters.AddWithValue("@f", txtFee.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                lblMsg.Text = "Course Added Successfully!";
            }
        }
    }
}
