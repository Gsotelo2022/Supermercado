using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_Gerente
    {
        #region ATRIBUTOS

        private Conexion conexion;

        #endregion

        /// <summary>
        /// Constructor: Instancia la variable local de la clase.
        /// </summary>
        public D_Gerente()
        {
            this.conexion = new Conexion();
        }

        /// <summary>
        /// Consulta las ventas por mes y año.
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public DataTable CrearReporteDeVentasPorMes(int mes, int año)
        {
            string sp = "sp_VentasPorMes";

            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = this.conexion.crearParametro("mes", mes);
            parametros[1] = this.conexion.crearParametro("año", año);

            DataTable respuesta = conexion.LeerPorStoreProcedure(sp, parametros);

            return respuesta;
        }

        /// <summary>
        /// Consulta las ventas entre fechas.
        /// </summary>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        public DataTable CrearReporteDeVentasPorSemana(DateTime desde, DateTime hasta)
        {
            string query = "sp_VentasPorSemana";

            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = this.conexion.crearParametro("desde", desde);
            parametros[1] = this.conexion.crearParametro("hasta", hasta);

            DataTable respuesta = conexion.LeerPorStoreProcedure(query, parametros);

            return respuesta;
        }

        /// <summary>
        /// Consulta las ventas del vendedor elegido.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public DataTable CrearReporteDeVentasPorVendedor(int usuario)
        {
            string query = "sp_VentasPorVendedor";

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = this.conexion.crearParametro("usuario", usuario);

            DataTable respuesta = conexion.LeerPorStoreProcedure(query, parametros);

            return respuesta;
        }
    }
}
