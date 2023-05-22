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
        /// Devuelte un datable con las ventas filtradas por el mes pasado por parámetro.
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public DataTable ConsultarReportePorMes(int mes)
        {
            return gerenteDA.ConsultarReportePorMes(mes);
        }

        /// <summary>
        /// Devuelte un datable con las ventas filtradas por las fechas pasadas por parámetro.
        /// </summary>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        public DataTable ConsultarReportePorSemana(DateTime desde, DateTime hasta) 
        {
            return gerenteDA.ConsultarReportePorSemana(desde, hasta);
        }

        /// <summary>
        /// Devuelte un datable con las ventas filtradas por el usuario pasado por parámetro.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public DataTable ConsultarReportePorVendedor(int usuario)
        {
            return gerenteDA.ConsultarReportePorVendedor(usuario);
        }

        #endregion

    }
}
