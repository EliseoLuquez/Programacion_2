namespace VistaForm
{
    partial class FormDT
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnValidar = new System.Windows.Forms.Button();
			this.numUpDownEdad = new System.Windows.Forms.NumericUpDown();
			this.numUpDownDni = new System.Windows.Forms.NumericUpDown();
			this.numUpDownExp = new System.Windows.Forms.NumericUpDown();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblEdad = new System.Windows.Forms.Label();
			this.lblDni = new System.Windows.Forms.Label();
			this.lblExp = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownEdad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownDni)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownExp)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(221, 42);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(81, 25);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre";
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(193, 314);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(141, 58);
			this.btnCrear.TabIndex = 1;
			this.btnCrear.Text = "Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// btnValidar
			// 
			this.btnValidar.Location = new System.Drawing.Point(392, 318);
			this.btnValidar.Name = "btnValidar";
			this.btnValidar.Size = new System.Drawing.Size(148, 54);
			this.btnValidar.TabIndex = 2;
			this.btnValidar.Text = "Validar";
			this.btnValidar.UseVisualStyleBackColor = true;
			this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
			// 
			// numUpDownEdad
			// 
			this.numUpDownEdad.Location = new System.Drawing.Point(355, 135);
			this.numUpDownEdad.Name = "numUpDownEdad";
			this.numUpDownEdad.Size = new System.Drawing.Size(105, 22);
			this.numUpDownEdad.TabIndex = 3;
			// 
			// numUpDownDni
			// 
			this.numUpDownDni.Location = new System.Drawing.Point(355, 182);
			this.numUpDownDni.Name = "numUpDownDni";
			this.numUpDownDni.Size = new System.Drawing.Size(105, 22);
			this.numUpDownDni.TabIndex = 4;
			// 
			// numUpDownExp
			// 
			this.numUpDownExp.Location = new System.Drawing.Point(355, 223);
			this.numUpDownExp.Name = "numUpDownExp";
			this.numUpDownExp.Size = new System.Drawing.Size(105, 22);
			this.numUpDownExp.TabIndex = 5;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(355, 45);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(105, 22);
			this.txtNombre.TabIndex = 6;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(355, 90);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(105, 22);
			this.txtApellido.TabIndex = 7;
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApellido.Location = new System.Drawing.Point(220, 87);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(82, 25);
			this.lblApellido.TabIndex = 11;
			this.lblApellido.Text = "Apellido";
			// 
			// lblEdad
			// 
			this.lblEdad.AutoSize = true;
			this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEdad.Location = new System.Drawing.Point(221, 132);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(58, 25);
			this.lblEdad.TabIndex = 12;
			this.lblEdad.Text = "Edad";
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDni.Location = new System.Drawing.Point(221, 179);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(45, 25);
			this.lblDni.TabIndex = 13;
			this.lblDni.Text = "DNI";
			// 
			// lblExp
			// 
			this.lblExp.AutoSize = true;
			this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExp.Location = new System.Drawing.Point(220, 220);
			this.lblExp.Name = "lblExp";
			this.lblExp.Size = new System.Drawing.Size(114, 25);
			this.lblExp.TabIndex = 14;
			this.lblExp.Text = "Experiencia";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblExp);
			this.Controls.Add(this.lblDni);
			this.Controls.Add(this.lblEdad);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.numUpDownExp);
			this.Controls.Add(this.numUpDownDni);
			this.Controls.Add(this.numUpDownEdad);
			this.Controls.Add(this.btnValidar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.lblNombre);
			this.Name = "Form1";
			this.Text = "FormDT";
			((System.ComponentModel.ISupportInitialize)(this.numUpDownEdad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownDni)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownExp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.Button btnValidar;
		private System.Windows.Forms.NumericUpDown numUpDownEdad;
		private System.Windows.Forms.NumericUpDown numUpDownDni;
		private System.Windows.Forms.NumericUpDown numUpDownExp;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblEdad;
		private System.Windows.Forms.Label lblDni;
		private System.Windows.Forms.Label lblExp;
	}
}

