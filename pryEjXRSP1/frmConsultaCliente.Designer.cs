namespace pryEjXRSP1
{
    partial class frmConsultaCliente
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
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.dtgtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgtName,
            this.dgdtID});
            this.dtgCliente.Location = new System.Drawing.Point(12, 0);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.RowTemplate.Height = 25;
            this.dtgCliente.Size = new System.Drawing.Size(234, 268);
            this.dtgCliente.TabIndex = 1;
            this.dtgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Borrar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(171, 292);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 292);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 374);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtgCliente);
            this.Name = "frmConsultaCliente";
            this.Text = "Consulta cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgCliente;
        private Button btnClear;
        private Button btnShow;
        private Button btnVolver;
        private DataGridViewTextBoxColumn dtgtName;
        private DataGridViewTextBoxColumn dgdtID;
    }
}