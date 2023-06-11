
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
            this.totalVenta_lbl = new System.Windows.Forms.Label();
            this.facturarVenta_btn = new System.Windows.Forms.Button();
            this.borrarItemVenta_btn = new System.Windows.Forms.Button();
            this.detalleOrdendeCompra_dgv = new System.Windows.Forms.DataGridView();
            this.cantidadProducto_tbx = new System.Windows.Forms.TextBox();
            this.idProducto_tbx = new System.Windows.Forms.TextBox();
            this.itemVenta_btn = new System.Windows.Forms.Button();
            this.cantidadProd_updn = new System.Windows.Forms.Label();
            this.idProducto_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdendeCompra_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // totalVenta_lbl
            // 
            this.totalVenta_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalVenta_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVenta_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.totalVenta_lbl.Location = new System.Drawing.Point(642, 195);
            this.totalVenta_lbl.Name = "totalVenta_lbl";
            this.totalVenta_lbl.Size = new System.Drawing.Size(118, 50);
            this.totalVenta_lbl.TabIndex = 21;
            this.totalVenta_lbl.Text = "                               ";
            // 
            // facturarVenta_btn
            // 
            this.facturarVenta_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.facturarVenta_btn.Location = new System.Drawing.Point(642, 365);
            this.facturarVenta_btn.Name = "facturarVenta_btn";
            this.facturarVenta_btn.Size = new System.Drawing.Size(142, 49);
            this.facturarVenta_btn.TabIndex = 20;
            this.facturarVenta_btn.Text = "FACTURAR";
            this.facturarVenta_btn.UseVisualStyleBackColor = false;
            this.facturarVenta_btn.Click += new System.EventHandler(this.facturarVenta_btn_Click);
            // 
            // borrarItemVenta_btn
            // 
            this.borrarItemVenta_btn.Location = new System.Drawing.Point(642, 105);
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
            this.detalleOrdendeCompra_dgv.Location = new System.Drawing.Point(16, 105);
            this.detalleOrdendeCompra_dgv.Name = "detalleOrdendeCompra_dgv";
            this.detalleOrdendeCompra_dgv.Size = new System.Drawing.Size(599, 309);
            this.detalleOrdendeCompra_dgv.TabIndex = 18;
            // 
            // cantidadProducto_tbx
            // 
            this.cantidadProducto_tbx.Location = new System.Drawing.Point(440, 36);
            this.cantidadProducto_tbx.Name = "cantidadProducto_tbx";
            this.cantidadProducto_tbx.Size = new System.Drawing.Size(100, 20);
            this.cantidadProducto_tbx.TabIndex = 17;
            // 
            // idProducto_tbx
            // 
            this.idProducto_tbx.Location = new System.Drawing.Point(149, 36);
            this.idProducto_tbx.Name = "idProducto_tbx";
            this.idProducto_tbx.Size = new System.Drawing.Size(100, 20);
            this.idProducto_tbx.TabIndex = 16;
            // 
            // itemVenta_btn
            // 
            this.itemVenta_btn.Location = new System.Drawing.Point(642, 39);
            this.itemVenta_btn.Name = "itemVenta_btn";
            this.itemVenta_btn.Size = new System.Drawing.Size(118, 43);
            this.itemVenta_btn.TabIndex = 15;
            this.itemVenta_btn.Text = "Agregar Item";
            this.itemVenta_btn.UseVisualStyleBackColor = true;
            this.itemVenta_btn.Click += new System.EventHandler(this.itemVenta_btn_Click);
            // 
            // cantidadProd_updn
            // 
            this.cantidadProd_updn.AutoSize = true;
            this.cantidadProd_updn.Location = new System.Drawing.Point(333, 39);
            this.cantidadProd_updn.Name = "cantidadProd_updn";
            this.cantidadProd_updn.Size = new System.Drawing.Size(49, 13);
            this.cantidadProd_updn.TabIndex = 14;
            this.cantidadProd_updn.Text = "Cantidad";
            // 
            // idProducto_lbl
            // 
            this.idProducto_lbl.AutoSize = true;
            this.idProducto_lbl.Location = new System.Drawing.Point(37, 39);
            this.idProducto_lbl.Name = "idProducto_lbl";
            this.idProducto_lbl.Size = new System.Drawing.Size(62, 13);
            this.idProducto_lbl.TabIndex = 13;
            this.idProducto_lbl.Text = "Id Producto";
            // 
            // Form_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalVenta_lbl);
            this.Controls.Add(this.facturarVenta_btn);
            this.Controls.Add(this.borrarItemVenta_btn);
            this.Controls.Add(this.detalleOrdendeCompra_dgv);
            this.Controls.Add(this.cantidadProducto_tbx);
            this.Controls.Add(this.idProducto_tbx);
            this.Controls.Add(this.itemVenta_btn);
            this.Controls.Add(this.cantidadProd_updn);
            this.Controls.Add(this.idProducto_lbl);
            this.Name = "Form_Ventas";
            this.Text = "Form_Ventas";
            this.Load += new System.EventHandler(this.Form_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdendeCompra_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}