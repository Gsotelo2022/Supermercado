using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Usuario
    {
        public DataTable retornarEmpleados()
        {
            Datos.D_Usuario objDatos = new Datos.D_Usuario();
            return objDatos.Listado();
        }

        public DataTable listarEmpleados()
        {
            Datos.D_Usuario objDatos = new Datos.D_Usuario();
            return objDatos.ListadoEmpleados();
        }

        public string crearUsuario(int legajo, int permiso, string nombreUsuario, string contrasenia)
        {
            Datos.D_Usuario objDatos = new Datos.D_Usuario();
            string mensaje = objDatos.CrearUsuario(legajo, permiso, nombreUsuario, contrasenia);
            return mensaje;
        }

        public DataTable ValidarUsuario(string unNombre, string Passw)
        {
            D_Usuario dUsuario = new D_Usuario();

            return dUsuario.BuscarUsuario(unNombre, Passw);
        }
    }
}
