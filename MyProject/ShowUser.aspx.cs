using BaseLogic;
using Commond.Entities;
using System;
using System.Collections.Generic;

namespace MyProject
{
    public partial class ShowUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserBL userBl = new UserBL();
                List<User> allUsers = userBl.GetUsers();
                if (allUsers != null)
                {
                    rptShowUsers.DataSource = allUsers;
                    rptShowUsers.DataBind();
                }
            }
        }
    }
}