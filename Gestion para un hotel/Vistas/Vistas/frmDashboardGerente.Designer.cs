namespace Vistas.Vistas
{
    partial class frmDashboardGerente
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
            this.pnlNavehación = new System.Windows.Forms.Panel();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlNavehación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavehación
            // 
            this.pnlNavehación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlNavehación.Controls.Add(this.pbUsuario);
            this.pnlNavehación.Controls.Add(this.lblIngresos);
            this.pnlNavehación.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavehación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.pnlNavehación.Location = new System.Drawing.Point(0, 0);
            this.pnlNavehación.Name = "pnlNavehación";
            this.pnlNavehación.Size = new System.Drawing.Size(200, 450);
            this.pnlNavehación.TabIndex = 9;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Vistas.Properties.Resources.Group_1_;
            this.pbUsuario.Location = new System.Drawing.Point(46, 30);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(103, 95);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUsuario.TabIndex = 0;
            this.pbUsuario.TabStop = false;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(43, 191);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(59, 16);
            this.lblIngresos.TabIndex = 5;
            this.lblIngresos.Text = "Ingresos";
            this.lblIngresos.Click += new System.EventHandler(this.lblIngresos_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(200, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(600, 450);
            this.pnlPrincipal.TabIndex = 10;
            // 
            // frmDashboardGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlNavehación);
            this.Name = "frmDashboardGerente";
            this.Text = "frmDashboardGerente";
            this.pnlNavehación.ResumeLayout(false);
            this.pnlNavehación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavehación;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}