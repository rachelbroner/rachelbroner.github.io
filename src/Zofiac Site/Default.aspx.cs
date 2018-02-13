using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Globalization;
using System.Drawing;
using System.Data;

public partial class upload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      

       
    }

        protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string fullName = txtFullName.Text;
        string rawDate = txtDate.Text;
        if(fullName == "")
        {
            lblErrors.Text = "נא מלא שם";
            return;
        }
        string[] dateSplit = rawDate.Split('/');
        if(dateSplit.Length != 3)
        {
            lblErrors.Text = "נא הכנס תאריך הפורמט המתאים" + "dd/mm/yyyy";
            return;
        }
        int day = int.Parse(dateSplit[0]);
        int month = int.Parse(dateSplit[1]);
        int year = int.Parse(dateSplit[2]);
        if((day <= 0) || (day > 31))
        {
            lblErrors.Text = "היום לא נכון,נא הכנס תאריך הפורמט המתאים" + "dd/mm/yyyy";
            return;
        }
        if((month <=0 ) || (month > 12))
        {
            lblErrors.Text = "החודש לא נכון,נא הכנס תאריך הפורמט המתאים" + "dd/mm/yyyy";
            return;
        }
        if ((year < 1900) || (year > 2018))
        {
            lblErrors.Text = "השנה לא נכון,נא הכנס תאריך הפורמט המתאים" + " dd/mm/yyyy";
            return;
        }
        lblErrors.Text = "";
        ZodiacCalculator.ZodiacCalculator calc = new ZodiacCalculator.ZodiacCalculator();
        DateTime tempDate = new DateTime(year, month, day);
        string fortune = calc.ZodiacSign(day,month,year);
        //string sign = calc.ZodiacSign(tempDate);
        string hebrewFortune = calc.ZodiacSignHebrew(day, month, year);
        //string hebrewSign = calc.ZodiacSignHebrew(tempDate);
        int birthNumer = calc.BirthNumber(day, month, year);
        //int birthNumer = calc.BirthNumber(tempDate);
        int nameNumber = calc.NameNumber(fullName);
        CellFourtune.Text = hebrewFortune + " " + fortune;
        CellNameNumber.Text = nameNumber.ToString();
        CellBirthNumber.Text = birthNumer.ToString();
        IList<string> attributesList = DataAccessLayer.DAL.GetMatchedAttributesAsString(birthNumer, fortune, nameNumber);
        string attributes = "";
        foreach (string attribute in attributesList) { 
            attributes = attributes + attribute + "<br/>";

        }
        CellAttributes.Text = attributes;
        tblResults.Visible = true;
    }
}