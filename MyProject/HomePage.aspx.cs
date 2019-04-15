
using BaseLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class HomePage : System.Web.UI.Page
    {
        MusicLogic logic = new MusicLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            MusicShowsUserControl myControl = new MusicShowsUserControl();

            myControl = (MusicShowsUserControl)LoadControl("MusicShowsUserControl.ascx");

            for (int i = 0; i < logic.GetString().Rows.Count; i++)
            {
                myControl.TxtlblMsg += logic.GetString().Rows[i].ItemArray[0].ToString() + "&nbsp" + "&nbsp" + "---";
                myControl.ID += logic.GetString().Rows[i].ItemArray[0].ToString() + "&nbsp" + "&nbsp" + "---";
                Panel1.Controls.Add(myControl);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            for (int i = 0; i < logic.GetSearch(txtSearch.Text).Rows.Count; i++)
            {
                Session["searchResult"] = logic.GetSearch(txtSearch.Text);

                if (Session["searchResult"] != null)
                {
                    isFound = true;
                    Response.Redirect("SearchResultsPage.aspx");
                }
            }

            if (!isFound)
            {
                lblNotResultSearch.Text = "אין תוצאות עבור החיפוש המבוקש , אנא נסה שוב עם ערכים אחרים תודה.";
            }
        }
    }
}

