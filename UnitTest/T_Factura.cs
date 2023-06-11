using Datos;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class T_Factura
    {
        [TestMethod]
        public void GuardarFactura()
        {
            D_Factura objDFactura = new D_Factura();
            E_Factura objEFactura = new E_Factura();

            objEFactura.Compra.Cajero.IdUsuario = 4;
            objEFactura.Compra.Cliente.Dni = 35123123;

            int _idFactura = objDFactura.CrearFactura(objEFactura);

            bool resultado = _idFactura == 0 ? false : true;

            Assert.IsTrue(resultado);
        }
    }
}
