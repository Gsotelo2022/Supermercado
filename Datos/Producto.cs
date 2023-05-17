using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        //Conecto con la logica de producto
        public DataTable Listado() { 
            Conexion objConexion = new Conexion();
            DataTable dt = objConexion.LeerPorComando("Select * from dbo.Producto");

            return dt; 
        }
    }
}
