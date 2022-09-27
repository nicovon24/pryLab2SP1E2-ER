namespace pryEjXRSP1
{
    partial class frmConsultaVentas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.dtgtIDVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdtCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdtVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdtNroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdtTipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdtMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(662, 296);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(337, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Borrar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtgVentas
            // 
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgtIDVentas,
            this.dgdtCliente,
            this.dgdtVendedor,
            this.dgrdtNroFact,
            this.dgdtTipoFactura,
            this.dgdtMonto});
            this.dtgVentas.Location = new System.Drawing.Point(12, 12);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.RowTemplate.Height = 25;
            this.dtgVentas.Size = new System.Drawing.Size(726, 268);
            this.dtgVentas.TabIndex = 9;
            this.dtgVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVentas_CellContentClick);
            // 
            // dtgtIDVentas
            // 
            this.dtgtIDVentas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgtIDVentas.HeaderText = "ID Ventas";
            this.dtgtIDVentas.Name = "dtgtIDVentas";
            this.dtgtIDVentas.Width = 80;
            // 
            // dgdtCliente
            // 
            this.dgdtCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgdtCliente.HeaderText = "Cliente";
            this.dgdtCliente.Name = "dgdtCliente";
            this.dgdtCliente.Width = 69;
            // 
            // dgdtVendedor
            // 
            this.dgdtVendedor.HeaderText = "Vendedor";
            this.dgdtVendedor.Name = "dgdtVendedor";
            // 
            // dgrdtNroFact
            // 
            this.dgrdtNroFact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgrdtNroFact.HeaderText = "Nro de factura";
            this.dgrdtNroFact.Name = "dgrdtNroFact";
            this.dgrdtNroFact.Width = 108;
            // 
            // dgdtTipoFactura
            // 
            this.dgdtTipoFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgdtTipoFactura.HeaderText = "Tipo de Factura";
            this.dgdtTipoFactura.Name = "dgdtTipoFactura";
            this.dgdtTipoFactura.Width = 113;
            // 
            // dgdtMonto
            // 
            this.dgdtMonto.HeaderText = "Monto";
            this.dgdtMonto.Name = "dgdtMonto";
            // 
            // frmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 370);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtgVentas);
            this.Name = "frmConsultaVentas";
            this.Text = "Consulta ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVolver;
        private Button btnShow;
        private Button btnClear;
        private DataGridView dtgVentas;
        private DataGridViewTextBoxColumn dtgtIDVentas;
        private DataGridViewTextBoxColumn dgdtCliente;
        private DataGridViewTextBoxColumn dgdtVendedor;
        private DataGridViewTextBoxColumn dgrdtNroFact;
        private DataGridViewTextBoxColumn dgdtTipoFactura;
        private DataGridViewTextBoxColumn dgdtMonto;
    }
}