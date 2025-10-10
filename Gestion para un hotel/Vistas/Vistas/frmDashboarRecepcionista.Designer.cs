namespace Vistas.Vistas
{
    partial class frmDashboarRecepcionista
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
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblGestionReserva = new System.Windows.Forms.Label();
            this.pnlNavehación = new System.Windows.Forms.Panel();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlNavehación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(48, 256);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(68, 16);
            this.lblCheckOut.TabIndex = 7;
            this.lblCheckOut.Text = "Check Out";
            this.lblCheckOut.Click += new System.EventHandler(this.lblCheckOut_Click);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(47, 224);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(58, 16);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check In";
            this.lblCheckIn.Click += new System.EventHandler(this.lblCheckIn_Click);
            // 
            // lblGestionReserva
            // 
            this.lblGestionReserva.AutoSize = true;
            this.lblGestionReserva.Location = new System.Drawing.Point(43, 191);
            this.lblGestionReserva.Name = "lblGestionReserva";
            this.lblGestionReserva.Size = new System.Drawing.Size(102, 16);
            this.lblGestionReserva.TabIndex = 5;
            this.lblGestionReserva.Text = "Gestion reserva";
            this.lblGestionReserva.Click += new System.EventHandler(this.lblGestionReserva_Click);
            // 
            // pnlNavehación
            // 
            this.pnlNavehación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlNavehación.Controls.Add(this.pbUsuario);
            this.pnlNavehación.Controls.Add(this.lblCheckOut);
            this.pnlNavehación.Controls.Add(this.lblGestionReserva);
            this.pnlNavehación.Controls.Add(this.lblCheckIn);
            this.pnlNavehación.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavehación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.pnlNavehación.Location = new System.Drawing.Point(0, 0);
            this.pnlNavehación.Name = "pnlNavehación";
            this.pnlNavehación.Size = new System.Drawing.Size(200, 569);
            this.pnlNavehación.TabIndex = 8;
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
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(200, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(600, 569);
            this.pnlPrincipal.TabIndex = 9;
            // 
            // frmDashboarRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlNavehación);
            this.Name = "frmDashboarRecepcionista";
            this.Text = "frmRecepcionista";
            this.pnlNavehación.ResumeLayout(false);
            this.pnlNavehación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblGestionReserva;
        private System.Windows.Forms.Panel pnlNavehación;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}