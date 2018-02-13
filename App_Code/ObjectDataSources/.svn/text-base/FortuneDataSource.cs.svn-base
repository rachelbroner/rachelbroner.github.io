using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;
using DataAccessLayer;
using System.Data;

/// <summary>
/// Summary description for AttibruteDataSource
/// </summary>
public class FortuneDataSource
{
    public FortuneDataSource()
	{
      

		//
		// TODO: Add constructor logic here
		//
	}

    public static List<FortuneWrapper> GetData(List<string> sentAttributes)
    {
        List<FortuneWrapper> fortunes = new List<FortuneWrapper>();



         string tempFile = Path.Combine(SitioConfiguracion.TempPath, "dump1.txt");

         StreamReader reader = new StreamReader(tempFile);


        //Linea en blank se ignoran
        //Linea que no contenga al menos dos elementos se ignoran
        //1ra columna es el nombre
        //2da columna es la fecha
        //Linea Si no tienes formato de fecha correcto se ignora

        int lineNumber = 0;

        while(!reader.EndOfStream)
        {
            lineNumber++;

            string[] dataList = null;
            string line1 = reader.ReadLine();

            
            DateTime birthDate = new DateTime();

            bool isValidLine = ValidateLine(ref dataList, line1, ref birthDate);

            if (!isValidLine)
                continue;



            string name = dataList[0];

            ZodiacCalculator.ZodiacCalculator calculator = new ZodiacCalculator.ZodiacCalculator();

            int birthNumer = calculator.BirthNumber(birthDate);
           // cnText.Text = calculator.CurrentNumber(birthDate).ToString();
            int nameNumber = calculator.NameNumber(name);
            string fortune = calculator.ZodiacSign(birthDate);


            DataSet matchedAttributes = DAL.GetMatchedAttributes(birthNumer, fortune, nameNumber);
            DataTable tblmatchedAttributes = matchedAttributes.Tables[0];

            string[] attributes = new string[tblmatchedAttributes.Rows.Count];
           // string attributes = "";

            for (int i = 0; i < tblmatchedAttributes.Rows.Count; i++)
            {
                string attribute = tblmatchedAttributes.Rows[i]["attribute"].ToString();
                attributes[i] = attribute;
           //     attributes += attribute + ", ";
            }

          
          //Selecciona los attributos que coinciden con los parametros sendAttributes
          attributes =  attributes.Where(
                delegate(string t)
                {
                    return sentAttributes.Contains(t);
                }
                ).ToArray();

          attributes.OrderBy(s => s);


          var attributesString = string.Join(",", attributes);

            // Sacamos lineas adicionales en un campo aparte

            string[] extraColumns = null;

            if(dataList.Count() > 2)
            {
                extraColumns = new string[dataList.Count() - 2];

               // dataList.CopyTo(extraColumns, 2);

                for (int i = 0; i < extraColumns.Count(); i++)
                {
                    extraColumns[i] = dataList[i + 2];
                }


            }

            FortuneWrapper fortuneWrapper = new FortuneWrapper
            {
                lineNumber = lineNumber,
                Name = name,
                BirthDate = birthDate,
                BirthNumber = birthNumer,
                NameNumber = nameNumber,
                Fortune = fortune,
                Attributes = attributesString,
                SummingAttributes = attributes.Length,
                ExtraColumns = extraColumns
            };

            fortunes.Add(fortuneWrapper);

        }

        reader.Close();

        return fortunes.OrderByDescending(f => f.SummingAttributes).ToList();

    }

    private static bool ValidateLine(ref string[] dataList, string line1, ref DateTime birthDate)
    {
        

        ////////Dictionary<string, string> culturePatterns = new Dictionary<string, string>();

        ////////culturePatterns.Add("MM/dd/yyyy", "en-US");
        ////////culturePatterns.Add("MM/dd/yy", "en-US");
        ////////culturePatterns.Add("dd/MM/yyyy", "es-ES");
        ////////culturePatterns.Add("dd/MM/yy", "es-ES");
        ////////culturePatterns.Add("yyyy/MM/dd", "ko-KR");
        ////////culturePatterns.Add("yy/MM/dd", "ko-KR");

        if (String.IsNullOrEmpty(line1))
            return false;

        dataList = line1.Split(new char[] { ',', ';' });

        if (dataList.Length < 2)
            return false;

        //IFormatProvider format = new CultureInfo("en-US");

        string pattern = CommonData.DateFormat;
        string pattern1d = pattern.Replace("MM", "M");

       // string withoutSlashesPattern = pattern.Replace("/","");
       //////// string withoutSlashesPattern1d = withoutSlashesPattern.Replace("MM", "M");

        //if (!DateTime.TryParseExact(dataList[1], pattern, null, DateTimeStyles.None, out birthDate) && !DateTime.TryParseExact(dataList[1], withoutSlashesPattern, null, DateTimeStyles.None, out birthDate) && !DateTime.TryParseExact(dataList[1], pattern1d, null, DateTimeStyles.None, out birthDate) && !DateTime.TryParseExact(dataList[1], withoutSlashesPattern1d, null, DateTimeStyles.None, out birthDate))
        if (!DateTime.TryParseExact(dataList[1], pattern, null, DateTimeStyles.None, out birthDate) && !DateTime.TryParseExact(dataList[1], pattern1d, null, DateTimeStyles.None, out birthDate))
        {
            
                if (CommonData.SavingCSV)
                {
                    CommonData.FailedDateFormatLines.Add(line1);
                }

                return false;

       
        }

        return true;
    }
}




public class FortuneWrapper
{
    public int lineNumber { get; set; }

    public string Name { get; set; }

    public DateTime BirthDate { get; set; }

    public int BirthNumber { get; set; }

    public int NameNumber { get; set; }

    public string Fortune { get; set; }

    public string Attributes { get; set; }

    public int SummingAttributes { get; set; }

    public string[] ExtraColumns { get; set; }

}