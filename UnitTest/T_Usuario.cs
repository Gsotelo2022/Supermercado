using Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class T_Usuario
    {
        [TestMethod]
        public void CrearUsuario()
        {
            Datos.D_Usuario objDatos = new Datos.D_Usuario();

            int legajo = 10000;
            int permiso = 1;
            string nombreUsuario = "Admin";
            string contrasenia = "Adm123";

            string mensaje = objDatos.CrearUsuario(legajo, permiso, nombreUsuario, contrasenia);

            bool resultado = mensaje.Contains("Ya existe un usuario con el mismo legajo") ? true : false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarUsuario()
        {
            D_Usuario dUsuario = new D_Usuario();

            string unNombre = "Cajero";
            string Passw = "Caja123";

            DataTable registro = dUsuario.BuscarUsuario(unNombre, Passw);

            bool resultado = registro.Rows.Count == 0 ? false : true;

            Assert.IsTrue(resultado);
        }
    }
}
