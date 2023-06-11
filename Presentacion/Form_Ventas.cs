using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form_Ventas : Form
    {

        E_Usuario objECajero;
        E_Cliente objECliente;
        E_OrdenDeCompra objEOrdenDeCompra;
        E_Factura objEFactura;
        N_Producto objNProducto;
        N_OrdenDetalle objNOrdenDetalle;
        N_OrdenDeCompra objNOrdenDeCompra;
        N_Cajero objNCajero;



        public Form_Ventas(E_Usuario unUsuario, E_Cliente unCliente)
        {
            InitializeComponent();
            this.objECajero = unUsuario;
            this.objECliente = unCliente;
            this.objNProducto = new N_Producto();
            this.objNOrdenDeCompra = new N_OrdenDeCompra();
            this.objNOrdenDetalle = new N_OrdenDetalle();
            this.objNCajero = new N_Cajero();
            this.objEOrdenDeCompra = this.objNCajero.CrearOrdenDeCompra();
            this.objEOrdenDeCompra.Fecha = DateTime.Now;
            this.objEOrdenDeCompra.Cajero = this.objECajero;
            this.objEOrdenDeCompra.Cliente = this.objECliente;


        }

        private void Form_Ventas_Load(object sender, EventArgs e)
        {
            this.Text = "Ventas";
            this.ContruirCabeceraDGV();


        }


        private void ContruirCabeceraDGV()
        {

            string[] titulos = { "PRODUCTO", "PRECIO", "CANTIDAD", "SUBTOTAL" };

            foreach (string titulo in titulos)
            {
                DataGridViewTextBoxColumn colTxtDgv = new DataGridViewTextBoxColumn()
                {
                    Name = titulo.ToLower(),
                    HeaderText = titulo,
                    Width = 120
                };

                this.detalleOrdendeCompra_dgv.Columns.Add(colTxtDgv);
            }

        }

        private void AgregarDetalleDGV(int fila, E_OrdenDetalle e_OrdenDetalle)
        {

            this.detalleOrdendeCompra_dgv.Rows[fila].Cells[0].Value = e_OrdenDetalle.Producto.Descripcion;
            this.detalleOrdendeCompra_dgv.Rows[fila].Cells[1].Value = e_OrdenDetalle.Producto.Precio;
            this.detalleOrdendeCompra_dgv.Rows[fila].Cells[2].Value = e_OrdenDetalle.Cantidad;
            this.detalleOrdendeCompra_dgv.Rows[fila].Cells[3].Value = e_OrdenDetalle.Subtotal;

            this.BorrarFormulario();

        }

        private void BorrarFormulario()
        {
            this.idProducto_tbx.Text = " ";
            this.cantidadProducto_tbx.Text = " ";
        }

        

        private void MostrarTotalActual()
        {
            objEOrdenDeCompra = objNOrdenDeCompra.DevolverTotal(objEOrdenDeCompra);
            this.totalVenta_lbl.Text = "$ " + objEOrdenDeCompra.Total.ToString();
        }



        private void itemVenta_btn_Click(object sender, EventArgs e)
        {
            int _idProducto, _cantidadProducto;

            int filas = detalleOrdendeCompra_dgv.Rows.Count - 1;


            try
            {
                _idProducto = Convert.ToInt32(this.idProducto_tbx.Text);
                _cantidadProducto = Convert.ToInt32(this.cantidadProducto_tbx.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Los campos solo aceptan números enteros!!!");

                this.BorrarFormulario();

                return;
            }



            E_Producto e_Producto = new E_Producto();
            e_Producto = objNProducto.BuscarProductoPorId(_idProducto);

            if (e_Producto == null)
            {
                MessageBox.Show("El producto no existe!!!");
                this.BorrarFormulario();
                return;
            }


            E_OrdenDetalle objEOrdenDetalle = new E_OrdenDetalle();

            objEOrdenDetalle.Producto = e_Producto;
            objEOrdenDetalle.Cantidad = _cantidadProducto;



            objEOrdenDetalle = objNOrdenDetalle.DevolverSubtotal(objEOrdenDetalle);


            this.detalleOrdendeCompra_dgv.Rows.Add(1);
            this.AgregarDetalleDGV(filas, objEOrdenDetalle);

            objNOrdenDeCompra.AgregarDetalle(objEOrdenDeCompra, objEOrdenDetalle);


            this.MostrarTotalActual();
        }

        private void facturarVenta_btn_Click(object sender, EventArgs e)
        {
            E_Factura objEFactura = new E_Factura();
            N_Factura objNFactura = new N_Factura();
            N_Producto objNProducto = new N_Producto();

            objEFactura.Compra = this.objEOrdenDeCompra;

            MessageBox.Show(objNFactura.Imprimir(objEFactura));


            objNFactura.GuardarFactura();
            objNProducto.ActualizarStock(objEOrdenDeCompra);


            MessageBox.Show("Factura Registrada con exito!!!!");
        }

        private void borrarItemVenta_btn_Click(object sender, EventArgs e)
        {
            objEOrdenDeCompra.Detalle.RemoveAt(this.detalleOrdendeCompra_dgv.CurrentRow.Index);
            this.detalleOrdendeCompra_dgv.Rows.RemoveAt(this.detalleOrdendeCompra_dgv.CurrentRow.Index);

            this.MostrarTotalActual();
        }
    }
}
