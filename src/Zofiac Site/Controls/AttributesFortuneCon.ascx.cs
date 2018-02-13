using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;


public partial class AttributesFortuneCon : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSaveAttribute_Click(object sender, EventArgs e)
    {
        DAL.AddAttributeFortune(int.Parse(ddlAttributes.SelectedValue), int.Parse(ddlFortunes.SelectedValue));

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



            DropDownList ddlFortunes = (e.Row.FindControl("ddlFortunes") as DropDownList);
            ddlFortunes.DataSource = FortuneDataSource;
            ddlFortunes.DataTextField = "fortune";
            ddlFortunes.DataValueField = "Id";
            ddlFortunes.DataBind();


            Label lblFortune = e.Row.FindControl("lblFortuneID") as Label;
            string fortune = lblFortune.Text;
            ddlFortunes.Items.FindByValue(fortune).Selected = true;

        }
    }
       
   
    protected void gvAttributes_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        object df = gvAttributes.Rows[e.RowIndex].DataItem;

        int IDAttribute = (int)gvAttributes.DataKeys[e.RowIndex].Values["IDattribute"];
        int IDFortune = (int)gvAttributes.DataKeys[e.RowIndex].Values["IDfortune"];

        int newIDAttribute = Convert.ToInt32(((DropDownList)gvAttributes.Rows[e.RowIndex].FindControl("ddlAttributes")).SelectedValue);
        int newIDFortune = Convert.ToInt32(((DropDownList)gvAttributes.Rows[e.RowIndex].FindControl("ddlFortunes")).SelectedValue);

        DAL.UpDateAttributeFortune(IDAttribute, IDFortune, newIDAttribute, newIDFortune);

      
        
    }
}