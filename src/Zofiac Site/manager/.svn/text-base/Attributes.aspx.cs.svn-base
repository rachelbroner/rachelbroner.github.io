using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Page.Request.QueryString["AdminID"]) || Request.QueryString["AdminID"] != ConfigurationManager.AppSettings["AdminID"].ToString())
        {
            ManageAttributes1.Visible = false;
        }
    }
}
