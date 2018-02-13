using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string aboutSmalltext = DAL.GetAboutContent();

            if (aboutSmalltext.Length > 501)
            {
               aboutSmalltext = DAL.GetAboutContent().Remove(500); 
            }

            Literal1.Text = aboutSmalltext;
            
        }

        
    }
}
