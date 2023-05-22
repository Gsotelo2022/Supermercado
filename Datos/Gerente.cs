using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Gerente
    {
        #region ATRIBUTOS

        private ConexionDB conexion;

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public Gerente()
        {
            this.conexion = new ConexionDB();
        }

        /// <summary>
        /// Consulta las ventas por mes.
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public DataTable ConsultarReportePorMes(int mes)
        {
            string query = @"SELECT T0.Id_Orden, T0.Fecha, T0.Id_Articulo, T1.Precio, T1.Cantidad, T1.Id_Usuario FROM Orden_Compra T0
                            INNER JOIN Orden_Detalle T1 ON T0.Id_Orden = T1.Id_Orden
                            WHERE MONTH(T0.Fecha) = @mes";

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = this.conexion.CrearParametro("@mes", mes);
            
            DataTable respuesta  = conexion.ObtenerResulatdoConsulta(query, false, parametros);

            return respuesta;
        }

        /// <summary>
        /// Consulta las ventas entre fechas.
        /// </summary>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        public DataTable ConsultarReportePorSemana(DateTime desde, DateTime hasta)
        {
            string query = @"SELECT T0.Id_Orden, T0.Fecha, T0.Id_Articulo, T1.Precio, T1.Cantidad, T1.Id_Usuario FROM Orden_Compra T0
                            INNER JOIN Orden_Detalle T1 ON T0.Id_Orden = T1.Id_Orden
                            WHERE T0.Fecha BETWEEN @desde AND @hasta";

            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = this.conexion.CrearParametro("@desde", desde);
            parametros[1] = this.conexion.CrearParametro("@hasta", hasta);

            DataTable respuesta = conexion.ObtenerResulatdoConsulta(query, false, parametros);

            return respuesta;
        }

        /// <summary>
        /// Consulta las ventas del usuario.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public DataTable ConsultarReportePorVendedor(int usuario)
        {
            string query = @"SELECT T0.Id_Orden, T0.Fecha, T0.Id_Articulo, T1.Precio, T1.Cantidad, T1.Id_Usuario FROM Orden_Compra T0
                            INNER JOIN Orden_Detalle T1 ON T0.Id_Orden = T1.Id_Orden
                            WHERE T0.Id_Usuario = @usuario";

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = this.conexion.CrearParametro("@usuario", usuario);

            DataTable respuesta = conexion.ObtenerResulatdoConsulta(query, false, parametros);

            return respuesta;
        }
    }
}
