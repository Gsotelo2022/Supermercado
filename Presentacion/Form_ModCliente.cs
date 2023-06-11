using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form_ModCliente : Form
    {
        E_Cliente cliente = new E_Cliente();

        public Form_ModCliente(E_Cliente unCliente)
        {
            InitializeComponent();

            this.cliente = unCliente;

            this.dniModCliente_tbx.Text = unCliente.Dni.ToString();
            this.nombreModCliente_tbx.Text = unCliente.Nombre.ToString();
            this.apellidoModCliente_tbx.Text = unCliente.Apellido.ToString();
            this.cuilModCliente_tbx.Text = unCliente.Cuil.ToString();
            this.telefonoModCliente_tbx.Text = unCliente.Telefono.ToString();
            this.direccionModCliente_tbx.Text = unCliente.Direccion.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form_ModCliente_Load(object sender, EventArgs e)
        {
            this.Text = "Modificación de cliente";
        }

        private void modCliente_btn_Click(object sender, EventArgs e)
        {
            cliente.Telefono = Convert.ToInt64(this.telefonoModCliente_tbx.Text);
            cliente.Direccion = this.direccionModCliente_tbx.Text;


            N_Cajero objNcajero = new N_Cajero();

            objNcajero.ModificaCliente(cliente);

            MessageBox.Show("Los datos del cliente " + cliente.Nombre +
                            " " + cliente.Apellido + " se han modificado con éxito!!!");
        }
    }
}
