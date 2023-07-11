namespace UI.Windows.Forms
{
    partial class FrmHabitacion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCaracteristica = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(191, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO HABITACION";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(80, 108);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(151, 16);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "NUMERO HABITACION";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(330, 108);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(122, 16);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "PISO HABITACION";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(330, 307);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(141, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "PRECIO HABITACION";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(80, 207);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(122, 16);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "TIPO HABITACION";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Location = new System.Drawing.Point(291, 207);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(207, 16);
            this.lblCaracteristicas.TabIndex = 5;
            this.lblCaracteristicas.Text = "CARACTERISTICA HABITACION";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(80, 307);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(147, 16);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "ESTADO HABITACION";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(83, 143);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(148, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(324, 143);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(148, 22);
            this.txtPiso.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(324, 346);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(148, 22);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(83, 246);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(148, 22);
            this.txtTipo.TabIndex = 10;
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Location = new System.Drawing.Point(324, 246);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(148, 22);
            this.txtCaracteristica.TabIndex = 11;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(83, 346);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(148, 22);
            this.txtEstado.TabIndex = 12;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(212, 428);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(119, 39);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "REGISTRAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(47, 475);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(83, 472);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 22);
            this.txtID.TabIndex = 15;
            // 
            // FrmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 524);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCaracteristica);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCaracteristicas);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmHabitacion";
            this.Text = "FrmHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCaracteristica;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}