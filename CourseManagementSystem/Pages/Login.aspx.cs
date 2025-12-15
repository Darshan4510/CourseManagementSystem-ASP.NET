using System;
using System.Data.SqlClient;
using CourseManagementSystem.Helpers;


namespace CourseManagementSystem.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Login_Click(object sender, EventArgs e)
        {
            string cs = System.Configuration.ConfigurationManager
                        .ConnectionStrings["CS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = "SELECT UserId,Role FROM Users WHERE Username=@u AND PasswordHash=@p";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@u", txtUser.Text);
                cmd.Parameters.AddWithValue("@p", SecurityHelper.Hash(txtPass.Text));


              


                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Session["UserId"] = dr["UserId"];
                    Session["Role"] = dr["Role"].ToString();

                    if (dr["Role"].ToString() == "Admin")
                        Response.Redirect("ViewCourses.aspx");
                    else
                        Response.Redirect("ApplyCourse.aspx");
                }
                else
                {
                    lblMsg.Text = "No user found. Please register.";
                }
            }
        }
    }
}
