namespace Vistas.Vistas
{
    partial class frmServicios
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
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.txtNumeroHab = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.txtNumeroHab.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(12, 67);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.Size = new System.Drawing.Size(382, 333);
            this.dgvServicios.TabIndex = 4;
            this.dgvServicios.DoubleClick += new System.EventHandler(this.dgvServicios_DoubleClick);
            // 
            // txtNumeroHab
            // 
            this.txtNumeroHab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumeroHab.Controls.Add(this.txtNombre);
            this.txtNumeroHab.Controls.Add(this.txtPrecio);
            this.txtNumeroHab.Controls.Add(this.btnActualizar);
            this.txtNumeroHab.Controls.Add(this.btnEliminar);
            this.txtNumeroHab.Controls.Add(this.txtdescripcion);
            this.txtNumeroHab.Controls.Add(this.lblDescripcion);
            this.txtNumeroHab.Controls.Add(this.btnAgregar);
            this.txtNumeroHab.Controls.Add(this.lblDui);
            this.txtNumeroHab.Controls.Add(this.lblNombre);
            this.txtNumeroHab.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHab.Location = new System.Drawing.Point(400, 67);
            this.txtNumeroHab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroHab.Name = "txtNumeroHab";
            this.txtNumeroHab.Size = new System.Drawing.Size(565, 333);
            this.txtNumeroHab.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(280, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 36);
            this.txtNombre.TabIndex = 22;
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
            this.btnActualizar.Location = new System.Drawing.Point(196, 246);
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
            this.btnEliminar.Location = new System.Drawing.Point(371, 246);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 65);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(280, 156);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(233, 70);
            this.txtdescripcion.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(39, 160);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(115, 23);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(23, 246);
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
            this.lblNombre.Size = new System.Drawing.Size(81, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Servicio";
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 466);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.txtNumeroHab);
            this.Name = "frmServicios";
            this.Text = "frmServicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.txtNumeroHab.ResumeLayout(false);
            this.txtNumeroHab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Panel txtNumeroHab;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblNombre;
    }
}