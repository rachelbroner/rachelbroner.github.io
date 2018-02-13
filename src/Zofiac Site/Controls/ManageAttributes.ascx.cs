using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

public partial class Controls_ManageAttributes : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gvAttributes.Sort("attribute", SortDirection.Ascending);
        }
    }
    protected void btnSaveAttribute_Click(object sender, EventArgs e)
    {
        try
        {
            DAL.AddAttribute(tbAttribute.Text.Trim());

            newAttributeForm.Visible = false;

            tbAttribute.Text = "";

            gvAttributes.DataBind();

            lblErrorMessage.Visible = false;
        }
        catch (Exception exception)
        {
            lblErrorMessage.Visible = true;
            lblErrorMessage.Text = string.Format("{0}, {1}", exception.Message, exception.StackTrace);
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        newAttributeForm.Visible = true;
    }
}