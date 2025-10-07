namespace Vistas.Vistas
{
    partial class frmDashboard
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
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblVerReserva = new System.Windows.Forms.Label();
            this.lblGestionReserva = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlNavehación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavehación
            // 
            this.pnlNavehación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlNavehación.Controls.Add(this.lblIngresos);
            this.pnlNavehación.Controls.Add(this.lblCheckOut);
            this.pnlNavehación.Controls.Add(this.lblCheckIn);
            this.pnlNavehación.Controls.Add(this.lblVerReserva);
            this.pnlNavehación.Controls.Add(this.lblGestionReserva);
            this.pnlNavehación.Controls.Add(this.pbUsuario);
            this.pnlNavehación.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavehación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.pnlNavehación.Location = new System.Drawing.Point(0, 0);
            this.pnlNavehación.Name = "pnlNavehación";
            this.pnlNavehación.Size = new System.Drawing.Size(200, 645);
            this.pnlNavehación.TabIndex = 0;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(57, 422);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(59, 16);
            this.lblIngresos.TabIndex = 5;
            this.lblIngresos.Text = "Ingresos";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(48, 383);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(68, 16);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check Out";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(47, 351);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(58, 16);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblVerReserva
            // 
            this.lblVerReserva.AutoSize = true;
            this.lblVerReserva.Location = new System.Drawing.Point(47, 289);
            this.lblVerReserva.Name = "lblVerReserva";
            this.lblVerReserva.Size = new System.Drawing.Size(77, 16);
            this.lblVerReserva.TabIndex = 2;
            this.lblVerReserva.Text = "Ver reserva";
            // 
            // lblGestionReserva
            // 
            this.lblGestionReserva.AutoSize = true;
            this.lblGestionReserva.Location = new System.Drawing.Point(43, 318);
            this.lblGestionReserva.Name = "lblGestionReserva";
            this.lblGestionReserva.Size = new System.Drawing.Size(102, 16);
            this.lblGestionReserva.TabIndex = 1;
            this.lblGestionReserva.Text = "Gestion reserva";
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
            this.pnlPrincipal.Size = new System.Drawing.Size(1134, 645);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 645);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlNavehación);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.pnlNavehación.ResumeLayout(false);
            this.pnlNavehación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavehación;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblGestionReserva;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblVerReserva;
    }
}