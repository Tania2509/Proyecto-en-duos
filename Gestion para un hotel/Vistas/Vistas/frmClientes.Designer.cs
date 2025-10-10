namespace Vistas.Vistas
{
    partial class frmClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.dtpFechaNaciPa = new System.Windows.Forms.DateTimePicker();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(19, 32);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(428, 433);
            this.dgvClientes.TabIndex = 4;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 2);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(300, 700);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDui);
            this.panel1.Controls.Add(this.dtpFechaNaciPa);
            this.panel1.Controls.Add(this.txtCorreoElectronico);
            this.panel1.Controls.Add(this.lblFechaNacimiento);
            this.panel1.Controls.Add(this.lblCorreoElectronico);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtNumTelefono);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(477, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 433);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 572);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Dui:";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(54, 614);
            this.txtDui.Margin = new System.Windows.Forms.Padding(6);
            this.txtDui.MaxLength = 9;
            this.txtDui.Name = "txtDui";
            this.txtDui.ShortcutsEnabled = false;
            this.txtDui.Size = new System.Drawing.Size(345, 32);
            this.txtDui.TabIndex = 40;
            // 
            // dtpFechaNaciPa
            // 
            this.dtpFechaNaciPa.Location = new System.Drawing.Point(56, 474);
            this.dtpFechaNaciPa.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFechaNaciPa.Name = "dtpFechaNaciPa";
            this.dtpFechaNaciPa.Size = new System.Drawing.Size(343, 32);
            this.dtpFechaNaciPa.TabIndex = 39;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(54, 339);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(6);
            this.txtCorreoElectronico.MaxLength = 50;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.ShortcutsEnabled = false;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(345, 32);
            this.txtCorreoElectronico.TabIndex = 38;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(48, 433);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(223, 23);
            this.lblFechaNacimiento.TabIndex = 37;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(46, 298);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(192, 23);
            this.lblCorreoElectronico.TabIndex = 36;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(46, 164);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 23);
            this.lblApellido.TabIndex = 35;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 24);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 23);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(57, 204);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(6);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(342, 32);
            this.txtApellido.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(342, 32);
            this.txtNombre.TabIndex = 32;
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(54, 734);
            this.txtNumTelefono.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumTelefono.MaxLength = 8;
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.ShortcutsEnabled = false;
            this.txtNumTelefono.Size = new System.Drawing.Size(342, 32);
            this.txtNumTelefono.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 693);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Número de Teléfono";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualizar.Location = new System.Drawing.Point(684, 476);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(168, 65);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(859, 476);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 65);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(511, 476);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 65);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 614);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.DateTimePicker dtpFechaNaciPa;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}