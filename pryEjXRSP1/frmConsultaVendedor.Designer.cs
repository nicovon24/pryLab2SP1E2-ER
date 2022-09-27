namespace pryEjXRSP1
{
    partial class frmConsultaVendedor
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
            this.dtgVendedor = new System.Windows.Forms.DataGridView();
            this.dtgtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdtActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdtComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 305);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(482, 305);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(247, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Borrar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtgVendedor
            // 
            this.dtgVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgtName,
            this.dgdtID,
            this.dgdtActivo,
            this.dgrdtComision});
            this.dtgVendedor.Location = new System.Drawing.Point(12, 21);
            this.dtgVendedor.Name = "dtgVendedor";
            this.dtgVendedor.RowTemplate.Height = 25;
            this.dtgVendedor.Size = new System.Drawing.Size(546, 268);
            this.dtgVendedor.TabIndex = 5;
            this.dtgVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellContentClick);
            // 
            // dtgtName
            // 
            this.dtgtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgtName.HeaderText = "Nombre";
            this.dtgtName.Name = "dtgtName";
            this.dtgtName.Width = 76;
            // 
            // dgdtID
            // 
            this.dgdtID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgdtID.HeaderText = "ID";
            this.dgdtID.Name = "dgdtID";
            this.dgdtID.Width = 43;
            // 
            // dgdtActivo
            // 
            this.dgdtActivo.HeaderText = "Activo";
            this.dgdtActivo.Name = "dgdtActivo";
            // 
            // dgrdtComision
            // 
            this.dgrdtComision.HeaderText = "Comision";
            this.dgrdtComision.Name = "dgrdtComision";
            // 
            // frmConsultaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 356);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtgVendedor);
            this.Name = "frmConsultaVendedor";
            this.Text = "Consulta Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVolver;
        private Button btnShow;
        private Button btnClear;
        private DataGridView dtgVendedor;
        private DataGridViewTextBoxColumn dtgtName;
        private DataGridViewTextBoxColumn dgdtID;
        private DataGridViewTextBoxColumn dgdtActivo;
        private DataGridViewTextBoxColumn dgrdtComision;
    }
}