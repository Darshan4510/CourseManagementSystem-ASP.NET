using System;
using System.Data.SqlClient;
using CourseManagementSystem.Helpers;


namespace CourseManagementSystem.Pages
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Register_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtConfirm.Text)
            {
                lblMsg.Text = "Password mismatch";
                return;
            }

            string cs = System.Configuration.ConfigurationManager
                        .ConnectionStrings["CS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = "INSERT INTO Users (Username,PasswordHash,Role) VALUES (@u,@p,'Student')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@u", txtUser.Text);
                cmd.Parameters.AddWithValue("@p", SecurityHelper.Hash(txtPass.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                lblMsg.Text = "Registered Successfully";
            }
        }
    }
}
