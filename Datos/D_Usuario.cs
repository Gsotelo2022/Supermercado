using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable ListadoEmpleados()
        {
            //DataTable dt = objConexion.LeerPorComando("Select * from dbo.Empleado");
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_ListarEmpleadosCU");

            return dt;
        }

        public string CrearUsuario(int legajo, int permiso, string nombreUsuario, string contrasenia)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = objConexion.crearParametro("@pNombre", nombreUsuario);
            parametros[1] = objConexion.crearParametro("@pPassw", contrasenia);
            parametros[2] = objConexion.crearParametro("@pLegajo", legajo);
            parametros[3] = objConexion.crearParametro("@pIdRol", permiso);
            
            

            // Parámetro de salida para capturar el mensaje
            SqlParameter parametroMensaje = new SqlParameter("@pMensaje", SqlDbType.VarChar, 100);
            parametroMensaje.Direction = ParameterDirection.Output;
            parametros[4] = parametroMensaje;

            objConexion.LeerPorStoreProcedure("sp_CrearUsuario", parametros);

            // Obtener el mensaje devuelto desde el parámetro de salida
            string mensaje = parametros[4].Value.ToString();

            return mensaje;
        }
    }
}
