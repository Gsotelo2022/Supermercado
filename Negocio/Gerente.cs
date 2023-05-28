using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Gerente
    {
        #region ATRIBUTOS

        private Datos.Gerente gerenteDA = new Datos.Gerente();

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public Gerente()
        {
            this.gerenteDA = new Datos.Gerente();
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

            if ( respuesta == null)
            {
                throw new Entidades.Excepciones.ExcepcionDeNegocio("No existen documentos para los filtros elegidos");
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

            if (respuesta == null)
            {
                throw new Entidades.Excepciones.ExcepcionDeNegocio("No existen documentos para los filtros elegidos");
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

            if (respuesta == null)
            {
                throw new Entidades.Excepciones.ExcepcionDeNegocio("No existen documentos para los filtros elegidos");
            }

            return respuesta;
        }

        #endregion

    }
}
