namespace EscalaTemperaturas
{
    partial class frmTemperaturas
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
            this.cboEscalaInicial = new System.Windows.Forms.ComboBox();
            this.cboEscalaFinal = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvEscalas = new System.Windows.Forms.DataGridView();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.escInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmpFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscalas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEscalaInicial
            // 
            this.cboEscalaInicial.FormattingEnabled = true;
            this.cboEscalaInicial.Location = new System.Drawing.Point(304, 47);
            this.cboEscalaInicial.Name = "cboEscalaInicial";
            this.cboEscalaInicial.Size = new System.Drawing.Size(121, 21);
            this.cboEscalaInicial.TabIndex = 0;
            this.cboEscalaInicial.SelectedIndexChanged += new System.EventHandler(this.cboEscalaInicial_SelectedIndexChanged);
            // 
            // cboEscalaFinal
            // 
            this.cboEscalaFinal.Enabled = false;
            this.cboEscalaFinal.FormattingEnabled = true;
            this.cboEscalaFinal.Location = new System.Drawing.Point(304, 88);
            this.cboEscalaFinal.Name = "cboEscalaFinal";
            this.cboEscalaFinal.Size = new System.Drawing.Size(121, 21);
            this.cboEscalaFinal.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(304, 137);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 2;
            // 
            // dgvEscalas
            // 
            this.dgvEscalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.escInicial,
            this.escFinal,
            this.tempFinal,
            this.tmpFinal});
            this.dgvEscalas.Location = new System.Drawing.Point(74, 245);
            this.dgvEscalas.Name = "dgvEscalas";
            this.dgvEscalas.Size = new System.Drawing.Size(443, 168);
            this.dgvEscalas.TabIndex = 3;
            this.dgvEscalas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEscalas_CellContentClick);
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(146, 50);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(152, 13);
            this.lblInicial.TabIndex = 4;
            this.lblInicial.Text = "Seleccione la escala de origen";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(88, 91);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(210, 13);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.Text = "Seleccione la escala a cualquiera convertir";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(88, 140);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(210, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Ingrese el valor numérico de la temperatura";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(255, 189);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // escInicial
            // 
            this.escInicial.HeaderText = "Escala Inicial";
            this.escInicial.Name = "escInicial";
            this.escInicial.ReadOnly = true;
            // 
            // escFinal
            // 
            this.escFinal.HeaderText = "Escala Final";
            this.escFinal.Name = "escFinal";
            this.escFinal.ReadOnly = true;
            // 
            // tempFinal
            // 
            this.tempFinal.HeaderText = "Temperatura Inicial";
            this.tempFinal.Name = "tempFinal";
            this.tempFinal.ReadOnly = true;
            // 
            // tmpFinal
            // 
            this.tmpFinal.HeaderText = "Temperatura Final";
            this.tmpFinal.Name = "tmpFinal";
            this.tmpFinal.ReadOnly = true;
            // 
            // frmTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 476);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.dgvEscalas);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cboEscalaFinal);
            this.Controls.Add(this.cboEscalaInicial);
            this.Name = "frmTemperaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperaturas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEscalaInicial;
        private System.Windows.Forms.ComboBox cboEscalaFinal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgvEscalas;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.DataGridViewTextBoxColumn escInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn escFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmpFinal;
    }
}

