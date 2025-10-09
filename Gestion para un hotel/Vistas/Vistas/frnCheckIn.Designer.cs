namespace Vistas.Vistas
{
    partial class frnCheckIn
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDui = new System.Windows.Forms.TextBox();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblDui = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(343, 56);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(254, 22);
            this.txtDui.TabIndex = 0;
            this.txtDui.TextChanged += new System.EventHandler(this.txtDui_TextChanged);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(200, 166);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.Size = new System.Drawing.Size(726, 347);
            this.dgvReservas.TabIndex = 1;
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellClick);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(1101, 453);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(175, 60);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Realizar Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(209, 59);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(94, 16);
            this.lblDui.TabIndex = 3;
            this.lblDui.Text = "Dui del cliente:";
            // 
            // frnCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDui);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.txtDui);
            this.Name = "frnCheckIn";
            this.Size = new System.Drawing.Size(1405, 601);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblDui;
    }
}
