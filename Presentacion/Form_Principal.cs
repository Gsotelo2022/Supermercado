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
        /// Desencadena la busqueda de ventas por mes y año.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXMes_Click(object sender, EventArgs e)
        {
            Negocio.Gerente gerenteNeg = new Negocio.Gerente();

            int añoSelect = 0;
            string mesSelect = this.cmbBoxMeses.SelectedItem.ToString();
            int mesSelectNum = 0;

            try
            {
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


                if (string.IsNullOrEmpty(this.txtBoxAño.Text))
                {
                    throw new Entidades.Excepciones.ExcepcionDeNegocio("Debe escribir un año antes de continuar.");
                }
                else
                {
                    añoSelect = int.Parse(this.txtBoxAño.Text);
                }


                this.dtGridPorMes.DataSource = gerenteNeg.CrearReporteDeVentasPorMes(mesSelectNum, añoSelect);

            }
            catch(Entidades.Excepciones.ExcepcionDeNegocio exc)
            {
                MessageBox.Show(exc.Mensaje);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + exc.Message);
            }
        }

        /// <summary>
        /// Desencadena la busqueda de ventas por semana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXSem_Click(object sender, EventArgs e)
        {
            Negocio.Gerente gerenteNeg = new Negocio.Gerente();

            DateTime desde = this.dtPickerDesde.Value;
            DateTime hasta = this.dtPickerHasta.Value;

            try
            {
                this.dtGridPorSem.DataSource = gerenteNeg.CrearReporteDeVentasPorSemana(desde, hasta);
            }
            catch (Entidades.Excepciones.ExcepcionDeNegocio exc)
            {
                MessageBox.Show(exc.Mensaje);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + exc.Message);
            }
        }

        /// <summary>
        /// Desencadena la busqueda de ventas por vendedor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarXVend_Click(object sender, EventArgs e)
        {
            Negocio.Gerente gerenteNeg = new Negocio.Gerente();

            string vendSelect = this.cmbBoxVendedor.SelectedItem.ToString();

            int usuarioId = int.Parse(vendSelect.Split('-')[0].Split(' ')[0]);

            try
            {
                this.dtGridPorVend.DataSource = gerenteNeg.CrearReporteDeVentasPorVendedor(usuarioId);
            }
            catch (Entidades.Excepciones.ExcepcionDeNegocio exc)
            {
                MessageBox.Show(exc.Mensaje);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + exc.Message);
            }

        }

        #endregion

        #endregion

        #region MÉTODOS PRIVADOS

        /// <summary>
        /// Carga los controles para que el usuario eliga los filtros deseados.
        /// </summary>
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
                "DICIEMBRE"
            };

            cmbBoxMeses.DataSource = meses;
            cmbBoxMeses.SelectedIndex = 0;

            //Carga el cmbBox que filtra la búsqueda por vendedor.
            List<string> vendedores = new List<string>();

            try
            {
                // vendedores = Acá va el método que busca todos los vendedores y devuelve una lista.
                // idUsuario - Nombre ARpellido

                cmbBoxVendedor.DataSource = vendedores;
                cmbBoxVendedor.SelectedIndex = 0;
            }
            catch (Entidades.Excepciones.ExcepcionDeNegocio exc)
            {
                MessageBox.Show(exc.Mensaje);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + exc.Message);
            }
        }

        #endregion

    }
}
