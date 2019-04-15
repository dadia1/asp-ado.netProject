using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using PayPal.Payments.Common.Utility;
using PayPal.Payments.Communication;
using PayPal.Payments.DataObjects;

namespace MyProject
{
    public partial class TicketOrderingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
                Response.Redirect("LoginPage.aspx");
        }

        protected void LinkLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            if (ddlTicketNumber.SelectedIndex == 0)
            {
                lblTicketNumber.Visible = true;
                return;
            }
            else
                Session["TicketNumber"] = ddlTicketNumber.Text;

            if (ddlArtist.SelectedIndex == 0)
            {
                lblArtist.Visible = true;
                return;
            }
            else
                Session["Artist"] = ddlArtist.Text;

            if (txtCardNumber.Text == string.Empty)
            {
                lblCardNumber.Visible = true;
                return;
            }
            else
                Session["CardNumber"] = txtCardNumber.Text;

            if (ddlMonthCard.SelectedIndex == 0)
            {
                lblDate.Visible = true;
                return;
            }
            else
                Session["MonthCard"] = ddlMonthCard.Text;

            if (ddlYearCard.SelectedIndex == 0)
            {
                lblDate.Visible = true;
                return;
            }
            else
                Session["YearCard"] = ddlYearCard.Text;

            if (txtIdPay.Text == string.Empty)
            {
                lblIdPay.Visible = true;
                return;
            }
            else
                Session["IdPay"] = txtIdPay.Text;

            if (txtNamePAy.Text == string.Empty)
            {
                lblNamePay.Visible = true;
                return;
            }
            else
                Session["NamePAy"] = txtNamePAy.Text;

            if (txtAdressPay.Text == string.Empty)
            {
                lblAdressPay.Visible = true;
                return;
            }
            else
                Session["AdressPay"] = txtAdressPay.Text;


            Response.Redirect("CardInformation.aspx");
        }

        public void LabelForAnotherPage()
        {
            lblTicketNumber.Visible = false;

            lblArtist.Visible = false;

            lblCardNumber.Visible = false;

            lblDate.Visible = false;

            lblDate.Visible = false;

            lblIdPay.Visible = false;

            lblNamePay.Visible = false;

            lblAdressPay.Visible = false;
        }
    }
}