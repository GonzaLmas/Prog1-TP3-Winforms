namespace SerieFibonacci
{
    partial class frmFibonacci
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.lbxFibonacci = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(170, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(156, 54);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 2;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(82, 27);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(252, 13);
            this.lblCant.TabIndex = 4;
            this.lblCant.Text = "Ingrese la cantidad de números de la seria a mostrar";
            // 
            // lbxFibonacci
            // 
            this.lbxFibonacci.FormattingEnabled = true;
            this.lbxFibonacci.Location = new System.Drawing.Point(85, 145);
            this.lbxFibonacci.Name = "lbxFibonacci";
            this.lbxFibonacci.Size = new System.Drawing.Size(206, 160);
            this.lbxFibonacci.TabIndex = 5;
            // 
            // frmFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 365);
            this.Controls.Add(this.lbxFibonacci);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.btnCalcular);
            this.MaximumSize = new System.Drawing.Size(473, 404);
            this.MinimumSize = new System.Drawing.Size(473, 404);
            this.Name = "frmFibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serie Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.ListBox lbxFibonacci;
    }
}

