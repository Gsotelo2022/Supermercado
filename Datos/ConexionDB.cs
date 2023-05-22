using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
	public class ConexionDB
	{
        static readonly string key = "Presentacion.Properties.Settings.Supermercado";
        SqlConnection objConexion;

        private void Conectar()
        {
            objConexion = new SqlConnection(ConfigurationManager.ConnectionStrings[key].ConnectionString);
            objConexion.Open();
        }

        private void Desconectar()
        {
            objConexion.Close();
            objConexion.Dispose();
        }

        public DataTable ObtenerResulatdoConsulta(string consulta, bool isSP, SqlParameter[] pParametrosSql = null)
		{
			//Instancio un objeto del tipo DataTable
			var unaTabla = new DataTable();

			//Instancio un objeto del tipo SqlCommand
			var objComando = new SqlCommand();
	
			Conectar();

			try
			{
                if (isSP)
                {
                    objComando.CommandText = consulta;
                    objComando.CommandType = CommandType.StoredProcedure;
                    objComando.Connection = this.objConexion;
                }
                else
                {
                    //Parametrizo el objeto SqlCommand con sus valores respectivos
                    objComando.CommandType = CommandType.Text;
                    objComando.Connection = this.objConexion;
                    objComando.CommandText = consulta;
                }

				if (pParametrosSql != null)
				{
					objComando.Parameters.AddRange(pParametrosSql);
				}

				//Instancio un adaptador con el parametro SqlCommand
				var objAdaptador = new SqlDataAdapter(objComando);
				//Lleno la tabla, el objeto unaTabla con el adaptador
				objAdaptador.Fill(unaTabla);

			}
			catch
			{
				//Como hay error... por el motivo que sea asigno el resultado a null
				unaTabla = null;
				throw;
			}
			finally
			{
				//Siempre, por más que salga bien o mal el llenado, me desconecto
				Desconectar();
			}
			return unaTabla;
		}

        #region Parametros

        /// <summary>
        /// Permite crear parámetros de tipo string.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pValor"></param>
        /// <returns></returns>
        public SqlParameter CrearParametro(string pNombre, string pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.String;

            return objParametro;
        }

        /// <summary>
        /// Permite crear parámetros de tipo double.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pValor"></param>
        /// <returns></returns>
        public SqlParameter CrearParametro(string pNombre, double pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Double;

            return objParametro;
        }

        /// <summary>
        /// Permite crear parámetros de tipo datetime.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pValor"></param>
        /// <returns></returns>
        public SqlParameter CrearParametro(string pNombre, DateTime pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.DateTime;

            return objParametro;
        }

        /// <summary>
        /// Permite crear parámetros de tipo timeSpan.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pValor"></param>
        /// <returns></returns>
        public SqlParameter CrearParametro(string pNombre, TimeSpan pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.DateTime;

            return objParametro;
        }

        /// <summary>
        /// Permite crear parámetros de tipo int.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pValor"></param>
        /// <returns></returns>
        public SqlParameter CrearParametro(string pNombre, int pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Int32;

            return objParametro;
        }

        /// <summary>
        /// Permite crear parámetros de tipo booleano.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pValor"></param>
        /// <returns></returns>
        public SqlParameter CrearParametro(string pNombre, Boolean pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Boolean;

            return objParametro;
        }

        #endregion
    }
}
