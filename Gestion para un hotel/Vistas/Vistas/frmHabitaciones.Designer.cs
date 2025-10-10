namespace Vistas.Vistas
{
    partial class frmHabitaciones
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
            this.txtNumeroHab = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.txtNumeroHab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroHab
            // 
            this.txtNumeroHab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumeroHab.Controls.Add(this.txtNumero);
            this.txtNumeroHab.Controls.Add(this.txtPrecio);
            this.txtNumeroHab.Controls.Add(this.btnActualizar);
            this.txtNumeroHab.Controls.Add(this.btnEliminar);
            this.txtNumeroHab.Controls.Add(this.txtCantidad);
            this.txtNumeroHab.Controls.Add(this.lblCantidad);
            this.txtNumeroHab.Controls.Add(this.btnAgregar);
            this.txtNumeroHab.Controls.Add(this.lblDui);
            this.txtNumeroHab.Controls.Add(this.lblNombre);
            this.txtNumeroHab.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHab.Location = new System.Drawing.Point(403, 11);
            this.txtNumeroHab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroHab.Name = "txtNumeroHab";
            this.txtNumeroHab.Size = new System.Drawing.Size(565, 333);
            this.txtNumeroHab.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(280, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(233, 36);
            this.txtNumero.TabIndex = 22;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(280, 102);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(233, 36);
            this.txtPrecio.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(201, 219);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(168, 65);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(376, 219);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 65);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(280, 156);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(233, 36);
            this.txtCantidad.TabIndex = 17;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(39, 160);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(207, 23);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad de personas:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(28, 219);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 65);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(39, 105);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(66, 23);
            this.lblDui.TabIndex = 6;
            this.lblDui.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(174, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NumeroHabitacion";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(29, 27);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.RowHeadersWidth = 51;
            this.dgvHabitaciones.RowTemplate.Height = 24;
            this.dgvHabitaciones.Size = new System.Drawing.Size(368, 253);
            this.dgvHabitaciones.TabIndex = 2;
            this.dgvHabitaciones.DoubleClick += new System.EventHandler(this.dgvHabitaciones_DoubleClick);
            // 
            // frmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 355);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.txtNumeroHab);
            this.Name = "frmHabitaciones";
            this.Text = "frmHabitaciones";
            this.Load += new System.EventHandler(this.frmHabitaciones_Load);
            this.txtNumeroHab.ResumeLayout(false);
            this.txtNumeroHab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel txtNumeroHab;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNumero;
    }
}