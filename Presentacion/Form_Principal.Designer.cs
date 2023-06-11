namespace Supermercado
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGerente = new System.Windows.Forms.TabPage();
            this.tabControlGerente = new System.Windows.Forms.TabControl();
            this.tabReporteMensual = new System.Windows.Forms.TabPage();
            this.boxElegirMes = new System.Windows.Forms.GroupBox();
            this.txtBoxAño = new System.Windows.Forms.TextBox();
            this.btnBuscarXMes = new System.Windows.Forms.Button();
            this.cmbBoxMeses = new System.Windows.Forms.ComboBox();
            this.dtGridPorMes = new System.Windows.Forms.DataGridView();
            this.tabReporteSemanal = new System.Windows.Forms.TabPage();
            this.dtGridPorSem = new System.Windows.Forms.DataGridView();
            this.boxElegirSemana = new System.Windows.Forms.GroupBox();
            this.btnBuscarXSem = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtPickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dtPickerDesde = new System.Windows.Forms.DateTimePicker();
            this.tabReporteVendedor = new System.Windows.Forms.TabPage();
            this.dtGridPorVend = new System.Windows.Forms.DataGridView();
            this.boxElegirVendedor = new System.Windows.Forms.GroupBox();
            this.btnBuscarXVend = new System.Windows.Forms.Button();
            this.cmbBoxVendedor = new System.Windows.Forms.ComboBox();
            this.tabEncargado = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnEncargadoLimpiarCamposCP = new System.Windows.Forms.Button();
            this.btnEncargadoCP = new System.Windows.Forms.Button();
            this.cmbHabilitado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.txtIdModificar1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudPrecioModificar1 = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiarCamposDatosProductoMP = new System.Windows.Forms.Button();
            this.btnModificarDatosProductoMP = new System.Windows.Forms.Button();
            this.cmbHabilitadoModificar1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCantidadModificar1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcionModificar1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCamposMP = new System.Windows.Forms.Button();
            this.btnBuscarProductoMP = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionModificar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvModificarProducto1 = new System.Windows.Forms.DataGridView();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnGenerarAlerta = new System.Windows.Forms.Button();
            this.dgvAlerta = new System.Windows.Forms.DataGridView();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionBCargarStock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCamposCS = new System.Windows.Forms.Button();
            this.btnBuscarProductoCS = new System.Windows.Forms.Button();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.txtIdCargarStock1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCargarStock = new System.Windows.Forms.Button();
            this.nudCantidadCargarStock1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcionCargarStock1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvCargarStock = new System.Windows.Forms.DataGridView();
            this.tabVendedor = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.benerarCliente_btn = new System.Windows.Forms.Button();
            this.direccionCliente_tbx = new System.Windows.Forms.TextBox();
            this.telefonoCliente_tbx = new System.Windows.Forms.TextBox();
            this.cuitCliente_tbx = new System.Windows.Forms.TextBox();
            this.dniCliente_tbx = new System.Windows.Forms.TextBox();
            this.nombrCliente_tbx = new System.Windows.Forms.TextBox();
            this.apellidoCliente_tbx = new System.Windows.Forms.TextBox();
            this.direccionCliente_lbl = new System.Windows.Forms.Label();
            this.telefonoCliente_lbl = new System.Windows.Forms.Label();
            this.cuitCliente_lbl = new System.Windows.Forms.Label();
            this.dniCliente_lbl = new System.Windows.Forms.Label();
            this.nombreCliente_lbl = new System.Windows.Forms.Label();
            this.apellidoCliente_lbl = new System.Windows.Forms.Label();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iniciarVenta_btn = new System.Windows.Forms.Button();
            this.modificarcliente_btn = new System.Windows.Forms.Button();
            this.buscarCliente_gbx = new System.Windows.Forms.GroupBox();
            this.dni_tbx = new System.Windows.Forms.TextBox();
            this.dni_lbl = new System.Windows.Forms.Label();
            this.buscarCliente_btn = new System.Windows.Forms.Button();
            this.dbDatosCliente_dg = new System.Windows.Forms.DataGridView();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.txbLegajo = new System.Windows.Forms.TextBox();
            this.txbReingContr = new System.Windows.Forms.TextBox();
            this.txbContrasenia = new System.Windows.Forms.TextBox();
            this.txbNomUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancUsu = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblRepContr = new System.Windows.Forms.Label();
            this.lblContr = new System.Windows.Forms.Label();
            this.lblNombUsu = new System.Windows.Forms.Label();
            this.cBoxPermisos = new System.Windows.Forms.ComboBox();
            this.lblpermisos = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGerente.SuspendLayout();
            this.tabControlGerente.SuspendLayout();
            this.tabReporteMensual.SuspendLayout();
            this.boxElegirMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPorMes)).BeginInit();
            this.tabReporteSemanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPorSem)).BeginInit();
            this.boxElegirSemana.SuspendLayout();
            this.tabReporteVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPorVend)).BeginInit();
            this.boxElegirVendedor.SuspendLayout();
            this.tabEncargado.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.groupBox36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioModificar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadModificar1)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarProducto1)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tabPage11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerta)).BeginInit();
            this.tabPage12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox37.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCargarStock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargarStock)).BeginInit();
            this.tabVendedor.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.buscarCliente_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDatosCliente_dg)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGerente);
            this.tabControl1.Controls.Add(this.tabEncargado);
            this.tabControl1.Controls.Add(this.tabVendedor);
            this.tabControl1.Controls.Add(this.tabAdmin);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGerente
            // 
            this.tabGerente.Controls.Add(this.tabControlGerente);
            this.tabGerente.Location = new System.Drawing.Point(4, 24);
            this.tabGerente.Name = "tabGerente";
            this.tabGerente.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerente.Size = new System.Drawing.Size(903, 460);
            this.tabGerente.TabIndex = 0;
            this.tabGerente.Text = "Gerente";
            this.tabGerente.UseVisualStyleBackColor = true;
            // 
            // tabControlGerente
            // 
            this.tabControlGerente.Controls.Add(this.tabReporteMensual);
            this.tabControlGerente.Controls.Add(this.tabReporteSemanal);
            this.tabControlGerente.Controls.Add(this.tabReporteVendedor);
            this.tabControlGerente.Location = new System.Drawing.Point(3, 0);
            this.tabControlGerente.Name = "tabControlGerente";
            this.tabControlGerente.SelectedIndex = 0;
            this.tabControlGerente.Size = new System.Drawing.Size(889, 451);
            this.tabControlGerente.TabIndex = 0;
            // 
            // tabReporteMensual
            // 
            this.tabReporteMensual.BackColor = System.Drawing.Color.Transparent;
            this.tabReporteMensual.Controls.Add(this.boxElegirMes);
            this.tabReporteMensual.Controls.Add(this.dtGridPorMes);
            this.tabReporteMensual.Location = new System.Drawing.Point(4, 24);
            this.tabReporteMensual.Name = "tabReporteMensual";
            this.tabReporteMensual.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporteMensual.Size = new System.Drawing.Size(881, 423);
            this.tabReporteMensual.TabIndex = 0;
            this.tabReporteMensual.Text = "Reporte Mensual";
            // 
            // boxElegirMes
            // 
            this.boxElegirMes.Controls.Add(this.txtBoxAño);
            this.boxElegirMes.Controls.Add(this.btnBuscarXMes);
            this.boxElegirMes.Controls.Add(this.cmbBoxMeses);
            this.boxElegirMes.Location = new System.Drawing.Point(5, 6);
            this.boxElegirMes.Name = "boxElegirMes";
            this.boxElegirMes.Size = new System.Drawing.Size(332, 52);
            this.boxElegirMes.TabIndex = 8;
            this.boxElegirMes.TabStop = false;
            this.boxElegirMes.Text = "Elegir Mes y Año";
            // 
            // txtBoxAño
            // 
            this.txtBoxAño.Location = new System.Drawing.Point(178, 20);
            this.txtBoxAño.Name = "txtBoxAño";
            this.txtBoxAño.Size = new System.Drawing.Size(50, 23);
            this.txtBoxAño.TabIndex = 9;
            // 
            // btnBuscarXMes
            // 
            this.btnBuscarXMes.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarXMes.Location = new System.Drawing.Point(245, 21);
            this.btnBuscarXMes.Name = "btnBuscarXMes";
            this.btnBuscarXMes.Size = new System.Drawing.Size(71, 21);
            this.btnBuscarXMes.TabIndex = 1;
            this.btnBuscarXMes.Text = "Buscar";
            this.btnBuscarXMes.UseVisualStyleBackColor = false;
            this.btnBuscarXMes.Click += new System.EventHandler(this.btnBuscarXMes_Click);
            // 
            // cmbBoxMeses
            // 
            this.cmbBoxMeses.FormattingEnabled = true;
            this.cmbBoxMeses.Location = new System.Drawing.Point(6, 19);
            this.cmbBoxMeses.Name = "cmbBoxMeses";
            this.cmbBoxMeses.Size = new System.Drawing.Size(166, 23);
            this.cmbBoxMeses.TabIndex = 0;
            // 
            // dtGridPorMes
            // 
            this.dtGridPorMes.AllowUserToAddRows = false;
            this.dtGridPorMes.AllowUserToDeleteRows = false;
            this.dtGridPorMes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridPorMes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridPorMes.ColumnHeadersHeight = 25;
            this.dtGridPorMes.Location = new System.Drawing.Point(6, 64);
            this.dtGridPorMes.Name = "dtGridPorMes";
            this.dtGridPorMes.ReadOnly = true;
            this.dtGridPorMes.RowHeadersWidth = 45;
            this.dtGridPorMes.Size = new System.Drawing.Size(869, 355);
            this.dtGridPorMes.TabIndex = 7;
            // 
            // tabReporteSemanal
            // 
            this.tabReporteSemanal.Controls.Add(this.dtGridPorSem);
            this.tabReporteSemanal.Controls.Add(this.boxElegirSemana);
            this.tabReporteSemanal.Location = new System.Drawing.Point(4, 24);
            this.tabReporteSemanal.Name = "tabReporteSemanal";
            this.tabReporteSemanal.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporteSemanal.Size = new System.Drawing.Size(881, 423);
            this.tabReporteSemanal.TabIndex = 1;
            this.tabReporteSemanal.Text = "Reporte Semanal";
            this.tabReporteSemanal.UseVisualStyleBackColor = true;
            // 
            // dtGridPorSem
            // 
            this.dtGridPorSem.AllowUserToAddRows = false;
            this.dtGridPorSem.AllowUserToDeleteRows = false;
            this.dtGridPorSem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridPorSem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridPorSem.ColumnHeadersHeight = 25;
            this.dtGridPorSem.Location = new System.Drawing.Point(5, 64);
            this.dtGridPorSem.Name = "dtGridPorSem";
            this.dtGridPorSem.ReadOnly = true;
            this.dtGridPorSem.RowHeadersWidth = 45;
            this.dtGridPorSem.Size = new System.Drawing.Size(869, 355);
            this.dtGridPorSem.TabIndex = 9;
            // 
            // boxElegirSemana
            // 
            this.boxElegirSemana.Controls.Add(this.btnBuscarXSem);
            this.boxElegirSemana.Controls.Add(this.lblHasta);
            this.boxElegirSemana.Controls.Add(this.lblDesde);
            this.boxElegirSemana.Controls.Add(this.dtPickerHasta);
            this.boxElegirSemana.Controls.Add(this.dtPickerDesde);
            this.boxElegirSemana.Location = new System.Drawing.Point(5, 6);
            this.boxElegirSemana.Name = "boxElegirSemana";
            this.boxElegirSemana.Size = new System.Drawing.Size(409, 54);
            this.boxElegirSemana.TabIndex = 8;
            this.boxElegirSemana.TabStop = false;
            this.boxElegirSemana.Text = "Elegir Semana";
            // 
            // btnBuscarXSem
            // 
            this.btnBuscarXSem.Location = new System.Drawing.Point(324, 23);
            this.btnBuscarXSem.Name = "btnBuscarXSem";
            this.btnBuscarXSem.Size = new System.Drawing.Size(71, 21);
            this.btnBuscarXSem.TabIndex = 4;
            this.btnBuscarXSem.Text = "Buscar";
            this.btnBuscarXSem.UseVisualStyleBackColor = true;
            this.btnBuscarXSem.Click += new System.EventHandler(this.btnBuscarXSem_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(166, 25);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(37, 15);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 25);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(39, 15);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // dtPickerHasta
            // 
            this.dtPickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerHasta.Location = new System.Drawing.Point(206, 22);
            this.dtPickerHasta.Name = "dtPickerHasta";
            this.dtPickerHasta.Size = new System.Drawing.Size(100, 23);
            this.dtPickerHasta.TabIndex = 1;
            // 
            // dtPickerDesde
            // 
            this.dtPickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDesde.Location = new System.Drawing.Point(47, 23);
            this.dtPickerDesde.Name = "dtPickerDesde";
            this.dtPickerDesde.Size = new System.Drawing.Size(100, 23);
            this.dtPickerDesde.TabIndex = 0;
            // 
            // tabReporteVendedor
            // 
            this.tabReporteVendedor.Controls.Add(this.dtGridPorVend);
            this.tabReporteVendedor.Controls.Add(this.boxElegirVendedor);
            this.tabReporteVendedor.Location = new System.Drawing.Point(4, 24);
            this.tabReporteVendedor.Name = "tabReporteVendedor";
            this.tabReporteVendedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporteVendedor.Size = new System.Drawing.Size(881, 423);
            this.tabReporteVendedor.TabIndex = 2;
            this.tabReporteVendedor.Text = "Reporte por Vendedor";
            this.tabReporteVendedor.UseVisualStyleBackColor = true;
            // 
            // dtGridPorVend
            // 
            this.dtGridPorVend.AllowUserToAddRows = false;
            this.dtGridPorVend.AllowUserToDeleteRows = false;
            this.dtGridPorVend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridPorVend.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridPorVend.ColumnHeadersHeight = 25;
            this.dtGridPorVend.Location = new System.Drawing.Point(5, 67);
            this.dtGridPorVend.Name = "dtGridPorVend";
            this.dtGridPorVend.ReadOnly = true;
            this.dtGridPorVend.RowHeadersWidth = 45;
            this.dtGridPorVend.Size = new System.Drawing.Size(869, 355);
            this.dtGridPorVend.TabIndex = 10;
            // 
            // boxElegirVendedor
            // 
            this.boxElegirVendedor.Controls.Add(this.btnBuscarXVend);
            this.boxElegirVendedor.Controls.Add(this.cmbBoxVendedor);
            this.boxElegirVendedor.Location = new System.Drawing.Point(5, 6);
            this.boxElegirVendedor.Name = "boxElegirVendedor";
            this.boxElegirVendedor.Size = new System.Drawing.Size(389, 55);
            this.boxElegirVendedor.TabIndex = 8;
            this.boxElegirVendedor.TabStop = false;
            this.boxElegirVendedor.Text = "Elegir Vendedor";
            // 
            // btnBuscarXVend
            // 
            this.btnBuscarXVend.Location = new System.Drawing.Point(306, 23);
            this.btnBuscarXVend.Name = "btnBuscarXVend";
            this.btnBuscarXVend.Size = new System.Drawing.Size(71, 21);
            this.btnBuscarXVend.TabIndex = 5;
            this.btnBuscarXVend.Text = "Buscar";
            this.btnBuscarXVend.UseVisualStyleBackColor = true;
            this.btnBuscarXVend.Click += new System.EventHandler(this.btnBuscarXVend_Click);
            // 
            // cmbBoxVendedor
            // 
            this.cmbBoxVendedor.FormattingEnabled = true;
            this.cmbBoxVendedor.Location = new System.Drawing.Point(6, 22);
            this.cmbBoxVendedor.Name = "cmbBoxVendedor";
            this.cmbBoxVendedor.Size = new System.Drawing.Size(293, 23);
            this.cmbBoxVendedor.TabIndex = 0;
            // 
            // tabEncargado
            // 
            this.tabEncargado.Controls.Add(this.tabControl3);
            this.tabEncargado.Location = new System.Drawing.Point(4, 24);
            this.tabEncargado.Name = "tabEncargado";
            this.tabEncargado.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncargado.Size = new System.Drawing.Size(903, 460);
            this.tabEncargado.TabIndex = 1;
            this.tabEncargado.Text = "Encargado";
            this.tabEncargado.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Controls.Add(this.tabPage12);
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(894, 456);
            this.tabControl3.TabIndex = 0;
            this.tabControl3.SelectedIndexChanged += new System.EventHandler(this.tabControl3_SelectedIndexChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dgvProductos);
            this.tabPage8.Controls.Add(this.groupBox4);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(886, 428);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Crear Producto";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(327, 6);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 45;
            this.dgvProductos.Size = new System.Drawing.Size(558, 416);
            this.dgvProductos.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudPrecio);
            this.groupBox4.Controls.Add(this.btnEncargadoLimpiarCamposCP);
            this.groupBox4.Controls.Add(this.btnEncargadoCP);
            this.groupBox4.Controls.Add(this.cmbHabilitado);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.nudCantidad);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtDescripcion);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 416);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Producto";
            // 
            // nudPrecio
            // 
            this.nudPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.Location = new System.Drawing.Point(11, 118);
            this.nudPrecio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 25);
            this.nudPrecio.TabIndex = 10;
            // 
            // btnEncargadoLimpiarCamposCP
            // 
            this.btnEncargadoLimpiarCamposCP.Location = new System.Drawing.Point(9, 375);
            this.btnEncargadoLimpiarCamposCP.Name = "btnEncargadoLimpiarCamposCP";
            this.btnEncargadoLimpiarCamposCP.Size = new System.Drawing.Size(147, 35);
            this.btnEncargadoLimpiarCamposCP.TabIndex = 9;
            this.btnEncargadoLimpiarCamposCP.Text = "Limpiar";
            this.btnEncargadoLimpiarCamposCP.UseVisualStyleBackColor = true;
            this.btnEncargadoLimpiarCamposCP.Click += new System.EventHandler(this.btnEncargadoLimpiarCamposCP_Click);
            // 
            // btnEncargadoCP
            // 
            this.btnEncargadoCP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEncargadoCP.Location = new System.Drawing.Point(162, 375);
            this.btnEncargadoCP.Margin = new System.Windows.Forms.Padding(0);
            this.btnEncargadoCP.Name = "btnEncargadoCP";
            this.btnEncargadoCP.Size = new System.Drawing.Size(147, 35);
            this.btnEncargadoCP.TabIndex = 8;
            this.btnEncargadoCP.Text = "Crear";
            this.btnEncargadoCP.UseVisualStyleBackColor = false;
            this.btnEncargadoCP.Click += new System.EventHandler(this.btnEncargadoCP_Click);
            // 
            // cmbHabilitado
            // 
            this.cmbHabilitado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHabilitado.FormattingEnabled = true;
            this.cmbHabilitado.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbHabilitado.Location = new System.Drawing.Point(10, 251);
            this.cmbHabilitado.Name = "cmbHabilitado";
            this.cmbHabilitado.Size = new System.Drawing.Size(121, 25);
            this.cmbHabilitado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Habilitado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(11, 182);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 25);
            this.nudCantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(11, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(283, 25);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox36);
            this.tabPage9.Controls.Add(this.groupBox9);
            this.tabPage9.Controls.Add(this.groupBox10);
            this.tabPage9.Controls.Add(this.dgvModificarProducto1);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(886, 428);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Modificar Producto";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.txtIdModificar1);
            this.groupBox36.Controls.Add(this.label15);
            this.groupBox36.Controls.Add(this.nudPrecioModificar1);
            this.groupBox36.Controls.Add(this.btnLimpiarCamposDatosProductoMP);
            this.groupBox36.Controls.Add(this.btnModificarDatosProductoMP);
            this.groupBox36.Controls.Add(this.cmbHabilitadoModificar1);
            this.groupBox36.Controls.Add(this.label5);
            this.groupBox36.Controls.Add(this.label6);
            this.groupBox36.Controls.Add(this.nudCantidadModificar1);
            this.groupBox36.Controls.Add(this.label7);
            this.groupBox36.Controls.Add(this.txtDescripcionModificar1);
            this.groupBox36.Controls.Add(this.label8);
            this.groupBox36.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox36.Location = new System.Drawing.Point(8, 84);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(319, 338);
            this.groupBox36.TabIndex = 13;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Datos del Producto";
            // 
            // txtIdModificar1
            // 
            this.txtIdModificar1.Enabled = false;
            this.txtIdModificar1.Location = new System.Drawing.Point(238, 24);
            this.txtIdModificar1.Name = "txtIdModificar1";
            this.txtIdModificar1.Size = new System.Drawing.Size(75, 25);
            this.txtIdModificar1.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(151, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "Id Producto";
            // 
            // nudPrecioModificar1
            // 
            this.nudPrecioModificar1.Location = new System.Drawing.Point(13, 153);
            this.nudPrecioModificar1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecioModificar1.Name = "nudPrecioModificar1";
            this.nudPrecioModificar1.Size = new System.Drawing.Size(120, 25);
            this.nudPrecioModificar1.TabIndex = 10;
            // 
            // btnLimpiarCamposDatosProductoMP
            // 
            this.btnLimpiarCamposDatosProductoMP.Location = new System.Drawing.Point(6, 298);
            this.btnLimpiarCamposDatosProductoMP.Name = "btnLimpiarCamposDatosProductoMP";
            this.btnLimpiarCamposDatosProductoMP.Size = new System.Drawing.Size(147, 34);
            this.btnLimpiarCamposDatosProductoMP.TabIndex = 9;
            this.btnLimpiarCamposDatosProductoMP.Text = "Limpiar";
            this.btnLimpiarCamposDatosProductoMP.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposDatosProductoMP.Click += new System.EventHandler(this.btnLimpiarCamposDatosProductoMP_Click);
            // 
            // btnModificarDatosProductoMP
            // 
            this.btnModificarDatosProductoMP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificarDatosProductoMP.Location = new System.Drawing.Point(162, 298);
            this.btnModificarDatosProductoMP.Name = "btnModificarDatosProductoMP";
            this.btnModificarDatosProductoMP.Size = new System.Drawing.Size(147, 34);
            this.btnModificarDatosProductoMP.TabIndex = 8;
            this.btnModificarDatosProductoMP.Text = "Modificar";
            this.btnModificarDatosProductoMP.UseVisualStyleBackColor = false;
            this.btnModificarDatosProductoMP.Click += new System.EventHandler(this.btnModificarDatosProductoMP_Click);
            // 
            // cmbHabilitadoModificar1
            // 
            this.cmbHabilitadoModificar1.FormattingEnabled = true;
            this.cmbHabilitadoModificar1.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbHabilitadoModificar1.Location = new System.Drawing.Point(12, 229);
            this.cmbHabilitadoModificar1.Name = "cmbHabilitadoModificar1";
            this.cmbHabilitadoModificar1.Size = new System.Drawing.Size(121, 25);
            this.cmbHabilitadoModificar1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Habilitado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Precio";
            // 
            // nudCantidadModificar1
            // 
            this.nudCantidadModificar1.Enabled = false;
            this.nudCantidadModificar1.Location = new System.Drawing.Point(165, 153);
            this.nudCantidadModificar1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCantidadModificar1.Name = "nudCantidadModificar1";
            this.nudCantidadModificar1.Size = new System.Drawing.Size(120, 25);
            this.nudCantidadModificar1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad";
            // 
            // txtDescripcionModificar1
            // 
            this.txtDescripcionModificar1.Location = new System.Drawing.Point(12, 96);
            this.txtDescripcionModificar1.Name = "txtDescripcionModificar1";
            this.txtDescripcionModificar1.Size = new System.Drawing.Size(283, 25);
            this.txtDescripcionModificar1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descripcion";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnLimpiarCamposMP);
            this.groupBox9.Controls.Add(this.btnBuscarProductoMP);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(607, 9);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(270, 69);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // btnLimpiarCamposMP
            // 
            this.btnLimpiarCamposMP.Location = new System.Drawing.Point(143, 27);
            this.btnLimpiarCamposMP.Name = "btnLimpiarCamposMP";
            this.btnLimpiarCamposMP.Size = new System.Drawing.Size(100, 25);
            this.btnLimpiarCamposMP.TabIndex = 1;
            this.btnLimpiarCamposMP.Text = "Limpiar";
            this.btnLimpiarCamposMP.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposMP.Click += new System.EventHandler(this.btnLimpiarCamposMP_Click);
            // 
            // btnBuscarProductoMP
            // 
            this.btnBuscarProductoMP.Location = new System.Drawing.Point(25, 27);
            this.btnBuscarProductoMP.Name = "btnBuscarProductoMP";
            this.btnBuscarProductoMP.Size = new System.Drawing.Size(100, 25);
            this.btnBuscarProductoMP.TabIndex = 0;
            this.btnBuscarProductoMP.Text = "Buscar";
            this.btnBuscarProductoMP.UseVisualStyleBackColor = true;
            this.btnBuscarProductoMP.Click += new System.EventHandler(this.btnBuscarProductoMP_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtDescripcionModificar);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(8, 9);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(593, 69);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Buscar Articulo";
            this.groupBox10.Enter += new System.EventHandler(this.groupBox10_Enter);
            // 
            // txtDescripcionModificar
            // 
            this.txtDescripcionModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionModificar.Location = new System.Drawing.Point(94, 29);
            this.txtDescripcionModificar.Name = "txtDescripcionModificar";
            this.txtDescripcionModificar.Size = new System.Drawing.Size(485, 25);
            this.txtDescripcionModificar.TabIndex = 3;
            this.txtDescripcionModificar.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Descripcion";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dgvModificarProducto1
            // 
            this.dgvModificarProducto1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModificarProducto1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarProducto1.Location = new System.Drawing.Point(333, 84);
            this.dgvModificarProducto1.Name = "dgvModificarProducto1";
            this.dgvModificarProducto1.RowHeadersWidth = 45;
            this.dgvModificarProducto1.Size = new System.Drawing.Size(545, 338);
            this.dgvModificarProducto1.TabIndex = 10;
            this.dgvModificarProducto1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.groupBox11);
            this.tabPage10.Controls.Add(this.dgvStock);
            this.tabPage10.Location = new System.Drawing.Point(4, 24);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(886, 428);
            this.tabPage10.TabIndex = 2;
            this.tabPage10.Text = "Crear Listado";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnGenerarListado);
            this.groupBox11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(9, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(868, 58);
            this.groupBox11.TabIndex = 12;
            this.groupBox11.TabStop = false;
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerarListado.Location = new System.Drawing.Point(6, 19);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(101, 29);
            this.btnGenerarListado.TabIndex = 1;
            this.btnGenerarListado.Text = "Generar";
            this.btnGenerarListado.UseVisualStyleBackColor = false;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(9, 73);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 45;
            this.dgvStock.Size = new System.Drawing.Size(869, 349);
            this.dgvStock.TabIndex = 10;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.groupBox12);
            this.tabPage11.Controls.Add(this.dgvAlerta);
            this.tabPage11.Location = new System.Drawing.Point(4, 24);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(886, 428);
            this.tabPage11.TabIndex = 3;
            this.tabPage11.Text = "Crear Alerta";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnGenerarAlerta);
            this.groupBox12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(9, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(868, 55);
            this.groupBox12.TabIndex = 14;
            this.groupBox12.TabStop = false;
            // 
            // btnGenerarAlerta
            // 
            this.btnGenerarAlerta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerarAlerta.Location = new System.Drawing.Point(6, 18);
            this.btnGenerarAlerta.Name = "btnGenerarAlerta";
            this.btnGenerarAlerta.Size = new System.Drawing.Size(101, 27);
            this.btnGenerarAlerta.TabIndex = 0;
            this.btnGenerarAlerta.Text = "Generar Alerta";
            this.btnGenerarAlerta.UseVisualStyleBackColor = false;
            this.btnGenerarAlerta.Click += new System.EventHandler(this.btnGenerarAlerta_Click);
            // 
            // dgvAlerta
            // 
            this.dgvAlerta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlerta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerta.Location = new System.Drawing.Point(9, 64);
            this.dgvAlerta.Name = "dgvAlerta";
            this.dgvAlerta.RowHeadersWidth = 45;
            this.dgvAlerta.Size = new System.Drawing.Size(869, 358);
            this.dgvAlerta.TabIndex = 13;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.groupBox13);
            this.tabPage12.Controls.Add(this.groupBox14);
            this.tabPage12.Controls.Add(this.groupBox37);
            this.tabPage12.Controls.Add(this.dgvCargarStock);
            this.tabPage12.Location = new System.Drawing.Point(4, 24);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(886, 428);
            this.tabPage12.TabIndex = 4;
            this.tabPage12.Text = "Cargar Stock";
            this.tabPage12.UseVisualStyleBackColor = true;
            this.tabPage12.Click += new System.EventHandler(this.tabPage12_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtDescripcionBCargarStock);
            this.groupBox13.Controls.Add(this.label14);
            this.groupBox13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(6, 9);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(593, 69);
            this.groupBox13.TabIndex = 15;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Buscar Articulo";
            // 
            // txtDescripcionBCargarStock
            // 
            this.txtDescripcionBCargarStock.Location = new System.Drawing.Point(93, 32);
            this.txtDescripcionBCargarStock.Name = "txtDescripcionBCargarStock";
            this.txtDescripcionBCargarStock.Size = new System.Drawing.Size(385, 25);
            this.txtDescripcionBCargarStock.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Descripcion";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnLimpiarCamposCS);
            this.groupBox14.Controls.Add(this.btnBuscarProductoCS);
            this.groupBox14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(605, 9);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(270, 69);
            this.groupBox14.TabIndex = 16;
            this.groupBox14.TabStop = false;
            // 
            // btnLimpiarCamposCS
            // 
            this.btnLimpiarCamposCS.Location = new System.Drawing.Point(142, 26);
            this.btnLimpiarCamposCS.Name = "btnLimpiarCamposCS";
            this.btnLimpiarCamposCS.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiarCamposCS.TabIndex = 1;
            this.btnLimpiarCamposCS.Text = "Limpiar";
            this.btnLimpiarCamposCS.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposCS.Click += new System.EventHandler(this.btnLimpiarCamposCS_Click);
            // 
            // btnBuscarProductoCS
            // 
            this.btnBuscarProductoCS.Location = new System.Drawing.Point(36, 26);
            this.btnBuscarProductoCS.Name = "btnBuscarProductoCS";
            this.btnBuscarProductoCS.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarProductoCS.TabIndex = 0;
            this.btnBuscarProductoCS.Text = "Buscar";
            this.btnBuscarProductoCS.UseVisualStyleBackColor = true;
            this.btnBuscarProductoCS.Click += new System.EventHandler(this.btnBuscarProductoCS_Click);
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.txtIdCargarStock1);
            this.groupBox37.Controls.Add(this.label9);
            this.groupBox37.Controls.Add(this.btnCargarStock);
            this.groupBox37.Controls.Add(this.nudCantidadCargarStock1);
            this.groupBox37.Controls.Add(this.label11);
            this.groupBox37.Controls.Add(this.txtDescripcionCargarStock1);
            this.groupBox37.Controls.Add(this.label12);
            this.groupBox37.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox37.Location = new System.Drawing.Point(6, 84);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(869, 88);
            this.groupBox37.TabIndex = 14;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "Datos del Producto";
            // 
            // txtIdCargarStock1
            // 
            this.txtIdCargarStock1.Enabled = false;
            this.txtIdCargarStock1.Location = new System.Drawing.Point(9, 52);
            this.txtIdCargarStock1.Name = "txtIdCargarStock1";
            this.txtIdCargarStock1.Size = new System.Drawing.Size(100, 25);
            this.txtIdCargarStock1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Id Producto";
            // 
            // btnCargarStock
            // 
            this.btnCargarStock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCargarStock.Location = new System.Drawing.Point(752, 42);
            this.btnCargarStock.Name = "btnCargarStock";
            this.btnCargarStock.Size = new System.Drawing.Size(111, 37);
            this.btnCargarStock.TabIndex = 8;
            this.btnCargarStock.Text = "Cargar Stock";
            this.btnCargarStock.UseVisualStyleBackColor = false;
            this.btnCargarStock.Click += new System.EventHandler(this.btnCargarStock_Click);
            // 
            // nudCantidadCargarStock1
            // 
            this.nudCantidadCargarStock1.Enabled = false;
            this.nudCantidadCargarStock1.Location = new System.Drawing.Point(492, 53);
            this.nudCantidadCargarStock1.Name = "nudCantidadCargarStock1";
            this.nudCantidadCargarStock1.Size = new System.Drawing.Size(120, 25);
            this.nudCantidadCargarStock1.TabIndex = 3;
            this.nudCantidadCargarStock1.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cantidad a Agregar";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtDescripcionCargarStock1
            // 
            this.txtDescripcionCargarStock1.Enabled = false;
            this.txtDescripcionCargarStock1.Location = new System.Drawing.Point(115, 52);
            this.txtDescripcionCargarStock1.Name = "txtDescripcionCargarStock1";
            this.txtDescripcionCargarStock1.Size = new System.Drawing.Size(363, 25);
            this.txtDescripcionCargarStock1.TabIndex = 1;
            this.txtDescripcionCargarStock1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Descripcion";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dgvCargarStock
            // 
            this.dgvCargarStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargarStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargarStock.Location = new System.Drawing.Point(6, 178);
            this.dgvCargarStock.Name = "dgvCargarStock";
            this.dgvCargarStock.RowHeadersWidth = 45;
            this.dgvCargarStock.Size = new System.Drawing.Size(872, 244);
            this.dgvCargarStock.TabIndex = 10;
            this.dgvCargarStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargarStock_CellContentClick);
            // 
            // tabVendedor
            // 
            this.tabVendedor.Controls.Add(this.tabControl4);
            this.tabVendedor.Location = new System.Drawing.Point(4, 24);
            this.tabVendedor.Name = "tabVendedor";
            this.tabVendedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendedor.Size = new System.Drawing.Size(903, 460);
            this.tabVendedor.TabIndex = 2;
            this.tabVendedor.Text = "Vendedor";
            this.tabVendedor.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage13);
            this.tabControl4.Controls.Add(this.tabPage14);
            this.tabControl4.Location = new System.Drawing.Point(0, 1);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(899, 456);
            this.tabControl4.TabIndex = 1;
            // 
            // tabPage13
            // 
            this.tabPage13.BackColor = System.Drawing.Color.Transparent;
            this.tabPage13.Controls.Add(this.groupBox15);
            this.tabPage13.Location = new System.Drawing.Point(4, 24);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(891, 428);
            this.tabPage13.TabIndex = 0;
            this.tabPage13.Text = "Cargar Cliente";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.benerarCliente_btn);
            this.groupBox15.Controls.Add(this.direccionCliente_tbx);
            this.groupBox15.Controls.Add(this.telefonoCliente_tbx);
            this.groupBox15.Controls.Add(this.cuitCliente_tbx);
            this.groupBox15.Controls.Add(this.dniCliente_tbx);
            this.groupBox15.Controls.Add(this.nombrCliente_tbx);
            this.groupBox15.Controls.Add(this.apellidoCliente_tbx);
            this.groupBox15.Controls.Add(this.direccionCliente_lbl);
            this.groupBox15.Controls.Add(this.telefonoCliente_lbl);
            this.groupBox15.Controls.Add(this.cuitCliente_lbl);
            this.groupBox15.Controls.Add(this.dniCliente_lbl);
            this.groupBox15.Controls.Add(this.nombreCliente_lbl);
            this.groupBox15.Controls.Add(this.apellidoCliente_lbl);
            this.groupBox15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(17, 16);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(868, 406);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Datos del Cliente";
            // 
            // benerarCliente_btn
            // 
            this.benerarCliente_btn.BackColor = System.Drawing.Color.Transparent;
            this.benerarCliente_btn.Location = new System.Drawing.Point(719, 362);
            this.benerarCliente_btn.Name = "benerarCliente_btn";
            this.benerarCliente_btn.Size = new System.Drawing.Size(143, 38);
            this.benerarCliente_btn.TabIndex = 1;
            this.benerarCliente_btn.Text = "Nuevo Cliente";
            this.benerarCliente_btn.UseVisualStyleBackColor = false;
            this.benerarCliente_btn.Click += new System.EventHandler(this.benerarCliente_btn_Click_1);
            // 
            // direccionCliente_tbx
            // 
            this.direccionCliente_tbx.Location = new System.Drawing.Point(77, 253);
            this.direccionCliente_tbx.Name = "direccionCliente_tbx";
            this.direccionCliente_tbx.Size = new System.Drawing.Size(311, 25);
            this.direccionCliente_tbx.TabIndex = 11;
            // 
            // telefonoCliente_tbx
            // 
            this.telefonoCliente_tbx.Location = new System.Drawing.Point(76, 208);
            this.telefonoCliente_tbx.Name = "telefonoCliente_tbx";
            this.telefonoCliente_tbx.Size = new System.Drawing.Size(169, 25);
            this.telefonoCliente_tbx.TabIndex = 10;
            // 
            // cuitCliente_tbx
            // 
            this.cuitCliente_tbx.Location = new System.Drawing.Point(76, 165);
            this.cuitCliente_tbx.Name = "cuitCliente_tbx";
            this.cuitCliente_tbx.Size = new System.Drawing.Size(169, 25);
            this.cuitCliente_tbx.TabIndex = 9;
            // 
            // dniCliente_tbx
            // 
            this.dniCliente_tbx.Location = new System.Drawing.Point(76, 122);
            this.dniCliente_tbx.Name = "dniCliente_tbx";
            this.dniCliente_tbx.Size = new System.Drawing.Size(169, 25);
            this.dniCliente_tbx.TabIndex = 8;
            // 
            // nombrCliente_tbx
            // 
            this.nombrCliente_tbx.Location = new System.Drawing.Point(77, 80);
            this.nombrCliente_tbx.Name = "nombrCliente_tbx";
            this.nombrCliente_tbx.Size = new System.Drawing.Size(311, 25);
            this.nombrCliente_tbx.TabIndex = 7;
            // 
            // apellidoCliente_tbx
            // 
            this.apellidoCliente_tbx.Location = new System.Drawing.Point(76, 36);
            this.apellidoCliente_tbx.MaxLength = 50;
            this.apellidoCliente_tbx.Name = "apellidoCliente_tbx";
            this.apellidoCliente_tbx.Size = new System.Drawing.Size(312, 25);
            this.apellidoCliente_tbx.TabIndex = 6;
            // 
            // direccionCliente_lbl
            // 
            this.direccionCliente_lbl.AutoSize = true;
            this.direccionCliente_lbl.Location = new System.Drawing.Point(12, 256);
            this.direccionCliente_lbl.Name = "direccionCliente_lbl";
            this.direccionCliente_lbl.Size = new System.Drawing.Size(65, 19);
            this.direccionCliente_lbl.TabIndex = 5;
            this.direccionCliente_lbl.Text = "Direccion";
            // 
            // telefonoCliente_lbl
            // 
            this.telefonoCliente_lbl.AutoSize = true;
            this.telefonoCliente_lbl.Location = new System.Drawing.Point(12, 211);
            this.telefonoCliente_lbl.Name = "telefonoCliente_lbl";
            this.telefonoCliente_lbl.Size = new System.Drawing.Size(60, 19);
            this.telefonoCliente_lbl.TabIndex = 4;
            this.telefonoCliente_lbl.Text = "Teléfono";
            // 
            // cuitCliente_lbl
            // 
            this.cuitCliente_lbl.AutoSize = true;
            this.cuitCliente_lbl.Location = new System.Drawing.Point(12, 168);
            this.cuitCliente_lbl.Name = "cuitCliente_lbl";
            this.cuitCliente_lbl.Size = new System.Drawing.Size(39, 19);
            this.cuitCliente_lbl.TabIndex = 3;
            this.cuitCliente_lbl.Text = "CUIT";
            // 
            // dniCliente_lbl
            // 
            this.dniCliente_lbl.AutoSize = true;
            this.dniCliente_lbl.Location = new System.Drawing.Point(12, 122);
            this.dniCliente_lbl.Name = "dniCliente_lbl";
            this.dniCliente_lbl.Size = new System.Drawing.Size(33, 19);
            this.dniCliente_lbl.TabIndex = 2;
            this.dniCliente_lbl.Text = "DNI";
            // 
            // nombreCliente_lbl
            // 
            this.nombreCliente_lbl.AutoSize = true;
            this.nombreCliente_lbl.Location = new System.Drawing.Point(12, 80);
            this.nombreCliente_lbl.Name = "nombreCliente_lbl";
            this.nombreCliente_lbl.Size = new System.Drawing.Size(59, 19);
            this.nombreCliente_lbl.TabIndex = 1;
            this.nombreCliente_lbl.Text = "Nombre";
            // 
            // apellidoCliente_lbl
            // 
            this.apellidoCliente_lbl.AutoSize = true;
            this.apellidoCliente_lbl.Location = new System.Drawing.Point(12, 39);
            this.apellidoCliente_lbl.Name = "apellidoCliente_lbl";
            this.apellidoCliente_lbl.Size = new System.Drawing.Size(58, 19);
            this.apellidoCliente_lbl.TabIndex = 0;
            this.apellidoCliente_lbl.Text = "Apellido";
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.groupBox1);
            this.tabPage14.Controls.Add(this.buscarCliente_gbx);
            this.tabPage14.Controls.Add(this.dbDatosCliente_dg);
            this.tabPage14.Location = new System.Drawing.Point(4, 24);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(891, 428);
            this.tabPage14.TabIndex = 1;
            this.tabPage14.Text = "Modificar Cliente";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iniciarVenta_btn);
            this.groupBox1.Controls.Add(this.modificarcliente_btn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(573, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 66);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // iniciarVenta_btn
            // 
            this.iniciarVenta_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iniciarVenta_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarVenta_btn.Location = new System.Drawing.Point(161, 22);
            this.iniciarVenta_btn.Name = "iniciarVenta_btn";
            this.iniciarVenta_btn.Size = new System.Drawing.Size(145, 33);
            this.iniciarVenta_btn.TabIndex = 13;
            this.iniciarVenta_btn.Text = "Iniciar Venta";
            this.iniciarVenta_btn.UseVisualStyleBackColor = false;
            this.iniciarVenta_btn.Click += new System.EventHandler(this.iniciarVenta_btn_Click_1);
            // 
            // modificarcliente_btn
            // 
            this.modificarcliente_btn.BackColor = System.Drawing.Color.Transparent;
            this.modificarcliente_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarcliente_btn.Location = new System.Drawing.Point(10, 21);
            this.modificarcliente_btn.Name = "modificarcliente_btn";
            this.modificarcliente_btn.Size = new System.Drawing.Size(145, 34);
            this.modificarcliente_btn.TabIndex = 14;
            this.modificarcliente_btn.Text = "Modificar cliente";
            this.modificarcliente_btn.UseVisualStyleBackColor = false;
            this.modificarcliente_btn.Click += new System.EventHandler(this.modificarcliente_btn_Click_1);
            // 
            // buscarCliente_gbx
            // 
            this.buscarCliente_gbx.Controls.Add(this.dni_tbx);
            this.buscarCliente_gbx.Controls.Add(this.dni_lbl);
            this.buscarCliente_gbx.Controls.Add(this.buscarCliente_btn);
            this.buscarCliente_gbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCliente_gbx.Location = new System.Drawing.Point(10, 9);
            this.buscarCliente_gbx.Name = "buscarCliente_gbx";
            this.buscarCliente_gbx.Size = new System.Drawing.Size(351, 60);
            this.buscarCliente_gbx.TabIndex = 11;
            this.buscarCliente_gbx.TabStop = false;
            // 
            // dni_tbx
            // 
            this.dni_tbx.Location = new System.Drawing.Point(45, 21);
            this.dni_tbx.Name = "dni_tbx";
            this.dni_tbx.Size = new System.Drawing.Size(200, 25);
            this.dni_tbx.TabIndex = 1;
            // 
            // dni_lbl
            // 
            this.dni_lbl.AutoSize = true;
            this.dni_lbl.Location = new System.Drawing.Point(6, 24);
            this.dni_lbl.Name = "dni_lbl";
            this.dni_lbl.Size = new System.Drawing.Size(33, 19);
            this.dni_lbl.TabIndex = 0;
            this.dni_lbl.Text = "DNI";
            // 
            // buscarCliente_btn
            // 
            this.buscarCliente_btn.BackColor = System.Drawing.Color.Transparent;
            this.buscarCliente_btn.Location = new System.Drawing.Point(262, 17);
            this.buscarCliente_btn.Name = "buscarCliente_btn";
            this.buscarCliente_btn.Size = new System.Drawing.Size(75, 30);
            this.buscarCliente_btn.TabIndex = 12;
            this.buscarCliente_btn.Text = "Buscar";
            this.buscarCliente_btn.UseVisualStyleBackColor = false;
            this.buscarCliente_btn.Click += new System.EventHandler(this.buscarCliente_btn_Click_1);
            // 
            // dbDatosCliente_dg
            // 
            this.dbDatosCliente_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDatosCliente_dg.Location = new System.Drawing.Point(10, 75);
            this.dbDatosCliente_dg.Name = "dbDatosCliente_dg";
            this.dbDatosCliente_dg.RowHeadersWidth = 45;
            this.dbDatosCliente_dg.Size = new System.Drawing.Size(875, 275);
            this.dbDatosCliente_dg.TabIndex = 10;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabControl5);
            this.tabAdmin.Location = new System.Drawing.Point(4, 24);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(903, 460);
            this.tabAdmin.TabIndex = 3;
            this.tabAdmin.Text = "Administrador";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage18);
            this.tabControl5.Location = new System.Drawing.Point(2, 6);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(895, 450);
            this.tabControl5.TabIndex = 1;
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.txbLegajo);
            this.tabPage18.Controls.Add(this.txbReingContr);
            this.tabPage18.Controls.Add(this.txbContrasenia);
            this.tabPage18.Controls.Add(this.txbNomUsuario);
            this.tabPage18.Controls.Add(this.label10);
            this.tabPage18.Controls.Add(this.dgvListaEmpleados);
            this.tabPage18.Controls.Add(this.btnSalir);
            this.tabPage18.Controls.Add(this.btnCancUsu);
            this.tabPage18.Controls.Add(this.btnRegistrar);
            this.tabPage18.Controls.Add(this.lblRepContr);
            this.tabPage18.Controls.Add(this.lblContr);
            this.tabPage18.Controls.Add(this.lblNombUsu);
            this.tabPage18.Controls.Add(this.cBoxPermisos);
            this.tabPage18.Controls.Add(this.lblpermisos);
            this.tabPage18.Location = new System.Drawing.Point(4, 24);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(887, 422);
            this.tabPage18.TabIndex = 0;
            this.tabPage18.Text = "Crear Usuarios";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // txbLegajo
            // 
            this.txbLegajo.Enabled = false;
            this.txbLegajo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLegajo.Location = new System.Drawing.Point(160, 26);
            this.txbLegajo.Name = "txbLegajo";
            this.txbLegajo.Size = new System.Drawing.Size(121, 25);
            this.txbLegajo.TabIndex = 29;
            // 
            // txbReingContr
            // 
            this.txbReingContr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReingContr.Location = new System.Drawing.Point(160, 199);
            this.txbReingContr.Name = "txbReingContr";
            this.txbReingContr.Size = new System.Drawing.Size(121, 25);
            this.txbReingContr.TabIndex = 23;
            // 
            // txbContrasenia
            // 
            this.txbContrasenia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContrasenia.Location = new System.Drawing.Point(160, 152);
            this.txbContrasenia.Name = "txbContrasenia";
            this.txbContrasenia.Size = new System.Drawing.Size(121, 25);
            this.txbContrasenia.TabIndex = 22;
            // 
            // txbNomUsuario
            // 
            this.txbNomUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomUsuario.Location = new System.Drawing.Point(160, 107);
            this.txbNomUsuario.Name = "txbNomUsuario";
            this.txbNomUsuario.Size = new System.Drawing.Size(121, 25);
            this.txbNomUsuario.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Legajo";
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.AllowUserToAddRows = false;
            this.dgvListaEmpleados.AllowUserToDeleteRows = false;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Location = new System.Drawing.Point(432, 14);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.ReadOnly = true;
            this.dgvListaEmpleados.RowHeadersWidth = 45;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(437, 396);
            this.dgvListaEmpleados.TabIndex = 27;
            this.dgvListaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(331, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 30);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancUsu
            // 
            this.btnCancUsu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancUsu.Location = new System.Drawing.Point(110, 378);
            this.btnCancUsu.Name = "btnCancUsu";
            this.btnCancUsu.Size = new System.Drawing.Size(89, 30);
            this.btnCancUsu.TabIndex = 25;
            this.btnCancUsu.Text = "Cancelar";
            this.btnCancUsu.UseVisualStyleBackColor = true;
            this.btnCancUsu.Click += new System.EventHandler(this.btnCancUsu_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(15, 378);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 30);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblRepContr
            // 
            this.lblRepContr.AutoSize = true;
            this.lblRepContr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepContr.Location = new System.Drawing.Point(18, 202);
            this.lblRepContr.Name = "lblRepContr";
            this.lblRepContr.Size = new System.Drawing.Size(142, 19);
            this.lblRepContr.TabIndex = 20;
            this.lblRepContr.Text = "Reingrese Contraseña";
            // 
            // lblContr
            // 
            this.lblContr.AutoSize = true;
            this.lblContr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContr.Location = new System.Drawing.Point(18, 158);
            this.lblContr.Name = "lblContr";
            this.lblContr.Size = new System.Drawing.Size(79, 19);
            this.lblContr.TabIndex = 19;
            this.lblContr.Text = "Contraseña";
            // 
            // lblNombUsu
            // 
            this.lblNombUsu.AutoSize = true;
            this.lblNombUsu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombUsu.Location = new System.Drawing.Point(18, 113);
            this.lblNombUsu.Name = "lblNombUsu";
            this.lblNombUsu.Size = new System.Drawing.Size(129, 19);
            this.lblNombUsu.TabIndex = 18;
            this.lblNombUsu.Text = "Nombre de Usuario";
            // 
            // cBoxPermisos
            // 
            this.cBoxPermisos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPermisos.FormattingEnabled = true;
            this.cBoxPermisos.Items.AddRange(new object[] {
            "Cajero",
            "Enc. Inventario",
            "Gerente",
            "Administrador"});
            this.cBoxPermisos.Location = new System.Drawing.Point(160, 68);
            this.cBoxPermisos.Name = "cBoxPermisos";
            this.cBoxPermisos.Size = new System.Drawing.Size(121, 25);
            this.cBoxPermisos.TabIndex = 17;
            // 
            // lblpermisos
            // 
            this.lblpermisos.AutoSize = true;
            this.lblpermisos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpermisos.Location = new System.Drawing.Point(18, 68);
            this.lblpermisos.Name = "lblpermisos";
            this.lblpermisos.Size = new System.Drawing.Size(117, 19);
            this.lblpermisos.TabIndex = 16;
            this.lblpermisos.Text = "Nivel de permisos";
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(926, 498);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Principal";
            this.Text = "Dia Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGerente.ResumeLayout(false);
            this.tabControlGerente.ResumeLayout(false);
            this.tabReporteMensual.ResumeLayout(false);
            this.boxElegirMes.ResumeLayout(false);
            this.boxElegirMes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPorMes)).EndInit();
            this.tabReporteSemanal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPorSem)).EndInit();
            this.boxElegirSemana.ResumeLayout(false);
            this.boxElegirSemana.PerformLayout();
            this.tabReporteVendedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPorVend)).EndInit();
            this.boxElegirVendedor.ResumeLayout(false);
            this.tabEncargado.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioModificar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadModificar1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarProducto1)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerta)).EndInit();
            this.tabPage12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCargarStock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargarStock)).EndInit();
            this.tabVendedor.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.tabPage14.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.buscarCliente_gbx.ResumeLayout(false);
            this.buscarCliente_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDatosCliente_dg)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage18.ResumeLayout(false);
            this.tabPage18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGerente;
        private System.Windows.Forms.TabPage tabEncargado;
        private System.Windows.Forms.TabControl tabControlGerente;
        private System.Windows.Forms.TabPage tabReporteMensual;
        private System.Windows.Forms.TabPage tabReporteSemanal;
        private System.Windows.Forms.TabPage tabReporteVendedor;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabVendedor;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.GroupBox boxElegirMes;
        private System.Windows.Forms.DataGridView dtGridPorMes;
        private System.Windows.Forms.GroupBox boxElegirSemana;
        private System.Windows.Forms.GroupBox boxElegirVendedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView dgvModificarProducto1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DataGridView dgvAlerta;
        private System.Windows.Forms.DataGridView dgvCargarStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncargadoLimpiarCamposCP;
        private System.Windows.Forms.Button btnEncargadoCP;
        private System.Windows.Forms.ComboBox cmbHabilitado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.Button btnLimpiarCamposDatosProductoMP;
        private System.Windows.Forms.Button btnModificarDatosProductoMP;
        private System.Windows.Forms.ComboBox cmbHabilitadoModificar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCantidadModificar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcionModificar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.Button btnCargarStock;
        private System.Windows.Forms.NumericUpDown nudCantidadCargarStock1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescripcionCargarStock1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLimpiarCamposMP;
        private System.Windows.Forms.Button btnBuscarProductoMP;
        private System.Windows.Forms.TextBox txtDescripcionModificar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtDescripcionBCargarStock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button btnBuscarProductoCS;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnGenerarListado;
        private System.Windows.Forms.Button btnGenerarAlerta;
        private System.Windows.Forms.Button btnLimpiarCamposCS;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecioModificar1;
        private System.Windows.Forms.TextBox txtIdModificar1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdCargarStock1;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.ComboBox cmbBoxMeses;
        private System.Windows.Forms.Button btnBuscarXMes;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtPickerHasta;
        private System.Windows.Forms.DateTimePicker dtPickerDesde;
        private System.Windows.Forms.DataGridView dtGridPorSem;
        private System.Windows.Forms.Button btnBuscarXSem;
        private System.Windows.Forms.Button btnBuscarXVend;
        private System.Windows.Forms.ComboBox cmbBoxVendedor;
        private System.Windows.Forms.DataGridView dtGridPorVend;
        private System.Windows.Forms.TextBox txtBoxAño;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TextBox txbLegajo;
        private System.Windows.Forms.TextBox txbReingContr;
        private System.Windows.Forms.TextBox txbContrasenia;
        private System.Windows.Forms.TextBox txbNomUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancUsu;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRepContr;
        private System.Windows.Forms.Label lblContr;
        private System.Windows.Forms.Label lblNombUsu;
        private System.Windows.Forms.ComboBox cBoxPermisos;
        private System.Windows.Forms.Label lblpermisos;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Button benerarCliente_btn;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox direccionCliente_tbx;
        private System.Windows.Forms.TextBox telefonoCliente_tbx;
        private System.Windows.Forms.TextBox cuitCliente_tbx;
        private System.Windows.Forms.TextBox dniCliente_tbx;
        private System.Windows.Forms.TextBox nombrCliente_tbx;
        private System.Windows.Forms.TextBox apellidoCliente_tbx;
        private System.Windows.Forms.Label direccionCliente_lbl;
        private System.Windows.Forms.Label telefonoCliente_lbl;
        private System.Windows.Forms.Label cuitCliente_lbl;
        private System.Windows.Forms.Label dniCliente_lbl;
        private System.Windows.Forms.Label nombreCliente_lbl;
        private System.Windows.Forms.Label apellidoCliente_lbl;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.Button modificarcliente_btn;
        private System.Windows.Forms.Button iniciarVenta_btn;
        private System.Windows.Forms.Button buscarCliente_btn;
        private System.Windows.Forms.GroupBox buscarCliente_gbx;
        private System.Windows.Forms.TextBox dni_tbx;
        private System.Windows.Forms.Label dni_lbl;
        private System.Windows.Forms.DataGridView dbDatosCliente_dg;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

