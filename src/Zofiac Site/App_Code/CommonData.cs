using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Security;
using System.IO;
using System.Text;


/// <summary>
/// Clase para persistir los datos del gestor.
/// </summary>
public static class CommonData
{

    /// <summary>
    /// Diccionario que Representa las Cantidad de Colegiados Por Cada Colegio
    /// La key es el Colegio
    /// El valor es la Cantidad de Colegiados
    /// </summary>
    public static List<string> SelectedAttributes
    {
        get
        {
            HttpContext context = HttpContext.Current;

            List<string> selectedAttributes = null;


            object selectedAttributesSession = context.Session["SelectedAttributes"];

            if (selectedAttributesSession != null)
                selectedAttributes = (List<string>)selectedAttributesSession;

            if (selectedAttributes != null)
                return selectedAttributes;
            //else
            //{
            //    List<int> nuevosContactos = new List<int>();
            //    context.Session["CantColegiadosPorColegio"] = nuevosContactos;

            //    return nuevosContactos;
            //}

            return selectedAttributes;

        }
        set
        {
            HttpContext context = HttpContext.Current;
            context.Session["SelectedAttributes"] = value;
        }
    }

    public static List<string> FailedDateFormatLines
    {
        get
        {
            HttpContext context = HttpContext.Current;

            List<string> selectedAttributes = null;


            object selectedAttributesSession = context.Session["FailedDateFormatLines"];

            if (selectedAttributesSession != null)
                selectedAttributes = (List<string>)selectedAttributesSession;

            if (selectedAttributes != null)
                return selectedAttributes;
            //else
            //{
            //    List<int> nuevosContactos = new List<int>();
            //    context.Session["CantColegiadosPorColegio"] = nuevosContactos;

            //    return nuevosContactos;
            //}

            return selectedAttributes;

        }
        set
        {
            HttpContext context = HttpContext.Current;
            context.Session["FailedDateFormatLines"] = value;
        }
    }


    public static string DateFormat
    {
        get
        {
            HttpContext context = HttpContext.Current;

            string dateFormat = "";
            object dateFormatSession = context.Session["DateFormat"];


            if (dateFormatSession != null)
                dateFormat = dateFormatSession.ToString();

            //if (dateFormat != "")
            //    return dateFormat;


            return dateFormat;
        }
        set
        {
            HttpContext context = HttpContext.Current;
            context.Session["DateFormat"] = value;
        }
    }

    public static bool SavingCSV
    {
        get
        {
            HttpContext context = HttpContext.Current;

            object aplicarFiltroSession = context.Session["SavingCSV"];

            if (aplicarFiltroSession != null)
            {
                return (bool)aplicarFiltroSession;
            }
            else
            {
               
                //TODO: Obtenerlo de las preferencias del colegio
                // si es colegiado obternerlo de las preferencias del colegiado
            }

            return false;
        }

        set
        {
            HttpContext context = HttpContext.Current;

            //Guarda el valor en la sesion
            context.Session["SavingCSV"] = value;
        }
    }

}

