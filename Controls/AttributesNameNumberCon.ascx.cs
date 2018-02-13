using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;


public partial class Controls_NameNumberCon : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSaveAttribute_Click(object sender, EventArgs e)
    {
        DAL.AddAttributeNameNumber(int.Parse(ddlAttributes.SelectedValue), int.Parse(ddlNameNumber.SelectedValue));

        newAttributeForm.Visible = false;

        //tbAttribute.Text = "";

        gvAttributes.DataBind();

       
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        newAttributeForm.Visible = true;
    }
    protected void gvAttributes_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.FindControl("ddlAttributes") != null)
        /////////////// if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //Find the DropDownList in the Row
            DropDownList ddlCountries = (e.Row.FindControl("ddlAttributes") as DropDownList);
            ddlCountries.DataSource = AttributeDataSource;
            ddlCountries.DataTextField = "attribute";
            ddlCountries.DataValueField = "Id";
            ddlCountries.DataBind();

            ////Add Default Item in the DropDownList
            //ddlCountries.Items.Insert(0, new ListItem("Please select"));

            //Select the Country of Customer in DropDownList

            //lblAttribute
            Label lblArttributes = e.Row.FindControl("lblAttributeID") as Label;
            string country = lblArttributes.Text;
            ddlCountries.Items.FindByValue(country).Selected = true;
        }
    }
       
   
    protected void gvAttributes_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        object df = gvAttributes.Rows[e.RowIndex].DataItem;

        int IDAttribute = (int)gvAttributes.DataKeys[e.RowIndex].Values["IDattribute"];
        int nameNumber = (int)gvAttributes.DataKeys[e.RowIndex].Values["nameNumber"];

        int newIDAttribute = Convert.ToInt32(((DropDownList)gvAttributes.Rows[e.RowIndex].FindControl("ddlAttributes")).SelectedValue);
        int newnameNumber = Convert.ToInt32(((DropDownList)gvAttributes.Rows[e.RowIndex].FindControl("ddlNameNumber")).SelectedValue);

        DAL.UpDateAttributeNameNumber(IDAttribute, nameNumber, newIDAttribute, newnameNumber);

      
        
    }
}