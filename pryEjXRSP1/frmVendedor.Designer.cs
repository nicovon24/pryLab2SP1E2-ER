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
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCobraCom = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.cbCobraCom = new System.Windows.Forms.ComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(177, 248);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(82, 22);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(304, 248);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(82, 22);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 85);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCobraCom
            // 
            this.lblCobraCom.AutoSize = true;
            this.lblCobraCom.Location = new System.Drawing.Point(30, 195);
            this.lblCobraCom.Name = "lblCobraCom";
            this.lblCobraCom.Size = new System.Drawing.Size(96, 15);
            this.lblCobraCom.TabIndex = 14;
            this.lblCobraCom.Text = "Cobra comision?";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(30, 139);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(46, 15);
            this.lblActivo.TabIndex = 13;
            this.lblActivo.Text = "Activo?";
            // 
            // cbActivo
            // 
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbActivo.Location = new System.Drawing.Point(177, 136);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(210, 23);
            this.cbActivo.TabIndex = 15;
            // 
            // cbCobraCom
            // 
            this.cbCobraCom.FormattingEnabled = true;
            this.cbCobraCom.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbCobraCom.Location = new System.Drawing.Point(177, 189);
            this.cbCobraCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCobraCom.Name = "cbCobraCom";
            this.cbCobraCom.Size = new System.Drawing.Size(210, 23);
            this.cbCobraCom.TabIndex = 16;
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Location = new System.Drawing.Point(30, 21);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(356, 41);
            this.lblMsg.TabIndex = 33;
            this.lblMsg.Text = "El id del vendedorse generara automaticamente, sumando\r\nuno con respecto al anter" +
    "ior registro\r\n\r\n";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(30, 248);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(82, 22);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 296);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.cbCobraCom);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.lblCobraCom);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVendedor";
            this.Text = "Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBorrar;
        private Button btnCargar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblCobraCom;
        private Label lblActivo;
        private ComboBox cbActivo;
        private ComboBox cbCobraCom;
        private Label lblMsg;
        private Button btnVolver;
    }
}