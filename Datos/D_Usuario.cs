using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Usuario
    {
        //Conecto con la logica de producto
        Conexion objConexion = new Conexion();

        public DataTable Listado()
        {
            //DataTable dt = objConexion.LeerPorComando("Select * from dbo.Empleado");
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_ListarEmpleados");

            return dt;
        }
    }
}
