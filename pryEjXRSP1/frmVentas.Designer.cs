namespace pryEjXRSP1
{
    partial class frmVentas
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
            this.cbFactTipo = new System.Windows.Forms.ComboBox();
            this.lblFactNro = new System.Windows.Forms.Label();
            this.lblFactTipo = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nudClienteId = new System.Windows.Forms.NumericUpDown();
            this.lblVendId = new System.Windows.Forms.Label();
            this.lblIClienteId = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nudVendId = new System.Windows.Forms.NumericUpDown();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.lblMonto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudClienteId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVendId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFactTipo
            // 
            this.cbFactTipo.FormattingEnabled = true;
            this.cbFactTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbFactTipo.Location = new System.Drawing.Point(182, 125);
            this.cbFactTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFactTipo.Name = "cbFactTipo";
            this.cbFactTipo.Size = new System.Drawing.Size(210, 23);
            this.cbFactTipo.TabIndex = 25;
            // 
            // lblFactNro
            // 
            this.lblFactNro.AutoSize = true;
            this.lblFactNro.Location = new System.Drawing.Point(35, 183);
            this.lblFactNro.Name = "lblFactNro";
            this.lblFactNro.Size = new System.Drawing.Size(67, 15);
            this.lblFactNro.TabIndex = 24;
            this.lblFactNro.Text = "Factura nro";
            // 
            // lblFactTipo
            // 
            this.lblFactTipo.AutoSize = true;
            this.lblFactTipo.Location = new System.Drawing.Point(35, 127);
            this.lblFactTipo.Name = "lblFactTipo";
            this.lblFactTipo.Size = new System.Drawing.Size(70, 15);
            this.lblFactTipo.TabIndex = 23;
            this.lblFactTipo.Text = "Factura tipo";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(35, 296);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(82, 22);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(310, 296);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 22);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nudClienteId
            // 
            this.nudClienteId.Location = new System.Drawing.Point(182, 26);
            this.nudClienteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudClienteId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudClienteId.Name = "nudClienteId";
            this.nudClienteId.Size = new System.Drawing.Size(210, 23);
            this.nudClienteId.TabIndex = 20;
            this.nudClienteId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVendId
            // 
            this.lblVendId.AutoSize = true;
            this.lblVendId.Location = new System.Drawing.Point(35, 78);
            this.lblVendId.Name = "lblVendId";
            this.lblVendId.Size = new System.Drawing.Size(71, 15);
            this.lblVendId.TabIndex = 18;
            this.lblVendId.Text = "Vendedor ID";
            // 
            // lblIClienteId
            // 
            this.lblIClienteId.AutoSize = true;
            this.lblIClienteId.Location = new System.Drawing.Point(35, 34);
            this.lblIClienteId.Name = "lblIClienteId";
            this.lblIClienteId.Size = new System.Drawing.Size(58, 15);
            this.lblIClienteId.TabIndex = 17;
            this.lblIClienteId.Text = "Cliente ID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(182, 181);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(210, 23);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudVendId
            // 
            this.nudVendId.Location = new System.Drawing.Point(182, 76);
            this.nudVendId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudVendId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVendId.Name = "nudVendId";
            this.nudVendId.Size = new System.Drawing.Size(210, 23);
            this.nudVendId.TabIndex = 27;
            this.nudVendId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(182, 238);
            this.nudMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMonto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(210, 23);
            this.nudMonto.TabIndex = 28;
            this.nudMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(35, 240);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 15);
            this.lblMonto.TabIndex = 29;
            this.lblMonto.Text = "Monto";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 348);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.nudVendId);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbFactTipo);
            this.Controls.Add(this.lblFactNro);
            this.Controls.Add(this.lblFactTipo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nudClienteId);
            this.Controls.Add(this.lblVendId);
            this.Controls.Add(this.lblIClienteId);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.nudClienteId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVendId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbFactTipo;
        private Label lblFactNro;
        private Label lblFactTipo;
        private Button btnBorrar;
        private Button btnAceptar;
        private NumericUpDown nudClienteId;
        private Label lblVendId;
        private Label lblIClienteId;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nudVendId;
        private NumericUpDown nudMonto;
        private Label lblMonto;
    }
}