using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEjXRSP1
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //variables
            int id = Convert.ToInt32(nudID.Text);
            string nombre = txtNombre.Text;
            string activo = cbActivo.Text;
            string cobraCom = cbCobraCom.Text;
            //flag
            bool flagId = false;
            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./vendedor.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./vendedor.txt");
            while (!sr2.EndOfStream)
            {
                string[] arrVendedor = sr2.ReadLine().Split(separador);
                int idArr = Convert.ToInt32(arrVendedor[0]);
                if(idArr == id)
                {
                    flagId = true;
                }
            }
            sr2.Close();
            //switch, transforming si and no to 0 and -1
            switch (activo) { case "Si": activo = "0"; break; case "No": activo = "-1"; break; }
            switch (cobraCom) { case "Si": cobraCom = "0"; break; case "No": cobraCom = "-1"; break; }
            if (flagId == false)
            {
                if (id != 0 && nombre != "" && activo != "" && cobraCom != "")
                {
                    using (StreamWriter sw = File.AppendText("./vendedor.txt"))
                    {
                        sw.WriteLine(id + "," + nombre + "," + activo + "," + cobraCom);
                        sw.Close();
                    }
                    MessageBox.Show("Added data");
                    txtNombre.Text = "";
                    nudID.Value = 0;
                    cbCobraCom.Text = "";
                    cbActivo.Text = "";
                    txtNombre.Focus();
                }
                else { MessageBox.Show("Uncompleted data!"); }
            }
            else
            {
                MessageBox.Show("Id repeated!");
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./vendedor.txt", "");
            MessageBox.Show("Erased data");
        }
    }
}
