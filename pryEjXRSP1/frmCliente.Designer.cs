namespace pryEjXRSP1
{
    partial class frmCliente
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBorrar2 = new System.Windows.Forms.Button();
            this.btnAceptar2 = new System.Windows.Forms.Button();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 115);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 29);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(345, 115);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(0, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 0;
            // 
            // btnBorrar2
            // 
            this.btnBorrar2.Location = new System.Drawing.Point(151, 182);
            this.btnBorrar2.Name = "btnBorrar2";
            this.btnBorrar2.Size = new System.Drawing.Size(94, 29);
            this.btnBorrar2.TabIndex = 20;
            this.btnBorrar2.Text = "Borrar";
            this.btnBorrar2.UseVisualStyleBackColor = true;
            this.btnBorrar2.Click += new System.EventHandler(this.btnBorrar2_Click);
            // 
            // btnAceptar2
            // 
            this.btnAceptar2.Location = new System.Drawing.Point(326, 182);
            this.btnAceptar2.Name = "btnAceptar2";
            this.btnAceptar2.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar2.TabIndex = 19;
            this.btnAceptar2.Text = "Aceptar";
            this.btnAceptar2.UseVisualStyleBackColor = true;
            this.btnAceptar2.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(151, 103);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(269, 27);
            this.txtNombre2.TabIndex = 18;
            this.txtNombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(12, 106);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(64, 20);
            this.lblNombre2.TabIndex = 17;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Location = new System.Drawing.Point(13, 21);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(407, 55);
            this.lblMsg.TabIndex = 33;
            this.lblMsg.Text = "El id del cliente se generara automaticamente, sumando\r\nuno con respecto al anter" +
    "ior registro\r\n\r\n";
            // 
            // frmCliente
            // 
            this.ClientSize = new System.Drawing.Size(439, 241);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnBorrar2);
            this.Controls.Add(this.btnAceptar2);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.lblNombre2);
            this.Name = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBorrar;
        private Button btnAceptar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnBorrar2;
        private Button btnAceptar2;
        private TextBox txtNombre2;
        private Label lblNombre2;
        private Label lblMsg;
    }
}