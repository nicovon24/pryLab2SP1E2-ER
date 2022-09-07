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
            this.cbCobraCom = new System.Windows.Forms.ComboBox();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.lblCobraCom = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCobraCom
            // 
            this.cbCobraCom.FormattingEnabled = true;
            this.cbCobraCom.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbCobraCom.Location = new System.Drawing.Point(159, 168);
            this.cbCobraCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCobraCom.Name = "cbCobraCom";
            this.cbCobraCom.Size = new System.Drawing.Size(210, 23);
            this.cbCobraCom.TabIndex = 26;
            // 
            // cbActivo
            // 
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbActivo.Location = new System.Drawing.Point(159, 116);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(210, 23);
            this.cbActivo.TabIndex = 25;
            // 
            // lblCobraCom
            // 
            this.lblCobraCom.AutoSize = true;
            this.lblCobraCom.Location = new System.Drawing.Point(12, 174);
            this.lblCobraCom.Name = "lblCobraCom";
            this.lblCobraCom.Size = new System.Drawing.Size(96, 15);
            this.lblCobraCom.TabIndex = 24;
            this.lblCobraCom.Text = "Cobra comision?";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(12, 118);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(46, 15);
            this.lblActivo.TabIndex = 23;
            this.lblActivo.Text = "Activo?";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 227);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(82, 22);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(287, 227);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 22);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(159, 25);
            this.nudID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudID.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(210, 23);
            this.nudID.TabIndex = 20;
            this.nudID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 15);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "Id";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbCobraCom;
        private ComboBox cbActivo;
        private Label lblCobraCom;
        private Label lblActivo;
        private Button btnBorrar;
        private Button btnAceptar;
        private NumericUpDown nudID;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblID;
    }
}