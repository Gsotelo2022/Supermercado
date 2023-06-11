using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Factura
    {
        Conexion objConexion = new Conexion();

        public int CrearFactura(E_Factura objEFactura)
        {

            int _idFactura = 0;

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = objConexion.crearParametro("@DniCliente", objEFactura.Compra.Cliente.Dni.ToString());
            parametros[1] = objConexion.crearParametro("@IdUsuario", objEFactura.Compra.Cajero.IdUsuario.ToString());

            DataTable dtFactura = objConexion.LeerPorStoreProcedure("sp_CrearFactura", parametros);

            DataRow fila = dtFactura.Rows[0];

            _idFactura = Convert.ToInt32(fila["IdFactura"]);

            return _idFactura;
        }
    }
}
