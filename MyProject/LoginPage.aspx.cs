using BaseLogic;
using Commond.Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MyProject
{
    public partial class LoginPage : System.Web.UI.Page
    {

        UserBL user = new UserBL();
        User u;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            u = new User()
            {
                Email = Login1.UserName,
                Password = Login1.Password,
            };

            if (user.CheckUser(u).Rows.Count > 0)
            {
                //Admin
                if (u.Email == "admin@gmail.com" && u.Password == "1212")
                {
                    u.IsAdmin = true;
                    MessageBox.Show("ADMINSTRATOR", "LOGIN ADMIN SUCCESS");
                    Session["UserName"] = u.IsAdmin;
                    e.Authenticated = true;
                    Response.Redirect("AdminPageForWebmaster.aspx");
                }
                //Users
                else
                {
                    MessageBox.Show("Register successfully", "LOGIN SUCCESS");
                    Session["UserName"] = Login1.UserName;
                    e.Authenticated = true;
                    Response.Redirect("TicketOrderingPage.aspx");
                }
            }
            //Registration error
            else
            {
                MessageBox.Show("Register Error", "EROR LOGIN");
                e.Authenticated = false;
            }

        }

        protected void LinkLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }
    }
}