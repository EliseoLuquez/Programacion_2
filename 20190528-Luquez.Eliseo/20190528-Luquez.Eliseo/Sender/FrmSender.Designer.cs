namespace Sender
{
    partial class FrmSender
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblMensaje = new System.Windows.Forms.Label();
			this.lblProducto = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.richMensaje = new System.Windows.Forms.RichTextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.cmbProducto = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.richConsola = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMensaje
			// 
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Location = new System.Drawing.Point(15, 27);
			this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(61, 17);
			this.lblMensaje.TabIndex = 1;
			this.lblMensaje.Text = "Mensaje";
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.Location = new System.Drawing.Point(15, 140);
			this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(65, 17);
			this.lblProducto.TabIndex = 2;
			this.lblProducto.Text = "Producto";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(15, 198);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(64, 17);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "Telefono";
			// 
			// btnEnviar
			// 
			this.btnEnviar.Location = new System.Drawing.Point(16, 250);
			this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(260, 39);
			this.btnEnviar.TabIndex = 4;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(377, 250);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(260, 39);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// richMensaje
			// 
			this.richMensaje.Location = new System.Drawing.Point(137, 23);
			this.richMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.richMensaje.Name = "richMensaje";
			this.richMensaje.Size = new System.Drawing.Size(323, 80);
			this.richMensaje.TabIndex = 6;
			this.richMensaje.Text = "";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(137, 190);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(323, 22);
			this.txtTelefono.TabIndex = 8;
			// 
			// cmbProducto
			// 
			this.cmbProducto.FormattingEnabled = true;
			this.cmbProducto.Items.AddRange(new object[] {
            "SQLDatabase",
            "MonitoringApp",
            "AppHosting"});
			this.cmbProducto.Location = new System.Drawing.Point(137, 130);
			this.cmbProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbProducto.Name = "cmbProducto";
			this.cmbProducto.Size = new System.Drawing.Size(323, 24);
			this.cmbProducto.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbProducto);
			this.groupBox1.Controls.Add(this.txtTelefono);
			this.groupBox1.Controls.Add(this.richMensaje);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Controls.Add(this.btnEnviar);
			this.groupBox1.Controls.Add(this.lblEmail);
			this.groupBox1.Controls.Add(this.lblProducto);
			this.groupBox1.Controls.Add(this.lblMensaje);
			this.groupBox1.Location = new System.Drawing.Point(83, 11);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(657, 324);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sender";
			// 
			// richConsola
			// 
			this.richConsola.Location = new System.Drawing.Point(83, 343);
			this.richConsola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.richConsola.Name = "richConsola";
			this.richConsola.Size = new System.Drawing.Size(655, 171);
			this.richConsola.TabIndex = 11;
			this.richConsola.Text = "";
			// 
			// FrmSender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.richConsola);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmSender";
			this.Text = "Luquez.Eliseo.2D";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox richMensaje;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richConsola;
    }
}

