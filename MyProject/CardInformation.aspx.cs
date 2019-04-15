using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class CardInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            DataRow dr = null;

            dt.Columns.Add(new DataColumn("מספר הזמנה", typeof(string)));

            dt.Columns.Add(new DataColumn("מספר כרטיסים", typeof(string)));

            dt.Columns.Add(new DataColumn("הופעה", typeof(string)));

            dt.Columns.Add(new DataColumn("מספר כרטיס אשראי", typeof(string)));

            dt.Columns.Add(new DataColumn("תוקף כרטיס חודש", typeof(string)));

            dt.Columns.Add(new DataColumn("תוקף כרטיס שנה", typeof(string)));

            dt.Columns.Add(new DataColumn("תז בעל הכרטיס", typeof(string)));

            dt.Columns.Add(new DataColumn("שם בעל הכרטיס", typeof(string)));

            dt.Columns.Add(new DataColumn("כתובת בעל הכרטיס", typeof(string)));

            dr = dt.NewRow();

            dr["מספר הזמנה"] = 1;

            dr["מספר כרטיסים"] = Session["TicketNumber"];

            dr["הופעה"] = Session["Artist"];

            dr["מספר כרטיס אשראי"] = Session["CardNumber"];

            dr["תוקף כרטיס חודש"] = Session["MonthCard"];

            dr["תוקף כרטיס שנה"] = Session["YearCard"];

            dr["תז בעל הכרטיס"] = Session["IdPay"];

            dr["שם בעל הכרטיס"] = Session["NamePAy"];

            dr["כתובת בעל הכרטיס"] = Session["AdressPay"];

            dt.Rows.Add(dr);

            //Store the DataTable in ViewState
            ViewState["CurrentTable"] = dt;

            CardGridView.DataSource = dt;
            CardGridView.DataBind();
        }
    }
}