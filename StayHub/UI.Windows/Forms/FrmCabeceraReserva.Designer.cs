namespace UI.Windows.Forms
{
    partial class FrmCabeceraReserva
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.txtFechaEntrada = new System.Windows.Forms.TextBox();
            this.txtFechaReserva = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(488, 507);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 46);
            this.btnInsertar.TabIndex = 53;
            this.btnInsertar.Text = "REGISTRAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(529, 240);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 52;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(508, 271);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 22);
            this.txtID.TabIndex = 51;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(89, 168);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(49, 22);
            this.txtEstado.TabIndex = 50;
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(227, 426);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(195, 22);
            this.txtFechaSalida.TabIndex = 48;
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Location = new System.Drawing.Point(227, 342);
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(195, 22);
            this.txtFechaEntrada.TabIndex = 47;
            // 
            // txtFechaReserva
            // 
            this.txtFechaReserva.Location = new System.Drawing.Point(227, 250);
            this.txtFechaReserva.Name = "txtFechaReserva";
            this.txtFechaReserva.Size = new System.Drawing.Size(195, 22);
            this.txtFechaReserva.TabIndex = 46;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(488, 168);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(110, 22);
            this.txtUsuario.TabIndex = 45;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(227, 168);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(182, 22);
            this.txtCliente.TabIndex = 44;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(86, 134);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 16);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(86, 426);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(102, 16);
            this.lblSalida.TabIndex = 41;
            this.lblSalida.Text = "FECHA SALIDA";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(86, 348);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(121, 16);
            this.lblEntrada.TabIndex = 40;
            this.lblEntrada.Text = "FECHA ENTRADA";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(86, 253);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(120, 16);
            this.lblFechaReserva.TabIndex = 39;
            this.lblFechaReserva.Text = "FECHA RESERVA";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(505, 123);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 16);
            this.lblUsuario.TabIndex = 38;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(285, 123);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(63, 16);
            this.lblCliente.TabIndex = 37;
            this.lblCliente.Text = "CLIENTE";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(224, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 16);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "REGISTRO DE ALQUILER";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(227, 507);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(195, 22);
            this.txtObservacion.TabIndex = 55;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(86, 507);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(104, 16);
            this.lblObservacion.TabIndex = 54;
            this.lblObservacion.Text = "OBSERVACION";
            // 
            // FrmCabeceraReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 598);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.txtFechaReserva);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCabeceraReserva";
            this.Text = "FrmCabeceraReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.TextBox txtFechaEntrada;
        private System.Windows.Forms.TextBox txtFechaReserva;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
    }
}