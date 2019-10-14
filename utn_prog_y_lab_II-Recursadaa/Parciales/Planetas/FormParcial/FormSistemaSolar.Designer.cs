namespace FormParcial
{
    partial class FormSistemaSolar
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
            this.lblNombrePlaneta = new System.Windows.Forms.Label();
            this.lblTiempoOrbita = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlanetas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgergarSatelite = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numRotacion = new System.Windows.Forms.NumericUpDown();
            this.numSatelite = new System.Windows.Forms.NumericUpDown();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePlaneta
            // 
            this.lblNombrePlaneta.AutoSize = true;
            this.lblNombrePlaneta.Location = new System.Drawing.Point(12, 35);
            this.lblNombrePlaneta.Name = "lblNombrePlaneta";
            this.lblNombrePlaneta.Size = new System.Drawing.Size(133, 17);
            this.lblNombrePlaneta.TabIndex = 0;
            this.lblNombrePlaneta.Text = "Nombre del Planeta";
            // 
            // lblTiempoOrbita
            // 
            this.lblTiempoOrbita.AutoSize = true;
            this.lblTiempoOrbita.Location = new System.Drawing.Point(12, 70);
            this.lblTiempoOrbita.Name = "lblTiempoOrbita";
            this.lblTiempoOrbita.Size = new System.Drawing.Size(184, 17);
            this.lblTiempoOrbita.TabIndex = 1;
            this.lblTiempoOrbita.Text = "Tiempo en completar Orbita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo en completar Rotacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Lunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Planeta";
            // 
            // lblPlanetas
            // 
            this.lblPlanetas.AutoSize = true;
            this.lblPlanetas.Location = new System.Drawing.Point(359, 32);
            this.lblPlanetas.Name = "lblPlanetas";
            this.lblPlanetas.Size = new System.Drawing.Size(63, 17);
            this.lblPlanetas.TabIndex = 5;
            this.lblPlanetas.Text = "Planetas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre Satelite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiempo en completar Orbita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiempo en completar Rotacion";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(234, 29);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(109, 22);
            this.txtNombrePlaneta.TabIndex = 9;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(234, 65);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(109, 22);
            this.txtOrbitaPlaneta.TabIndex = 10;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(195, 172);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(148, 24);
            this.cmbTipo.TabIndex = 13;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(566, 32);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(134, 24);
            this.cmbPlanetas.TabIndex = 14;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(566, 67);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(137, 22);
            this.txtNombreSatelite.TabIndex = 15;
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(64, 278);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(169, 44);
            this.btnAgregarPlaneta.TabIndex = 18;
            this.btnAgregarPlaneta.Text = "Agregar Planeta";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.btnAgregarPlaneta_Click);
            // 
            // btnAgergarSatelite
            // 
            this.btnAgergarSatelite.Location = new System.Drawing.Point(330, 281);
            this.btnAgergarSatelite.Name = "btnAgergarSatelite";
            this.btnAgergarSatelite.Size = new System.Drawing.Size(138, 41);
            this.btnAgergarSatelite.TabIndex = 19;
            this.btnAgergarSatelite.Text = "Agergar Satelite";
            this.btnAgergarSatelite.UseVisualStyleBackColor = true;
            this.btnAgergarSatelite.Click += new System.EventHandler(this.btnAgergarSatelite_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(180, 348);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(259, 29);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.Text = "Mostrar Informacion";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(184, 411);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(232, 31);
            this.btnMoverAstros.TabIndex = 21;
            this.btnMoverAstros.Text = "MoverAstros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.btnMoverAstros_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(716, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 455);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // numRotacion
            // 
            this.numRotacion.Location = new System.Drawing.Point(235, 107);
            this.numRotacion.Name = "numRotacion";
            this.numRotacion.Size = new System.Drawing.Size(107, 22);
            this.numRotacion.TabIndex = 23;
            // 
            // numSatelite
            // 
            this.numSatelite.Location = new System.Drawing.Point(234, 142);
            this.numSatelite.Name = "numSatelite";
            this.numSatelite.Size = new System.Drawing.Size(107, 22);
            this.numSatelite.TabIndex = 24;
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(575, 103);
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(124, 22);
            this.numOrbitaSatelite.TabIndex = 25;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(582, 140);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(116, 22);
            this.numRotacionSatelite.TabIndex = 26;
            // 
            // FormSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 519);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.numSatelite);
            this.Controls.Add(this.numRotacion);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAgergarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPlanetas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTiempoOrbita);
            this.Controls.Add(this.lblNombrePlaneta);
            this.Name = "FormSistemaSolar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePlaneta;
        private System.Windows.Forms.Label lblTiempoOrbita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlanetas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.Button btnAgregarPlaneta;
        private System.Windows.Forms.Button btnAgergarSatelite;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMoverAstros;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numRotacion;
        private System.Windows.Forms.NumericUpDown numSatelite;
        private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
    }
}

