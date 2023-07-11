namespace UI.Windows.Forms
{
    partial class FrmDetalleReserva
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
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(227, 397);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(325, 22);
            this.txtObservacion.TabIndex = 73;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(51, 397);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(104, 16);
            this.lblObservacion.TabIndex = 72;
            this.lblObservacion.Text = "OBSERVACION";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(252, 491);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 46);
            this.btnInsertar.TabIndex = 71;
            this.btnInsertar.Text = "REGISTRAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(74, 166);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 70;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(53, 197);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 22);
            this.txtID.TabIndex = 69;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(482, 317);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(49, 22);
            this.txtEstado.TabIndex = 68;
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(276, 317);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(65, 22);
            this.txtPersonas.TabIndex = 66;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(53, 317);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(65, 22);
            this.txtDias.TabIndex = 65;
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Location = new System.Drawing.Point(452, 197);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(110, 22);
            this.txtHabitacion.TabIndex = 64;
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(227, 197);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(159, 22);
            this.txtReserva.TabIndex = 63;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(479, 283);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 16);
            this.lblEstado.TabIndex = 62;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(232, 282);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(154, 16);
            this.lblPersonas.TabIndex = 60;
            this.lblPersonas.Text = "CANTIDAD PERSONAS";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(31, 282);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(110, 16);
            this.lblDias.TabIndex = 59;
            this.lblDias.Text = "CANTIDAD DIAS";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(464, 152);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(88, 16);
            this.lblHabitacion.TabIndex = 58;
            this.lblHabitacion.Text = "HABITACION";
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(269, 152);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(72, 16);
            this.lblReserva.TabIndex = 57;
            this.lblReserva.Text = "RESERVA";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(137, -19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 16);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "REGISTRO DE ALQUILER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "REGISTRO DETALLE";
            // 
            // FrmDetalleReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPersonas);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmDetalleReserva";
            this.Text = "FrmDetalleReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPersonas;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
    }
}