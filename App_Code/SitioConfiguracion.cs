using System;
using System.Configuration;
using System.Web;
using System.IO;


/// <summary>
/// Summary description for SiteConfiguration
/// </summary>
public static class SitioConfiguracion
{
    private readonly static string _errorLogPath;
   // private readonly static string _iconosPath;

    private readonly static string _tempPath;

    static SitioConfiguracion()
    {
        _errorLogPath = ConfigurationManager.AppSettings["errorLogPath"];
        //_tempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //_tempPath = ConfigurationManager.AppSettings["tempPath"];

        _tempPath = AppDomain.CurrentDomain.BaseDirectory + "\\temp\\";
            

        //_iconosPath = Utils.AppPath + ConfigurationManager.AppSettings["iconosPath"];

        
       
        //_imagenesPreferenciasPath = HttpContext.Current.Request.ApplicationPath + ConfigurationManager.AppSettings["imagesPreferenciasPath"];
        //_imagenesPreferenciasPath = Utils.AppPath + ConfigurationManager.AppSettings["imagesPreferenciasPath"];
       
        //PageDataPersistDays = int.Parse(ConfigurationManager.AppSettings["PageDataPersistDays"]);
       
        //_sendEmails = bool.Parse(ConfigurationManager.AppSettings["SendEmails"]);
    

 

    }
   
    public static string ErrorLogPath
    {
        get
        {
            return _errorLogPath;
        }
    }


    public static string TempPath
    {
        get
        {
            return _tempPath;
        }
    }

    //public static string IconosPath
    //{
    //    get
    //    {
    //        return _iconosPath;
    //    }
    //}
   
}
