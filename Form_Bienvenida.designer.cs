
namespace Supermercado
{
    partial class Form_Bienvenida
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bienvenida));
            this.pictureDia = new System.Windows.Forms.PictureBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblPowered = new System.Windows.Forms.Label();
            this.lblUPE = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDia
            // 
            this.pictureDia.Image = global::Supermercado.Properties.Resources.Dia_Logo2;
            this.pictureDia.Location = new System.Drawing.Point(217, 21);
            this.pictureDia.Name = "pictureDia";
            this.pictureDia.Size = new System.Drawing.Size(235, 237);
            this.pictureDia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDia.TabIndex = 0;
            this.pictureDia.TabStop = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMail.Location = new System.Drawing.Point(13, 127);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(188, 15);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "desarrollo@upeyasociados.com.ar";
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTP.Location = new System.Drawing.Point(13, 110);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(145, 15);
            this.lblTP.TabIndex = 11;
            this.lblTP.Text = "Técnicas de Programación";
            // 
            // lblPowered
            // 
            this.lblPowered.AutoSize = true;
            this.lblPowered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowered.Location = new System.Drawing.Point(12, 69);
            this.lblPowered.Name = "lblPowered";
            this.lblPowered.Size = new System.Drawing.Size(91, 21);
            this.lblPowered.TabIndex = 8;
            this.lblPowered.Text = "Powered By";
            // 
            // lblUPE
            // 
            this.lblUPE.AutoSize = true;
            this.lblUPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUPE.Location = new System.Drawing.Point(12, 89);
            this.lblUPE.Name = "lblUPE";
            this.lblUPE.Size = new System.Drawing.Size(109, 21);
            this.lblUPE.TabIndex = 9;
            this.lblUPE.Text = "UPE && ASOC.";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(16, 186);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(199, 15);
            this.progressBar.TabIndex = 13;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVersion.Location = new System.Drawing.Point(121, 170);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(100, 13);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "Dia Software 1.0.0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form_Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 213);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.lblPowered);
            this.Controls.Add(this.lblUPE);
            this.Controls.Add(this.pictureDia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDia;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblPowered;
        private System.Windows.Forms.Label lblUPE;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Timer timer1;
    }
}