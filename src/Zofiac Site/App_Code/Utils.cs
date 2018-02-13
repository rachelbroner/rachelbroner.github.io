using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;
using System.Configuration;
using System.Net.Mail;
using System.Text;

/// <summary>
/// Summary description for Utils
/// </summary>
public class Utils
{
    public Utils()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary>
    /// Genera el fichero txt con las lineas de fortunes
    /// </summary>
    /// <param name="fortunes"></param>
    /// <param name="fileName"></param>
    /// <returns>
    /// Nombre del fichero generado
    /// </returns>
    //public static string GenerateOutputFile(List<FortuneWrapper> fortunes, string fileName)
    public static string GenerateOutputFile(List<FortuneWrapper> fortunes)
    {
        //string randomFileName = Path.GetRandomFileName();

        //string outputFileName = Path.GetFileNameWithoutExtension(randomFileName) + "-" + fileName;

        string fileName = "Numerosay.csv";

        string outputFilePath = Path.Combine(SitioConfiguracion.TempPath, fileName);


        StreamWriter fwriter = new StreamWriter(outputFilePath);

        StringBuilder lineBuilder = new StringBuilder();

        if (fortunes.Count > 0)
        {
            int maxAttributesAmount = fortunes[0].SummingAttributes;


            // string headersLine = "Original Record,Name,Birth Date,Birth Number,Name Number,Zodiac,Attributes,Attributes Match";
            lineBuilder.Append("Original Record,Name,Birth Date,Birth Number,Name Number,Zodiac,Attributes,");

            if (maxAttributesAmount > 1)
            {
                for (int i = 0; i < maxAttributesAmount - 1; i++)
                {
                    lineBuilder.Append(",");
                }
            }


            lineBuilder.AppendLine("Attributes Match");





            foreach (FortuneWrapper fortune in fortunes)
            {
                string lineNumber = fortune.lineNumber.ToString();
                string name = fortune.Name;

                CultureInfo ci = new CultureInfo("en-US");
                string birthDate = fortune.BirthDate.ToString("d", ci);

                string birthNumber = fortune.BirthNumber.ToString();
                string nameNumber = fortune.NameNumber.ToString();
                string zodiacSign = fortune.Fortune;
                string attributes = fortune.Attributes;
                int attributesAmount = fortune.SummingAttributes;



                lineBuilder.Append(lineNumber + ",");
                lineBuilder.Append(name + ",");
                lineBuilder.Append(birthDate + ",");
                lineBuilder.Append(birthNumber + ",");
                lineBuilder.Append(nameNumber + ",");
                lineBuilder.Append(zodiacSign + ",");

                if (!string.IsNullOrEmpty(attributes))
                    lineBuilder.Append(attributes + ",");

                if (attributesAmount < maxAttributesAmount)
                {
                    int dif = maxAttributesAmount - attributesAmount;

                    for (int i = 0; i < dif; i++)
                    {
                        lineBuilder.Append(",");
                    }
                }


                lineBuilder.Append(attributesAmount.ToString());

                if(fortune.ExtraColumns != null)
                {
                    lineBuilder.Append("," + string.Join(",", fortune.ExtraColumns));
                }


                fwriter.WriteLine(lineBuilder.ToString());


                lineBuilder.Clear();

            }
        }
        //////////////////////
        // Add Failure Date Format Lines
        //////////////////////
        if (CommonData.FailedDateFormatLines.Count > 0)
        {
            lineBuilder.AppendLine("The following lines had some errors while parsing and were ignored");

            foreach (string line in CommonData.FailedDateFormatLines)
            {
                lineBuilder.Append(line);
                lineBuilder.Append(", The Birth Date did not match the selected Date Format.");


                fwriter.WriteLine(lineBuilder.ToString());
                lineBuilder.Clear();
            }

        }

        ////////////////////////////////////////////////


        fwriter.Flush();
        fwriter.Close();


        return fileName;

    }


    public static bool ValidateExtension(string fileName)
    {
        string[] validFileTypes = { ".csv", ".txt" };

        string ext = System.IO.Path.GetExtension(fileName);

        bool hasExt = validFileTypes.Contains(ext);

        if (!hasExt)
            return false;


        return true;
    }


    private static void SendEmail(string from, string to, string subject, string message, byte[] headerImage, byte[] footerImage)
    {
        //MailDefinition nuevo = new MailDefinition();
        //nuevo.From = from;
        //nuevo.Subject = subject;



        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(from);
        mail.To.Add(to);
        mail.Subject = subject;
        mail.SubjectEncoding = System.Text.Encoding.UTF8;
        // mail.IsBodyHtml = true;

        // mail.BodyEncoding = System.Text.Encoding.UTF8;


        AlternateView htmlView = AlternateView.CreateAlternateViewFromString(message, System.Text.Encoding.UTF8, "text/html");

        if (headerImage != null)
        {
            MemoryStream stream = new MemoryStream(headerImage);
            LinkedResource header = new LinkedResource(stream);
            header.ContentId = "head_image";

            htmlView.LinkedResources.Add(header);
        }

        if (footerImage != null)
        {
            MemoryStream stream = new MemoryStream(footerImage);
            LinkedResource footer = new LinkedResource(stream);
            footer.ContentId = "foot_image";

            htmlView.LinkedResources.Add(footer);
        }

        mail.AlternateViews.Add(htmlView);

        // SmtpClient smtp = new SmtpClient("localhost");
        SmtpClient smtp = new SmtpClient();

        //smtp.SendAsync(mail, string.Empty);
        //try
        //{
        smtp.Send(mail);
        //}
        //catch (Exception e)
        //{
        //    Logger.LogError(e, e.Message);
        //    throw e;
        //}

        //smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
    }


    public static void SendContactInfoToAdmin(string name, string email, string subject, string message)
    {

        //if (_enabledEmailing)
        //{
        string templatePath = ConfigurationSettings.AppSettings["ContactFormTemplatePath"];

        string emailFrom = email;
        string contactEmail = ConfigurationSettings.AppSettings["adminEmail"];

        templatePath = AppDomain.CurrentDomain.BaseDirectory + templatePath;

        string bodyTemplate = File.ReadAllText(templatePath);

        string body = BuildContactFormMessageBody(bodyTemplate, name, email, subject, message);

        SendEmail(emailFrom, contactEmail, subject, body, null, null);

        //SendEmail(contactEmail, "henny@localhost", subject, body, null, null);
        //}

    }

    private static string BuildContactFormMessageBody(string bodytemplate, string name, string email, string subject, string message)
    {

        string result = "";

        result = bodytemplate.Replace("<%Name%>", name);
        result = result.Replace("<%Email%>", email);
        result = result.Replace("<%Subject%>", subject);
        result = result.Replace("<%Message%>", message);

        return result;

    }

}