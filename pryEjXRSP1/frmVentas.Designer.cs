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
            this.cbFactTipo.Location = new System.Drawing.Point(209, 232);
            this.cbFactTipo.Name = "cbFactTipo";
            this.cbFactTipo.Size = new System.Drawing.Size(239, 28);
            this.cbFactTipo.TabIndex = 25;
            // 
            // lblFactNro
            // 
            this.lblFactNro.AutoSize = true;
            this.lblFactNro.Location = new System.Drawing.Point(41, 309);
            this.lblFactNro.Name = "lblFactNro";
            this.lblFactNro.Size = new System.Drawing.Size(82, 20);
            this.lblFactNro.TabIndex = 24;
            this.lblFactNro.Text = "Factura nro";
            // 
            // lblFactTipo
            // 
            this.lblFactTipo.AutoSize = true;
            this.lblFactTipo.Location = new System.Drawing.Point(41, 234);
            this.lblFactTipo.Name = "lblFactTipo";
            this.lblFactTipo.Size = new System.Drawing.Size(87, 20);
            this.lblFactTipo.TabIndex = 23;
            this.lblFactTipo.Text = "Factura tipo";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(198, 460);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 29);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(355, 460);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(94, 29);
            this.btnCargar.TabIndex = 21;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblVendId
            // 
            this.lblVendId.AutoSize = true;
            this.lblVendId.Location = new System.Drawing.Point(41, 169);
            this.lblVendId.Name = "lblVendId";
            this.lblVendId.Size = new System.Drawing.Size(92, 20);
            this.lblVendId.TabIndex = 18;
            this.lblVendId.Text = "Vendedor ID";
            // 
            // lblIClienteId
            // 
            this.lblIClienteId.AutoSize = true;
            this.lblIClienteId.Location = new System.Drawing.Point(41, 110);
            this.lblIClienteId.Name = "lblIClienteId";
            this.lblIClienteId.Size = new System.Drawing.Size(74, 20);
            this.lblIClienteId.TabIndex = 17;
            this.lblIClienteId.Text = "Cliente ID";
            // 
            // nudFactNum
            // 
            this.nudFactNum.Location = new System.Drawing.Point(209, 306);
            this.nudFactNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudFactNum.Name = "nudFactNum";
            this.nudFactNum.Size = new System.Drawing.Size(240, 27);
            this.nudFactNum.TabIndex = 26;
            this.nudFactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(209, 382);
            this.nudMonto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(240, 27);
            this.nudMonto.TabIndex = 28;
            this.nudMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(41, 385);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(53, 20);
            this.lblMonto.TabIndex = 29;
            this.lblMonto.Text = "Monto";
            // 
            // cbClienteId
            // 
            this.cbClienteId.FormattingEnabled = true;
            this.cbClienteId.Location = new System.Drawing.Point(209, 102);
            this.cbClienteId.Name = "cbClienteId";
            this.cbClienteId.Size = new System.Drawing.Size(240, 28);
            this.cbClienteId.TabIndex = 30;
            this.cbClienteId.SelectedIndexChanged += new System.EventHandler(this.cbClienteId_SelectedIndexChanged);
            // 
            // cbVendedorId
            // 
            this.cbVendedorId.FormattingEnabled = true;
            this.cbVendedorId.Location = new System.Drawing.Point(209, 166);
            this.cbVendedorId.Name = "cbVendedorId";
            this.cbVendedorId.Size = new System.Drawing.Size(240, 28);
            this.cbVendedorId.TabIndex = 31;
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Location = new System.Drawing.Point(41, 21);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(407, 55);
            this.lblMsg.TabIndex = 32;
            this.lblMsg.Text = "El id de la venta se generara automaticamente, sumando\r\nuno con respecto al anter" +
    "ior registro\r\n\r\n";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(41, 460);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 514);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVentas";
            this.Text = "Ventas";
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