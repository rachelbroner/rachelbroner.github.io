using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class results : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        GridView1.DataSourceID = "ods_Fortunes";
        GridView1.DataBind();

        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //List<string> attributes = new List<string>();

        //foreach (ListItem item in CheckBoxList1.Items)
        //{
        //    if (item.Selected)
        //        attributes.Add(item.Text);
        //}

        CommonData.SavingCSV = true;
        CommonData.FailedDateFormatLines = new List<string>();

        List<FortuneWrapper> fortunes = FortuneDataSource.GetData(CommonData.SelectedAttributes);

        string outputFile = Utils.GenerateOutputFile(fortunes);

        HttpContext.Current.Response.Redirect("~/temp/" + outputFile);
    }


    protected void ods_Fortunes_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {

        //List<string> attributes = new List<string>();

        //foreach (ListItem item in CheckBoxList1.Items)
        //{
        //    if (item.Selected)
        //        attributes.Add(item.Text);
        //}

        e.InputParameters["sentAttributes"] = CommonData.SelectedAttributes;
    }

}