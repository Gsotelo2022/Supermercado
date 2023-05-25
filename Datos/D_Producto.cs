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
    public class D_Producto
    {
        //Conecto con la logica de producto
        Conexion objConexion = new Conexion();

        public void actualizarStock(E_Producto objEProducto)
        {
            //throw new NotImplementedException();
            SqlParameter[] parametrosNuevos = new SqlParameter[2];
            parametrosNuevos[0] = objConexion.crearParametro("@pIdProducto", objEProducto.Id_Producto);
            parametrosNuevos[1] = objConexion.crearParametro("@pCantidad", objEProducto.Cantidad);

            objConexion.LeerPorStoreProcedure("sp_cargarStock", parametrosNuevos);
        }

        //Modifico valores del producto
        public void actualizarValores(E_Producto objE_Producto)
        {
            //throw new NotImplementedException();
            SqlParameter[] parametrosNuevos = new SqlParameter[4];
            parametrosNuevos[0] = objConexion.crearParametro("@pIdProducto", objE_Producto.Id_Producto);
            parametrosNuevos[1] = objConexion.crearParametro("@pDescripcion", objE_Producto.Descripcion);
            parametrosNuevos[2] = objConexion.crearParametro("@pPrecio", objE_Producto.Precio);
            parametrosNuevos[3] = objConexion.crearParametro("@pHabilitado", objE_Producto.Habilitado);

            objConexion.LeerPorStoreProcedure("sp_ModificarProducto", parametrosNuevos);
        }

        public DataTable devuelvoProducto(string descripcion)
        {
            //throw new NotImplementedException();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = objConexion.crearParametro("@pDescripcion", descripcion);

            DataTable dtProductos = objConexion.LeerPorStoreProcedure("sp_BuscarProducto", parametros);
            return dtProductos;
        }

        public DataTable devuelvoProductoEnAlerta()
        {
            //throw new NotImplementedException();
            DataTable dtProductosEnAlerta = objConexion.LeerPorStoreProcedure("sp_ProductosAlerta");
            return dtProductosEnAlerta;
        }

        public DataTable Listado() {
            //DataTable dt = objConexion.LeerPorComando("Select * from dbo.Producto");
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_ListarProductos");

            return dt; 
        }

        public void recibirDatosProducto(E_Producto objProducto)
        {
            //throw new NotImplementedException();
            //objConexion.EscribirPorComando("insert into dbo.Producto (Descripcion,Precio,Cantidad,Habilitado) values ('"+objProducto.Descripcion+"',"+objProducto.Precio+","+objProducto.Cantidad+",'"+objProducto.Habilitado+"')");
            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = objConexion.crearParametro("@pDescripcion", objProducto.Descripcion);
            parametros[1] = objConexion.crearParametro("@pPrecio", objProducto.Precio);
            parametros[2] = objConexion.crearParametro("@pCantidad", objProducto.Cantidad);
            parametros[3] = objConexion.crearParametro("@pHabilitado", objProducto.Habilitado);

            //DataTable dt = objConexion.LeerPorStoreProcedure("sp_CrearProducto",parametros);
            //Al devolver filar afectadas, se puede usar para la excepcion
            objConexion.LeerPorStoreProcedure("sp_CrearProducto", parametros);
        }
    }
}
