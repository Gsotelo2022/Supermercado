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
    }
}
