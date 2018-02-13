using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Configuration;

    class MicrosoftAccessConnector
    {
         
        private static OleDbConnection aConexion = null;


        public MicrosoftAccessConnector()
        {
                 
            
        }

        private static void CrearConexion()
        {

          //  aConexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            aConexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                                           AppDomain.CurrentDomain.BaseDirectory +
                                           ConfigurationSettings.AppSettings["DBFile"]);
        }


        public static DataSet Recuperar_Consulta(String pCadenaConsulta)
        {
            DataSet adsDatos_Consulta = new DataSet();

            if (aConexion == null)
                CrearConexion();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(pCadenaConsulta, aConexion);

                    
            try
            {
                aConexion.Open();
                dataAdapter.Fill(adsDatos_Consulta);
            }
            catch (Exception e)
            {
                aConexion.Close();
                throw e;
            }

            aConexion.Close();
            
            return adsDatos_Consulta;
        }

        //Realiza una consulta para devolver un solo valor
		public static Object Recuperar_Consulta_Escalar(String pCadenaConsulta)
		{
            if (aConexion == null)
                CrearConexion();

            Object vFilasafectadas;

            try
            {
                
                OleDbCommand command = new OleDbCommand(pCadenaConsulta, aConexion);
                aConexion.Open();

                vFilasafectadas = command.ExecuteScalar();

            }
            catch (Exception e)
            {
                aConexion.Close();
                throw e;
            }

            aConexion.Close();
            return vFilasafectadas;
		}

        //encargada de ejecutar una sentencia sql que no devuelva nada
        //Devuelve la cantidad de filas afectadas
		public static int Ejecutar_Sentencia(String pCadenaConsulta)
		{
            if (aConexion == null)
                CrearConexion();

            int vFilasafectadas;

            try
            {
                
                OleDbCommand command = new OleDbCommand(pCadenaConsulta, aConexion);
                aConexion.Open();

                vFilasafectadas = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                aConexion.Close();
                throw e;
            }

            aConexion.Close();
		    return vFilasafectadas;
		
		}
    }
}

