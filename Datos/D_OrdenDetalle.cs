using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_OrdenDetalle
    {

        Conexion objConexion = new Conexion();


        public void GuardarOrdenDetalle(E_OrdenDetalle objEOrdenDetalle, int idFactura)
        {
            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = objConexion.crearParametro("@IdFactura", idFactura.ToString());
            parametros[1] = objConexion.crearParametro("IdProducto", objEOrdenDetalle.Producto.IdProducto.ToString());
            parametros[2] = objConexion.crearParametro("@Cantidad", objEOrdenDetalle.Cantidad.ToString());

            objConexion.LeerPorStoreProcedure("sp_CrearFacturaDetalle", parametros);


        }

    }
}
