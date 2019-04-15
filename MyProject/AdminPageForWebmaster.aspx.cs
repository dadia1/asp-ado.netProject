using BaseLogic;
using Commond.Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class AdminPageForWebmaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(Session["UserName"]))
                Response.Redirect("LoginPage.aspx");

            //LoadVideos();
        }

        private void LoadVideos()
        {
            MusicLogic Logic = new MusicLogic();
            string[] Artist = new string[6];
            for (int i = 0; i < Artist.Length; i++)
            {
                Artist[i] = Logic.GetArtist().Rows[0].ItemArray[i].ToString();
            }

            txtVid1.Text = Artist[0];
            txtVid2.Text = Artist[1];
            txtVid3.Text = Artist[2];
            txtVid4.Text = Artist[3];
            txtVid5.Text = Artist[4];
            txtVid6.Text = Artist[5];

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            VIdeos allVideos = new VIdeos();

            if (txtVid1.Text != string.Empty)
            {
                allVideos.Url_Vid1 = txtVid1.Text.ToString();
            }

            if (txtVid2.Text != string.Empty)
            {
                allVideos.Url_Vid2 = txtVid2.Text.ToString();
            }

            if (txtVid3.Text != string.Empty)
            {
                allVideos.Url_Vid3 = txtVid3.Text.ToString();
            }

            if (txtVid4.Text != string.Empty)
            {
                allVideos.Url_Vid4 = txtVid4.Text.ToString();
            }

            if (txtVid5.Text != string.Empty)
            {
                allVideos.Url_Vid5 = txtVid5.Text.ToString();
            }

            if (txtVid6.Text != string.Empty)
            {
                allVideos.Url_Vid6 = txtVid6.Text.ToString();
            }

            AdminLogic admin = new AdminLogic();
            admin.UpdateVideos(allVideos);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }


        protected void LinkadminLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }

    }
}
