using System.Data;
using NUnit.Framework;

namespace TestSupermercado
{
    public class GerenteTest
    {
        [Test]
        public void VentasPorMes()
        {
            Datos.D_Gerente gerenteDA = new Datos.D_Gerente();

            DataTable respuesta = gerenteDA.CrearReporteDeVentasPorMes(6, 2023);

            string registros = respuesta.Rows.Count == 0 ? string.Empty : respuesta.Rows.Count.ToString();

            Assert.IsNotEmpty(registros);
        }

        [Test]
        public void VentasPorSemana()
        {
            Datos.D_Gerente gerenteDA = new Datos.D_Gerente();

            DateTime desde = new DateTime(2023, 6, 1);
            DateTime hasta = new DateTime(2023, 6, 7);

            DataTable respuesta = gerenteDA.CrearReporteDeVentasPorSemana(desde, hasta);

            string registros = respuesta.Rows.Count == 0 ? string.Empty : respuesta.Rows.Count.ToString();

            Assert.IsNotEmpty(registros);
        }

        [Test]
        public void VentasPoVendedor()
        {
            Datos.D_Gerente gerenteDA = new Datos.D_Gerente();

            DataTable respuesta = gerenteDA.CrearReporteDeVentasPorVendedor(4);

            string registros = respuesta.Rows.Count == 0 ? string.Empty : respuesta.Rows.Count.ToString();

            Assert.IsNotEmpty(registros);
        }
    }
}