namespace Tarea28032019
{
    partial class frmOperaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbSuma = new System.Windows.Forms.CheckBox();
            this.chbResta = new System.Windows.Forms.CheckBox();
            this.chbMultiplicacion = new System.Windows.Forms.CheckBox();
            this.chbDivision = new System.Windows.Forms.CheckBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbSuma
            // 
            this.chbSuma.AutoSize = true;
            this.chbSuma.Location = new System.Drawing.Point(25, 103);
            this.chbSuma.Name = "chbSuma";
            this.chbSuma.Size = new System.Drawing.Size(53, 17);
            this.chbSuma.TabIndex = 0;
            this.chbSuma.Text = "Suma";
            this.chbSuma.UseVisualStyleBackColor = true;
            this.chbSuma.CheckedChanged += new System.EventHandler(this.chbSuma_CheckedChanged);
            // 
            // chbResta
            // 
            this.chbResta.AutoSize = true;
            this.chbResta.Location = new System.Drawing.Point(176, 103);
            this.chbResta.Name = "chbResta";
            this.chbResta.Size = new System.Drawing.Size(54, 17);
            this.chbResta.TabIndex = 1;
            this.chbResta.Text = "Resta";
            this.chbResta.UseVisualStyleBackColor = true;
            this.chbResta.CheckedChanged += new System.EventHandler(this.chbResta_CheckedChanged);
            // 
            // chbMultiplicacion
            // 
            this.chbMultiplicacion.AutoSize = true;
            this.chbMultiplicacion.Location = new System.Drawing.Point(25, 146);
            this.chbMultiplicacion.Name = "chbMultiplicacion";
            this.chbMultiplicacion.Size = new System.Drawing.Size(90, 17);
            this.chbMultiplicacion.TabIndex = 2;
            this.chbMultiplicacion.Text = "Multiplicacion";
            this.chbMultiplicacion.UseVisualStyleBackColor = true;
            this.chbMultiplicacion.CheckedChanged += new System.EventHandler(this.chbMultiplicacion_CheckedChanged);
            // 
            // chbDivision
            // 
            this.chbDivision.AutoSize = true;
            this.chbDivision.Location = new System.Drawing.Point(176, 146);
            this.chbDivision.Name = "chbDivision";
            this.chbDivision.Size = new System.Drawing.Size(63, 17);
            this.chbDivision.TabIndex = 3;
            this.chbDivision.Text = "Division";
            this.chbDivision.UseVisualStyleBackColor = true;
            this.chbDivision.CheckedChanged += new System.EventHandler(this.chbDivision_CheckedChanged);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(90, 34);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(90, 60);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(109, 195);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero 2";
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.chbDivision);
            this.Controls.Add(this.chbMultiplicacion);
            this.Controls.Add(this.chbResta);
            this.Controls.Add(this.chbSuma);
            this.Name = "frmOperaciones";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbSuma;
        private System.Windows.Forms.CheckBox chbResta;
        private System.Windows.Forms.CheckBox chbMultiplicacion;
        private System.Windows.Forms.CheckBox chbDivision;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

