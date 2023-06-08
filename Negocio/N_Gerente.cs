using System.Data;
using System;

namespace Negocio
{
    public class N_Gerente
    {
        #region ATRIBUTOS

        private Datos.D_Gerente gerenteDA;

        #endregion

        /// <summary>
        /// Constructor: Instancia la variable local de la clase.
        /// </summary>
        public N_Gerente()
        {
            this.gerenteDA = new Datos.D_Gerente();
        }

        #region MÉTODOS PÚBLICOS

        /// <summary>
        /// Devuelte un datable con las ventas filtradas por el mes y año pasado por parámetro.
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public DataTable CrearReporteDeVentasPorMes(int mes, int año)
        {
            DataTable respuesta = gerenteDA.CrearReporteDeVentasPorMes(mes, año);

            if (respuesta.Rows.Count == 0)
            {
                throw new Entidades.Exc_Negocio("No existen documentos para los filtros elegidos");
            }

            return respuesta;
        }

        /// <summary>
        /// Devuelte un datable con las ventas filtradas por las fechas pasadas por parámetro.
        /// </summary>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        public DataTable CrearReporteDeVentasPorSemana(DateTime desde, DateTime hasta)
        {
            DataTable respuesta = gerenteDA.CrearReporteDeVentasPorSemana(desde, hasta);

            if (respuesta.Rows.Count == 0)
            {
                throw new Entidades.Exc_Negocio("No existen documentos para los filtros elegidos");
            }

            return respuesta;
        }

        /// <summary>
        /// Devuelte un datable con las ventas filtradas por el usuario vendedor pasado por parámetro.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public DataTable CrearReporteDeVentasPorVendedor(int usuario)
        {
            DataTable respuesta = gerenteDA.CrearReporteDeVentasPorVendedor(usuario);

            if (respuesta.Rows.Count == 0)
            {
                throw new Entidades.Exc_Negocio("No existen documentos para los filtros elegidos");
            }

            return respuesta;
        }

        #endregion
    }
}
