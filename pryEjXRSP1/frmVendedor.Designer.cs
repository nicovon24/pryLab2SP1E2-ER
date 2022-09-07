namespace pryEjXRSP1
{
    partial class frmVendedor
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCobraCom = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.cbCobraCom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(24, 294);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 29);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(338, 294);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(192, 24);
            this.nudID.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(240, 27);
            this.nudID.TabIndex = 10;
            this.nudID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(192, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 27);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(24, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 20);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "Id";
            // 
            // lblCobraCom
            // 
            this.lblCobraCom.AutoSize = true;
            this.lblCobraCom.Location = new System.Drawing.Point(24, 223);
            this.lblCobraCom.Name = "lblCobraCom";
            this.lblCobraCom.Size = new System.Drawing.Size(120, 20);
            this.lblCobraCom.TabIndex = 14;
            this.lblCobraCom.Text = "Cobra comision?";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(24, 148);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(58, 20);
            this.lblActivo.TabIndex = 13;
            this.lblActivo.Text = "Activo?";
            // 
            // cbActivo
            // 
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbActivo.Location = new System.Drawing.Point(192, 145);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(240, 28);
            this.cbActivo.TabIndex = 15;
            // 
            // cbCobraCom
            // 
            this.cbCobraCom.FormattingEnabled = true;
            this.cbCobraCom.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbCobraCom.Location = new System.Drawing.Point(192, 215);
            this.cbCobraCom.Name = "cbCobraCom";
            this.cbCobraCom.Size = new System.Drawing.Size(240, 28);
            this.cbCobraCom.TabIndex = 16;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 362);
            this.Controls.Add(this.cbCobraCom);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.lblCobraCom);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBorrar;
        private Button btnAceptar;
        private NumericUpDown nudID;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblID;
        private Label lblCobraCom;
        private Label lblActivo;
        private ComboBox cbActivo;
        private ComboBox cbCobraCom;
    }
}