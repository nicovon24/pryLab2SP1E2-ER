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
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblVendId = new System.Windows.Forms.Label();
            this.lblIClienteId = new System.Windows.Forms.Label();
            this.nudFactNum = new System.Windows.Forms.NumericUpDown();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cbClienteId = new System.Windows.Forms.ComboBox();
            this.cbVendedorId = new System.Windows.Forms.ComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactNum)).BeginInit();
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
            this.cbFactTipo.Location = new System.Drawing.Point(183, 174);
            this.cbFactTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFactTipo.Name = "cbFactTipo";
            this.cbFactTipo.Size = new System.Drawing.Size(210, 23);
            this.cbFactTipo.TabIndex = 25;
            // 
            // lblFactNro
            // 
            this.lblFactNro.AutoSize = true;
            this.lblFactNro.Location = new System.Drawing.Point(36, 232);
            this.lblFactNro.Name = "lblFactNro";
            this.lblFactNro.Size = new System.Drawing.Size(67, 15);
            this.lblFactNro.TabIndex = 24;
            this.lblFactNro.Text = "Factura nro";
            // 
            // lblFactTipo
            // 
            this.lblFactTipo.AutoSize = true;
            this.lblFactTipo.Location = new System.Drawing.Point(36, 176);
            this.lblFactTipo.Name = "lblFactTipo";
            this.lblFactTipo.Size = new System.Drawing.Size(70, 15);
            this.lblFactTipo.TabIndex = 23;
            this.lblFactTipo.Text = "Factura tipo";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(173, 345);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(82, 22);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(311, 345);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(82, 22);
            this.btnCargar.TabIndex = 21;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblVendId
            // 
            this.lblVendId.AutoSize = true;
            this.lblVendId.Location = new System.Drawing.Point(36, 127);
            this.lblVendId.Name = "lblVendId";
            this.lblVendId.Size = new System.Drawing.Size(71, 15);
            this.lblVendId.TabIndex = 18;
            this.lblVendId.Text = "Vendedor ID";
            // 
            // lblIClienteId
            // 
            this.lblIClienteId.AutoSize = true;
            this.lblIClienteId.Location = new System.Drawing.Point(36, 82);
            this.lblIClienteId.Name = "lblIClienteId";
            this.lblIClienteId.Size = new System.Drawing.Size(58, 15);
            this.lblIClienteId.TabIndex = 17;
            this.lblIClienteId.Text = "Cliente ID";
            // 
            // nudFactNum
            // 
            this.nudFactNum.Location = new System.Drawing.Point(183, 230);
            this.nudFactNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudFactNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudFactNum.Name = "nudFactNum";
            this.nudFactNum.Size = new System.Drawing.Size(210, 23);
            this.nudFactNum.TabIndex = 26;
            this.nudFactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(183, 286);
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
            this.lblMonto.Location = new System.Drawing.Point(36, 289);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 15);
            this.lblMonto.TabIndex = 29;
            this.lblMonto.Text = "Monto";
            // 
            // cbClienteId
            // 
            this.cbClienteId.FormattingEnabled = true;
            this.cbClienteId.Location = new System.Drawing.Point(183, 76);
            this.cbClienteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClienteId.Name = "cbClienteId";
            this.cbClienteId.Size = new System.Drawing.Size(210, 23);
            this.cbClienteId.TabIndex = 30;
            this.cbClienteId.SelectedIndexChanged += new System.EventHandler(this.cbClienteId_SelectedIndexChanged);
            // 
            // cbVendedorId
            // 
            this.cbVendedorId.FormattingEnabled = true;
            this.cbVendedorId.Location = new System.Drawing.Point(183, 124);
            this.cbVendedorId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVendedorId.Name = "cbVendedorId";
            this.cbVendedorId.Size = new System.Drawing.Size(210, 23);
            this.cbVendedorId.TabIndex = 31;
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Location = new System.Drawing.Point(36, 16);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(356, 41);
            this.lblMsg.TabIndex = 32;
            this.lblMsg.Text = "El id de la venta se generara automaticamente, sumando\r\nuno con respecto al anter" +
    "ior registro\r\n\r\n";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(36, 345);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(82, 22);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 386);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.cbVendedorId);
            this.Controls.Add(this.cbClienteId);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.nudFactNum);
            this.Controls.Add(this.cbFactTipo);
            this.Controls.Add(this.lblFactNro);
            this.Controls.Add(this.lblFactTipo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblVendId);
            this.Controls.Add(this.lblIClienteId);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFactNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbFactTipo;
        private Label lblFactNro;
        private Label lblFactTipo;
        private Button btnBorrar;
        private Button btnCargar;
        private Label lblVendId;
        private Label lblIClienteId;
        private NumericUpDown nudFactNum;
        private NumericUpDown nudMonto;
        private Label lblMonto;
        private ComboBox cbClienteId;
        private ComboBox cbVendedorId;
        private Label lblMsg;
        private Button btnVolver;
    }
}