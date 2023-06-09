using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class D_Rol
    {
        //Conecto con la logica de producto.
        Conexion objConexion = new Conexion();


        public List<E_Rol> ListarRoles()
        {
            List<E_Rol> roles = new List<E_Rol>();

            DataTable tablaRoles = objConexion.LeerPorStoreProcedure("sp_ListarRoles");

            foreach (DataRow fila in tablaRoles.Rows)
            {
                E_Rol ERol = new E_Rol();

                ERol.Id = int.Parse(fila[0].ToString());
                ERol.Nombre = fila[1].ToString();

                roles.Add(ERol);
            }

            return roles;
        }

    }
}

