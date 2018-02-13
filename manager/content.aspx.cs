using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class manager_content : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(Page.Request.QueryString["AdminID"]) || Request.QueryString["AdminID"] != ConfigurationManager.AppSettings["AdminID"])
            {
                tbAbout.Visible = false;
                tbPrivacy.Visible = false;
                tbFAQ.Visible = false;
                btnAbout.Visible = false;
            }
            else
            {
                tbAbout.Text = DAL.GetAboutContent();
                tbPrivacy.Text = DAL.GetPrivacyContent();
                tbFAQ.Text = DAL.GetFAQContent();
            }
        }
    }
    protected void btnAbout_Click(object sender, EventArgs e)
    {
        DAL.UpDateAboutPage(tbAbout.Text.Trim());
        DAL.UpDatePrivacyPage(tbPrivacy.Text.Trim());
        DAL.UpDateFAQPage(tbFAQ.Text.Trim());
    }
}