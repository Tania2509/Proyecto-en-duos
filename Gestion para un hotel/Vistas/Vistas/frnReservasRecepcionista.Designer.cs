namespace Vistas.Vistas
{
    partial class frnReservasRecepcionista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.cbHabitacion = new System.Windows.Forms.ComboBox();
            this.cbDui = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtpSalida);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.dtpEntrada);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.cbPago);
            this.panel1.Controls.Add(this.cbHabitacion);
            this.panel1.Controls.Add(this.cbDui);
            this.panel1.Controls.Add(this.cbCliente);
            this.panel1.Controls.Add(this.lblDui);
            this.panel1.Controls.Add(this.lblHabitacion);
            this.panel1.Controls.Add(this.lblPago);
            this.panel1.Controls.Add(this.lblEntrada);
            this.panel1.Controls.Add(this.lblSalida);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(255, -14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 551);
            this.panel1.TabIndex = 1;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(280, 400);
            this.dtpSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(233, 36);
            this.dtpSalida.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(203, 457);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 65);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(280, 345);
            this.dtpEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(233, 36);
            this.dtpEntrada.TabIndex = 18;
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
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Location = new System.Drawing.Point(280, 281);
            this.cbPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(233, 31);
            this.cbPago.TabIndex = 12;
            // 
            // cbHabitacion
            // 
            this.cbHabitacion.FormattingEnabled = true;
            this.cbHabitacion.Location = new System.Drawing.Point(280, 220);
            this.cbHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHabitacion.Name = "cbHabitacion";
            this.cbHabitacion.Size = new System.Drawing.Size(233, 31);
            this.cbHabitacion.TabIndex = 11;
            // 
            // cbDui
            // 
            this.cbDui.FormattingEnabled = true;
            this.cbDui.Location = new System.Drawing.Point(280, 102);
            this.cbDui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDui.Name = "cbDui";
            this.cbDui.Size = new System.Drawing.Size(233, 31);
            this.cbDui.TabIndex = 10;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(280, 43);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(233, 31);
            this.cbCliente.TabIndex = 8;
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(39, 105);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(40, 23);
            this.lblDui.TabIndex = 6;
            this.lblDui.Text = "Dui";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(39, 224);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(104, 23);
            this.lblHabitacion.TabIndex = 5;
            this.lblHabitacion.Text = "Habitacion";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(37, 283);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(158, 23);
            this.lblPago.TabIndex = 4;
            this.lblPago.Text = "Metodo de pago:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(39, 345);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(161, 23);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Fecha de entrada";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(37, 409);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(145, 23);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "Fecha de salida";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // frnReservasRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frnReservasRecepcionista";
            this.Size = new System.Drawing.Size(1075, 523);
            this.Load += new System.EventHandler(this.frnReservasRecepcionista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.ComboBox cbHabitacion;
        private System.Windows.Forms.ComboBox cbDui;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
    }
}
