namespace UI.Windows.Forms
{
    partial class FrmUsuario
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(104, 454);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 22);
            this.txtID.TabIndex = 31;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(68, 457);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(367, 446);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(119, 39);
            this.btnInsertar.TabIndex = 29;
            this.btnInsertar.Text = "REGISTRAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(206, 454);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(85, 22);
            this.txtEstado.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 350);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 22);
            this.txtPassword.TabIndex = 26;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 261);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 22);
            this.txtUsername.TabIndex = 24;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(170, 167);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(148, 22);
            this.txtEmpleado.TabIndex = 23;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(191, 419);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(127, 16);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "ESTADO USUARIO";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(203, 311);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 16);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "CONTRASEÑA";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(203, 226);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 16);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "USERNAME";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(215, 129);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(72, 16);
            this.lblEmpleado.TabIndex = 17;
            this.lblEmpleado.Text = "EMPLEDO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(168, 63);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 16);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "REGISTRO USUARIOS";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 516);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblTitulo;
    }
}