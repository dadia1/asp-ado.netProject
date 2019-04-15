using BaseLogic;
using System;

namespace MyProject
{
    public partial class VideosPage : System.Web.UI.Page
    {
        MusicLogic Logic = new MusicLogic();
        private string[] Artist = new string[6];
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Artist.Length; i++)
            {
                Artist[i] = Logic.GetArtist().Rows[0].ItemArray[i].ToString();
            }

            if1.Attributes["src"] = Artist[0];
            if2.Attributes["src"] = Artist[1];
            if3.Attributes["src"] = Artist[2];
            if4.Attributes["src"] = Artist[3];
            if5.Attributes["src"] = Artist[4];
            if6.Attributes["src"] = Artist[5];
        }
    }
}