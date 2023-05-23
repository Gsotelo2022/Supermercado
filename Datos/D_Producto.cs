using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Producto
    {
        //Conecto con la logica de producto
        Conexion objConexion = new Conexion();
        public DataTable Listado() {
            //DataTable dt = objConexion.LeerPorComando("Select * from dbo.Producto");
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_ListarProductos");

            return dt; 
        }

        public void recibirDatosProducto(E_Producto objProducto)
        {
            //throw new NotImplementedException();
            //objConexion.EscribirPorComando("insert into dbo.Producto (Descripcion,Precio,Cantidad,Habilitado) values ('Leche',200,300,'SI')");
            objConexion.EscribirPorComando("insert into dbo.Producto (Descripcion,Precio,Cantidad,Habilitado) values ('"+objProducto.Descripcion+"',"+objProducto.Precio+","+objProducto.Cantidad+",'"+objProducto.Habilitado+"')");
        }
    }
}
