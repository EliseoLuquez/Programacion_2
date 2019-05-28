namespace GUI
{
	partial class Form1
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
			this.labelMarca = new System.Windows.Forms.Label();
			this.labelModelo = new System.Windows.Forms.Label();
			this.labelMemoriaMB = new System.Windows.Forms.Label();
			this.textBoxMarca = new System.Windows.Forms.TextBox();
			this.textBoxModelo = new System.Windows.Forms.TextBox();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.buttonSacar = new System.Windows.Forms.Button();
			this.buttonSystemInfo = new System.Windows.Forms.Button();
			this.richTextBoxsystemInfo = new System.Windows.Forms.RichTextBox();
			this.numericUpDownMemoria = new System.Windows.Forms.NumericUpDown();
			this.groupBoxPlacaVideo = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemoria)).BeginInit();
			this.groupBoxPlacaVideo.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelMarca
			// 
			this.labelMarca.AutoSize = true;
			this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMarca.Location = new System.Drawing.Point(25, 59);
			this.labelMarca.Name = "labelMarca";
			this.labelMarca.Size = new System.Drawing.Size(67, 25);
			this.labelMarca.TabIndex = 1;
			this.labelMarca.Text = "Marca";
			// 
			// labelModelo
			// 
			this.labelModelo.AutoSize = true;
			this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelModelo.Location = new System.Drawing.Point(25, 84);
			this.labelModelo.Name = "labelModelo";
			this.labelModelo.Size = new System.Drawing.Size(77, 25);
			this.labelModelo.TabIndex = 2;
			this.labelModelo.Text = "Modelo";
			// 
			// labelMemoriaMB
			// 
			this.labelMemoriaMB.AutoSize = true;
			this.labelMemoriaMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMemoriaMB.Location = new System.Drawing.Point(25, 109);
			this.labelMemoriaMB.Name = "labelMemoriaMB";
			this.labelMemoriaMB.Size = new System.Drawing.Size(137, 25);
			this.labelMemoriaMB.TabIndex = 3;
			this.labelMemoriaMB.Text = "Memoria (MB)";
			// 
			// textBoxMarca
			// 
			this.textBoxMarca.Location = new System.Drawing.Point(232, 59);
			this.textBoxMarca.Name = "textBoxMarca";
			this.textBoxMarca.Size = new System.Drawing.Size(280, 30);
			this.textBoxMarca.TabIndex = 4;
			// 
			// textBoxModelo
			// 
			this.textBoxModelo.Location = new System.Drawing.Point(232, 84);
			this.textBoxModelo.Name = "textBoxModelo";
			this.textBoxModelo.Size = new System.Drawing.Size(280, 30);
			this.textBoxModelo.TabIndex = 5;
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAgregar.Location = new System.Drawing.Point(232, 146);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(108, 43);
			this.buttonAgregar.TabIndex = 7;
			this.buttonAgregar.Text = "Agregar";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
			// 
			// buttonSacar
			// 
			this.buttonSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSacar.Location = new System.Drawing.Point(404, 146);
			this.buttonSacar.Name = "buttonSacar";
			this.buttonSacar.Size = new System.Drawing.Size(108, 43);
			this.buttonSacar.TabIndex = 8;
			this.buttonSacar.Text = "Sacar";
			this.buttonSacar.UseVisualStyleBackColor = true;
			this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
			// 
			// buttonSystemInfo
			// 
			this.buttonSystemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSystemInfo.Location = new System.Drawing.Point(386, 255);
			this.buttonSystemInfo.Name = "buttonSystemInfo";
			this.buttonSystemInfo.Size = new System.Drawing.Size(234, 46);
			this.buttonSystemInfo.TabIndex = 9;
			this.buttonSystemInfo.Text = " System Info";
			this.buttonSystemInfo.UseVisualStyleBackColor = true;
			this.buttonSystemInfo.Click += new System.EventHandler(this.buttonSystemInfo_Click);
			// 
			// richTextBoxsystemInfo
			// 
			this.richTextBoxsystemInfo.Location = new System.Drawing.Point(5, 340);
			this.richTextBoxsystemInfo.Name = "richTextBoxsystemInfo";
			this.richTextBoxsystemInfo.Size = new System.Drawing.Size(787, 108);
			this.richTextBoxsystemInfo.TabIndex = 10;
			this.richTextBoxsystemInfo.Text = "";
			// 
			// numericUpDownMemoria
			// 
			this.numericUpDownMemoria.Location = new System.Drawing.Point(231, 109);
			this.numericUpDownMemoria.Name = "numericUpDownMemoria";
			this.numericUpDownMemoria.Size = new System.Drawing.Size(281, 30);
			this.numericUpDownMemoria.TabIndex = 11;
			// 
			// groupBoxPlacaVideo
			// 
			this.groupBoxPlacaVideo.Controls.Add(this.numericUpDownMemoria);
			this.groupBoxPlacaVideo.Controls.Add(this.textBoxModelo);
			this.groupBoxPlacaVideo.Controls.Add(this.textBoxMarca);
			this.groupBoxPlacaVideo.Controls.Add(this.labelMarca);
			this.groupBoxPlacaVideo.Controls.Add(this.buttonAgregar);
			this.groupBoxPlacaVideo.Controls.Add(this.buttonSacar);
			this.groupBoxPlacaVideo.Controls.Add(this.labelMemoriaMB);
			this.groupBoxPlacaVideo.Controls.Add(this.labelModelo);
			this.groupBoxPlacaVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxPlacaVideo.Location = new System.Drawing.Point(98, 31);
			this.groupBoxPlacaVideo.Name = "groupBoxPlacaVideo";
			this.groupBoxPlacaVideo.Size = new System.Drawing.Size(522, 203);
			this.groupBoxPlacaVideo.TabIndex = 12;
			this.groupBoxPlacaVideo.TabStop = false;
			this.groupBoxPlacaVideo.Text = "Placa de Video";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBoxPlacaVideo);
			this.Controls.Add(this.richTextBoxsystemInfo);
			this.Controls.Add(this.buttonSystemInfo);
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Luquez.Eliseo.2D";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemoria)).EndInit();
			this.groupBoxPlacaVideo.ResumeLayout(false);
			this.groupBoxPlacaVideo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label labelMarca;
		private System.Windows.Forms.Label labelModelo;
		private System.Windows.Forms.Label labelMemoriaMB;
		private System.Windows.Forms.TextBox textBoxMarca;
		private System.Windows.Forms.TextBox textBoxModelo;
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.Button buttonSacar;
		private System.Windows.Forms.Button buttonSystemInfo;
		private System.Windows.Forms.RichTextBox richTextBoxsystemInfo;
		private System.Windows.Forms.NumericUpDown numericUpDownMemoria;
		private System.Windows.Forms.GroupBox groupBoxPlacaVideo;
	}
}

