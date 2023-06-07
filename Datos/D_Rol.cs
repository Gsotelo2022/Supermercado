using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Rol
    {
        //Conecto con la logica de producto
        Conexion objConexion = new Conexion();


        public List<string> ListarRoles()
        {
            List<string> roles = new List<string>();

            DataTable tablaRoles = objConexion.LeerPorStoreProcedure("sp_ListarRoles");

            if (tablaRoles != null && tablaRoles.Rows.Count > 0)
            {
                foreach (DataRow fila in tablaRoles.Rows)
                {
                    string rol = fila["Nombre"].ToString();
                    roles.Add(rol);
                }
            }
            return roles;
        }

    }
}

