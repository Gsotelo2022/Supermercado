using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Rol
    {
        private D_Rol datosRol = new D_Rol();

        public List<string> RetornarRoles()
        {
            return datosRol.ListarRoles();
        }
    }
}
