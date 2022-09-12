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
            string nombre = txtNombre.Text;
            int id = 1;
            string activo = cbActivo.Text;
            string cobraCom = cbCobraCom.Text;
            //flag
            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./vendedor.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./vendedor.txt");
            while (!sr2.EndOfStream)
            {
                string[] arr = sr2.ReadLine().Split(separador);
                string id2 = arr[0];
                id = Convert.ToInt32(id2) + 1; //takes the last id and sums 1 to it, so each time the user registers data, the id sums +1
            }
            sr2.Close();
            //switch, transforming si and no to 0 and -1
            switch (activo) { case "Si": activo = "0"; break; case "No": activo = "-1"; break; }
            switch (cobraCom) { case "Si": cobraCom = "0"; break; case "No": cobraCom = "-1"; break; }
                if (nombre != "" && activo != "" && cobraCom != "")
                {
                    using (StreamWriter sw = File.AppendText("./vendedor.txt"))
                    {
                        sw.WriteLine(id + "," + nombre + "," + activo + "," + cobraCom);
                        sw.Close();
                    }
                    MessageBox.Show("Added data");
                    txtNombre.Text = "";
                    cbCobraCom.Text = "";
                    cbActivo.Text = "";
                    txtNombre.Focus();
                }
                else { MessageBox.Show("Uncompleted data!"); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./vendedor.txt", "");
            MessageBox.Show("Erased data");
        }
    }
}
