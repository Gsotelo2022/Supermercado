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
    public class D_Cliente
    {
        Conexion unaConexion = new Conexion();


        public DataTable BuscarCliente(int unDni)
        {

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = unaConexion.crearParametro("@DNI", unDni.ToString());



            return unaConexion.LeerPorStoreProcedure("sp_BuscarCliente", parametros);
        }

        public void CrearCliente(E_Cliente nuevoCliente)
        {
            SqlParameter[] parametros = new SqlParameter[6];

            parametros[0] = unaConexion.crearParametro("@DNI", nuevoCliente.Dni.ToString());
            parametros[1] = unaConexion.crearParametro("@Nombre", nuevoCliente.Nombre);
            parametros[2] = unaConexion.crearParametro("@Apellido", nuevoCliente.Apellido);
            parametros[3] = unaConexion.crearParametro("@Telefono", nuevoCliente.Telefono.ToString());
            parametros[4] = unaConexion.crearParametro("@Cuil", nuevoCliente.Cuil.ToString());
            parametros[5] = unaConexion.crearParametro("@Direccion", nuevoCliente.Direccion);

            unaConexion.LeerPorStoreProcedure("sp_Crearcliente", parametros);
        }

        public void ModificarCliente(E_Cliente unCliente)
        {
            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = unaConexion.crearParametro("@DNI", unCliente.Dni.ToString());
            parametros[1] = unaConexion.crearParametro("@Telefono", unCliente.Telefono.ToString());
            parametros[2] = unaConexion.crearParametro("@Direccion", unCliente.Direccion.ToString());

            unaConexion.LeerPorStoreProcedure("sp_ModificarCliente", parametros);


        }
    }
}
