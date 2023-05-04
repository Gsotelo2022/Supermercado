using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
	class ConextionDB
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

        public DataTable ObtenerResulatdoConsulta(string consulta)
		{
			//Instancio un objeto del tipo DataTable
			var unaTabla = new DataTable();

			//Instancio un objeto del tipo SqlCommand
			var objComando = new SqlCommand();
	
			Conectar();

			try
			{
				//Parametrizo el objeto SqlCommand con sus valores respectivos
				objComando.CommandType = CommandType.Text;
				objComando.Connection = this.objConexion;
				objComando.CommandText = consulta;

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
	}
}
