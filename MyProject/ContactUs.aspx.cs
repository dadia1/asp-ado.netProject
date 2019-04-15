using BaseLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class ContactUs : System.Web.UI.Page
    {
        MusicLogic logic = new MusicLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

            lblnameCompeny.Text = logic.GetContactUsName().Rows[0].ItemArray[0].ToString();
            //logic.GetContactUsEmail().Rows[0].ItemArray[0].ToString();
            lblPhone.Text = logic.GetContactUsPhone().Rows[0].ItemArray[0].ToString();
        }

        protected void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var smtpClient = new SmtpClient();
                var msg = new MailMessage();
                msg.To.Add(logic.GetContactUsEmail().Rows[0].ItemArray[0].ToString());
                msg.Subject = "צור קשר";
                msg.Body = txtMail.Text;
                smtpClient.Send(msg);
                lblMailResult.Text = "המייל נשלח בהצלחה";
            }
            catch (Exception ex)
            {
                Response.Write("Could not send the e-mail - error: " + ex.Message);
            }

        }
    }
}