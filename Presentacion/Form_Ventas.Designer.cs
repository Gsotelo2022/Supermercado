
namespace Supermercado
{
    partial class Form_Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ventas));
            this.totalVenta_lbl = new System.Windows.Forms.Label();
            this.facturarVenta_btn = new System.Windows.Forms.Button();
            this.borrarItemVenta_btn = new System.Windows.Forms.Button();
            this.detalleOrdendeCompra_dgv = new System.Windows.Forms.DataGridView();
            this.cantidadProducto_tbx = new System.Windows.Forms.TextBox();
            this.idProducto_tbx = new System.Windows.Forms.TextBox();
            this.itemVenta_btn = new System.Windows.Forms.Button();
            this.cantidadProd_updn = new System.Windows.Forms.Label();
            this.idProducto_lbl = new System.Windows.Forms.Label();
            this.buscarCliente_gbx = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdendeCompra_dgv)).BeginInit();
            this.buscarCliente_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalVenta_lbl
            // 
            this.totalVenta_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalVenta_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVenta_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.totalVenta_lbl.Location = new System.Drawing.Point(652, 148);
            this.totalVenta_lbl.Name = "totalVenta_lbl";
            this.totalVenta_lbl.Size = new System.Drawing.Size(118, 50);
            this.totalVenta_lbl.TabIndex = 21;
            this.totalVenta_lbl.Text = "                               ";
            // 
            // facturarVenta_btn
            // 
            this.facturarVenta_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.facturarVenta_btn.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturarVenta_btn.Location = new System.Drawing.Point(652, 386);
            this.facturarVenta_btn.Name = "facturarVenta_btn";
            this.facturarVenta_btn.Size = new System.Drawing.Size(122, 42);
            this.facturarVenta_btn.TabIndex = 20;
            this.facturarVenta_btn.Text = "Facturar";
            this.facturarVenta_btn.UseVisualStyleBackColor = false;
            this.facturarVenta_btn.Click += new System.EventHandler(this.facturarVenta_btn_Click);
            // 
            // borrarItemVenta_btn
            // 
            this.borrarItemVenta_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarItemVenta_btn.Location = new System.Drawing.Point(652, 93);
            this.borrarItemVenta_btn.Name = "borrarItemVenta_btn";
            this.borrarItemVenta_btn.Size = new System.Drawing.Size(118, 37);
            this.borrarItemVenta_btn.TabIndex = 19;
            this.borrarItemVenta_btn.Text = "Borrar Item";
            this.borrarItemVenta_btn.UseVisualStyleBackColor = true;
            this.borrarItemVenta_btn.Click += new System.EventHandler(this.borrarItemVenta_btn_Click);
            // 
            // detalleOrdendeCompra_dgv
            // 
            this.detalleOrdendeCompra_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleOrdendeCompra_dgv.Location = new System.Drawing.Point(10, 52);
            this.detalleOrdendeCompra_dgv.Name = "detalleOrdendeCompra_dgv";
            this.detalleOrdendeCompra_dgv.RowHeadersWidth = 45;
            this.detalleOrdendeCompra_dgv.Size = new System.Drawing.Size(620, 376);
            this.detalleOrdendeCompra_dgv.TabIndex = 18;
            // 
            // cantidadProducto_tbx
            // 
            this.cantidadProducto_tbx.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadProducto_tbx.Location = new System.Drawing.Point(280, 19);
            this.cantidadProducto_tbx.Name = "cantidadProducto_tbx";
            this.cantidadProducto_tbx.Size = new System.Drawing.Size(58, 27);
            this.cantidadProducto_tbx.TabIndex = 17;
            // 
            // idProducto_tbx
            // 
            this.idProducto_tbx.Font = new System.Drawing.Font("Segoe UI", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProducto_tbx.Location = new System.Drawing.Point(98, 21);
            this.idProducto_tbx.Name = "idProducto_tbx";
            this.idProducto_tbx.Size = new System.Drawing.Size(87, 22);
            this.idProducto_tbx.TabIndex = 16;
            // 
            // itemVenta_btn
            // 
            this.itemVenta_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemVenta_btn.Location = new System.Drawing.Point(652, 52);
            this.itemVenta_btn.Name = "itemVenta_btn";
            this.itemVenta_btn.Size = new System.Drawing.Size(118, 35);
            this.itemVenta_btn.TabIndex = 15;
            this.itemVenta_btn.Text = "Agregar Item";
            this.itemVenta_btn.UseVisualStyleBackColor = true;
            this.itemVenta_btn.Click += new System.EventHandler(this.itemVenta_btn_Click);
            // 
            // cantidadProd_updn
            // 
            this.cantidadProd_updn.AutoSize = true;
            this.cantidadProd_updn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadProd_updn.Location = new System.Drawing.Point(205, 21);
            this.cantidadProd_updn.Name = "cantidadProd_updn";
            this.cantidadProd_updn.Size = new System.Drawing.Size(69, 20);
            this.cantidadProd_updn.TabIndex = 14;
            this.cantidadProd_updn.Text = "Cantidad";
            // 
            // idProducto_lbl
            // 
            this.idProducto_lbl.AutoSize = true;
            this.idProducto_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProducto_lbl.Location = new System.Drawing.Point(6, 21);
            this.idProducto_lbl.Name = "idProducto_lbl";
            this.idProducto_lbl.Size = new System.Drawing.Size(86, 20);
            this.idProducto_lbl.TabIndex = 13;
            this.idProducto_lbl.Text = "Id Producto";
            // 
            // buscarCliente_gbx
            // 
            this.buscarCliente_gbx.Controls.Add(this.idProducto_lbl);
            this.buscarCliente_gbx.Controls.Add(this.totalVenta_lbl);
            this.buscarCliente_gbx.Controls.Add(this.cantidadProd_updn);
            this.buscarCliente_gbx.Controls.Add(this.facturarVenta_btn);
            this.buscarCliente_gbx.Controls.Add(this.idProducto_tbx);
            this.buscarCliente_gbx.Controls.Add(this.borrarItemVenta_btn);
            this.buscarCliente_gbx.Controls.Add(this.cantidadProducto_tbx);
            this.buscarCliente_gbx.Controls.Add(this.itemVenta_btn);
            this.buscarCliente_gbx.Controls.Add(this.detalleOrdendeCompra_dgv);
            this.buscarCliente_gbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCliente_gbx.Location = new System.Drawing.Point(5, 4);
            this.buscarCliente_gbx.Name = "buscarCliente_gbx";
            this.buscarCliente_gbx.Size = new System.Drawing.Size(791, 440);
            this.buscarCliente_gbx.TabIndex = 22;
            this.buscarCliente_gbx.TabStop = false;
            // 
            // Form_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscarCliente_gbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Ventas";
            this.Text = "Dia Software";
            this.Load += new System.EventHandler(this.Form_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdendeCompra_dgv)).EndInit();
            this.buscarCliente_gbx.ResumeLayout(false);
            this.buscarCliente_gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totalVenta_lbl;
        private System.Windows.Forms.Button facturarVenta_btn;
        private System.Windows.Forms.Button borrarItemVenta_btn;
        private System.Windows.Forms.DataGridView detalleOrdendeCompra_dgv;
        private System.Windows.Forms.TextBox cantidadProducto_tbx;
        private System.Windows.Forms.TextBox idProducto_tbx;
        private System.Windows.Forms.Button itemVenta_btn;
        private System.Windows.Forms.Label cantidadProd_updn;
        private System.Windows.Forms.Label idProducto_lbl;
        private System.Windows.Forms.GroupBox buscarCliente_gbx;
    }
}