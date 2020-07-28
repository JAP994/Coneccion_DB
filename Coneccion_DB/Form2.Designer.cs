namespace Coneccion_DB
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnTransaccion = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelCuentaHijo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelCuentaHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(184)))));
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.btnMovimientos);
            this.panelSideMenu.Controls.Add(this.btnTransaccion);
            this.panelSideMenu.Controls.Add(this.btnCuenta);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(204, 433);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.White;
            this.btnMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimientos.FlatAppearance.BorderSize = 0;
            this.btnMovimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMovimientos.Location = new System.Drawing.Point(0, 190);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMovimientos.Size = new System.Drawing.Size(204, 45);
            this.btnMovimientos.TabIndex = 3;
            this.btnMovimientos.Text = "Moviminetos Bancarios";
            this.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.BackColor = System.Drawing.Color.White;
            this.btnTransaccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaccion.FlatAppearance.BorderSize = 0;
            this.btnTransaccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTransaccion.Location = new System.Drawing.Point(0, 145);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransaccion.Size = new System.Drawing.Size(204, 45);
            this.btnTransaccion.TabIndex = 2;
            this.btnTransaccion.Text = "Realizar Trnasacción";
            this.btnTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaccion.UseVisualStyleBackColor = false;
            this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.White;
            this.btnCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCuenta.Location = new System.Drawing.Point(0, 100);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCuenta.Size = new System.Drawing.Size(204, 45);
            this.btnCuenta.TabIndex = 1;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(184)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(204, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // panelCuentaHijo
            // 
            this.panelCuentaHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(72)))), ((int)(((byte)(128)))));
            this.panelCuentaHijo.Controls.Add(this.pictureBox1);
            this.panelCuentaHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuentaHijo.Location = new System.Drawing.Point(204, 0);
            this.panelCuentaHijo.Name = "panelCuentaHijo";
            this.panelCuentaHijo.Size = new System.Drawing.Size(600, 433);
            this.panelCuentaHijo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 235);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(204, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cargar base de datos.";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 433);
            this.Controls.Add(this.panelCuentaHijo);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form2";
            this.Text = "Transacción";
            this.panelSideMenu.ResumeLayout(false);
            this.panelCuentaHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.Panel panelCuentaHijo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}