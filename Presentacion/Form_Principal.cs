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
    public partial class Form_Principal : Form
    {
        Negocio.Gerente gerenteNeg = new Negocio.Gerente();

        // <summary>
        /// Constructor
        /// </summary>
        public Form_Principal(int codigo)
        {
            InitializeComponent();

            switch (codigo)
            {
                case 1:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    this.tabControl1.TabPages.Remove(tabEncargado);
                    break;
                case 2:
                    //Funcionalidad gerente 
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    this.tabControl1.TabPages.Remove(tabEncargado);

                    CargarDatosEnGerente();

                    break;
                case 3:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    break;
                case 4:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabEncargado);
                    break;
                default: break;
            }
        }

        #region EVENTOS

        #region Formulario Principal

        /// <summary>
        /// Cuando el Formulario Principal se cierra, se cierra toda la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Gerente

        /// <summary>
        /// Desencadena la busqueda de ventas por mes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXMes_Click(object sender, EventArgs e)
        {
            string mesSelect = this.cmbBoxMeses.SelectedItem.ToString();
            int mesSelectNum = 0;

            switch (mesSelect)
            {
                case "ENERO":
                    mesSelectNum = (int)Entidades.Dias.ENERO;
                    break;
                case "FEBRERO":
                    mesSelectNum = (int)Entidades.Dias.FEBRERO;
                    break;
                case "MARZO":
                    mesSelectNum = (int)Entidades.Dias.MARZO;
                    break;
                case "ABRIL":
                    mesSelectNum = (int)Entidades.Dias.ABRIL;
                    break;
                case "MAYO":
                    mesSelectNum = (int)Entidades.Dias.MAYO;
                    break;
                case "JUNIO":
                    mesSelectNum = (int)Entidades.Dias.JUNIO;
                    break;
                case "JULIO":
                    mesSelectNum = (int)Entidades.Dias.JULIO;
                    break;
                case "AGOSTO":
                    mesSelectNum = (int)Entidades.Dias.AGOSTO;
                    break;
                case "SEPTIEMBRE":
                    mesSelectNum = (int)Entidades.Dias.SEPTIEMBRE;
                    break;
                case "OCTUBRE":
                    mesSelectNum = (int)Entidades.Dias.OCTUBRE;
                    break;
                case "NOVIEMBRE":
                    mesSelectNum = (int)Entidades.Dias.NOVIEMBRE;
                    break;
                case "DICIEMBRE":
                    mesSelectNum = (int)Entidades.Dias.DICIEMBRE;
                    break;
            }

            this.dtGridPorMes.DataSource = this.gerenteNeg.ConsultarReportePorMes(mesSelectNum);
        }

        /// <summary>
        /// Desencadena la busqueda de ventas por semana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXSem_Click(object sender, EventArgs e)
        {
            DateTime desde = this.dtPickerDesde.Value;
            DateTime hasta = this.dtPickerHasta.Value;

            this.dtGridPorSem.DataSource = this.gerenteNeg.ConsultarReportePorSemana(desde, hasta);
        }

        /// <summary>
        /// Desencadena la busqueda de ventas por vendedor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXVend_Click(object sender, EventArgs e)
        {
            string vendSelect = this.cmbBoxVendedor.SelectedItem.ToString();

            string usuarioId = vendSelect.Split('-')[0].Split(' ')[0];

            this.dtGridPorVend.DataSource = this.gerenteNeg.ConsultarReportePorVendedor(usuarioId);
        }

        #endregion

        #endregion

        #region MÉTODOS PRIVADOS

        private void CargarDatosEnGerente()
        {
            // Carga el cmbBox que filtra la búsqueda por meses.
            List<string> meses = new List<string>() 
            {
                "ENERO",
                "FEBRERO", 
                "MARZO", 
                "ABRIL", 
                "MAYO",
                "JUNIO", 
                "JULIO",
                "AGOSTO",
                "SEPTIEMBRE",
                "OCTUBRE",
                "NOVIEMBRE",
                "DICIEMBE"
            };

            cmbBoxMeses.DataSource = meses;

            //Carga el cmbBox que filtra la búsqueda por vendedor.
            List<string> vendedor = new List<string>();
            // idUsuario - Nombre Apellido

            cmbBoxVendedor.DataSource = vendedor;
        }

        #endregion

    }
}
