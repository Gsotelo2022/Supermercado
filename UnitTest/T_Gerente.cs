﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System;
using System.Data;

namespace UnitTest
{
    [TestClass]
    public class T_Gerente
    {
        [TestMethod]
        public void VentasPorMes()
        {
            Datos.D_Gerente gerenteDA = new Datos.D_Gerente();

            DataTable registros = gerenteDA.CrearReporteDeVentasPorMes(6, 2023);

            bool resultado = registros.Rows.Count == 0 ? false : true;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VentasPorSemana()
        {
            Datos.D_Gerente gerenteDA = new Datos.D_Gerente();

            DateTime desde = new DateTime(2023, 6, 1);
            DateTime hasta = new DateTime(2023, 6, 7);

            DataTable registros = gerenteDA.CrearReporteDeVentasPorSemana(desde, hasta);

            bool resultado = registros.Rows.Count == 0 ? false : true;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VentasPoVendedor()
        {
            Datos.D_Gerente gerenteDA = new Datos.D_Gerente();

            DataTable registros = gerenteDA.CrearReporteDeVentasPorVendedor(4);

            bool resultado = registros.Rows.Count == 0 ? false : true;

            Assert.IsTrue(resultado);
        }
    }
}
