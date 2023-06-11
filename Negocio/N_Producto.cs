using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Producto
    {
        /*Traigo los productos*/
        public DataTable RetornarProductos() { 
            Datos.D_Producto objDatos = new Datos.D_Producto();
            return objDatos.Listado();
        }
        //Busco Producto
        public DataTable BuscarProducto(string descripcion)
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();

            return objProductoDatos.DevuelvoProducto(descripcion);
        }
        //Busco productos en alerta
        public DataTable ProductoAlerta()
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();

            return objProductoDatos.DevuelvoProductoEnAlerta();
        }
        public void CrearProducto(E_Producto objProducto)
        {
            //throw new NotImplementedException();
            D_Producto objProductoDatos = new D_Producto();
            objProductoDatos.RecibirDatosProducto(objProducto);
        }

        public void ModificarProducto(E_Producto objE_Producto)
        {
            //throw new NotImplementedException();
            D_Producto objProductosDatos= new D_Producto();
            objProductosDatos.ActualizarValores(objE_Producto);
        }

        public void CargarStock(E_Producto objEProducto)
        {
            //throw new NotImplementedException();
            D_Producto objProductosDatos = new D_Producto();
            objProductosDatos.ActualizarStock(objEProducto);
        }
        public E_Producto BuscarProductoPorId(int unId)
        {
            D_Producto objDProducto = new D_Producto();
            DataTable dtProducto = new DataTable();
            E_Producto objEProducto = new E_Producto();


            dtProducto = objDProducto.BuscarProductoPorId(unId);


            if (dtProducto.Rows.Count == 0)
            {
                objEProducto = null;
            }
            else
            {
                DataRow fila = dtProducto.Rows[0];
                objEProducto.IdProducto = Convert.ToInt32(fila["Id_Producto"]);
                objEProducto.Descripcion = fila["Descripcion"].ToString();
                objEProducto.Precio = Convert.ToDouble(fila["Precio"]);
                objEProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                objEProducto.Habilitado = fila["Habilitado"].ToString();

            }

            return objEProducto;
        }
        public void ActualizarStock(E_OrdenDeCompra objEOrdenDeCompra)
        {
            D_Producto objDProducto = new D_Producto();

            objDProducto.ActualizarStockDeProducto(objEOrdenDeCompra);
        }
    }
}
