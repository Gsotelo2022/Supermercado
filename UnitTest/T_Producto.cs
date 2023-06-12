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
    public class T_Producto
    {
        [TestMethod]
        public void BuscarProductoPorId()
        {
            D_Producto objDProducto = new D_Producto();
            E_Producto objEProducto = new E_Producto();

            int idProducto = 5;

            DataTable dtProducto = objDProducto.BuscarProductoPorId(idProducto);

            bool resultado = dtProducto.Rows.Count == 0 ? false : true;

            Assert.IsTrue(resultado);
        }
    }
}
