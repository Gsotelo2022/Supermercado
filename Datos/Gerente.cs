using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Gerente
    {
        #region ATRIBUTOS

        private Conexion conexion;

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public Gerente()
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
            string query = @"SELECT T0.Id_Orden, T0.Fecha, T0.Id_Articulo, T1.Precio, T1.Cantidad, T1.Id_Usuario FROM Orden_Compra T0
                            INNER JOIN Orden_Detalle T1 ON T0.Id_Orden = T1.Id_Orden
                            WHERE MONTH(T0.Fecha) = @mes AND YEAR(T0.Fecha) = @año";

            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = this.conexion.crearParametro("@mes", mes);
            parametros[1] = this.conexion.crearParametro("@año", año);

            DataTable respuesta = conexion.LeerPorStoreProcedure(query, parametros);

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
            string query = @"SELECT T0.Id_Orden, T0.Fecha, T0.Id_Articulo, T1.Precio, T1.Cantidad, T1.Id_Usuario FROM Orden_Compra T0
                            INNER JOIN Orden_Detalle T1 ON T0.Id_Orden = T1.Id_Orden
                            WHERE T0.Fecha BETWEEN @desde AND @hasta";

            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = this.conexion.crearParametro("@desde", desde);
            parametros[1] = this.conexion.crearParametro("@hasta", hasta);

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
            string query = @"SELECT T0.Id_Orden, T0.Fecha, T0.Id_Articulo, T1.Precio, T1.Cantidad, T1.Id_Usuario FROM Orden_Compra T0
                            INNER JOIN Orden_Detalle T1 ON T0.Id_Orden = T1.Id_Orden
                            WHERE T0.Id_Usuario = @usuario";

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = this.conexion.crearParametro("@usuario", usuario);

            DataTable respuesta = conexion.LeerPorStoreProcedure(query, parametros);

            return respuesta;
        }
    }
}
