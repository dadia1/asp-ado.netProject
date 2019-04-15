using BaseLogic;
using Commond.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MyProject
{
    public partial class NewUserRegistrPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            string phone = txtPhone.Text;

            User u = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Email = email,
                Password = pass,
            };

            UserBL user = new UserBL();
            if (user.CheckUser(u).Rows.Count > 0)
            {
                MessageBox.Show("The password or username already exists in the system.\n Please try again ", "Eror message");
                return;
            }
            else
            {
                //Manage users actions ["insert","update","delete","read"]
                UserBL userbl = new UserBL();
                int affected = userbl.Register(u);

                if (affected == 1)
                {
                    MessageBox.Show("Register successfully", "success");

                    Response.Redirect("TicketOrderingPage.aspx");

                    MessageBox.Show("הנך מועבר לדף הכניסה להזמנות", "success");

                }
                else
                {

                    MessageBox.Show("Register Error");
                }

            }

        }
    }
}