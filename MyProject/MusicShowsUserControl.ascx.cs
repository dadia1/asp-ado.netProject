using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class MusicShowsUserControl : System.Web.UI.UserControl
    {
        public string TxtlblMsg
        {
            get
            {
                return lblMsg.Text;
            }

            set
            {
                lblMsg.Text = value;
            }
        }
    }
}