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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            //variables
            string nombre = txtNombre2.Text;
            int id = 1;
            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./cliente.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./cliente.txt");
            while (!sr2.EndOfStream)
            {
                string[] arr = sr2.ReadLine().Split(separador);
                string id2 = arr[0];
                id = Convert.ToInt32(id2) + 1; //takes the last id and sums 1 to it, so each time the user registers data, the id sums +1
            }
            sr2.Close();
            if (nombre != "")
            {
                using (StreamWriter sw = File.AppendText("./cliente.txt"))
                {
                    sw.WriteLine(id + "," + nombre);
                    sw.Close();
                }
                txtNombre2.Text = "";
                MessageBox.Show("Added data");
            }
            else
            {
                MessageBox.Show("Uncompleted data!");
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./cliente.txt", "");
            MessageBox.Show("Erased data");
        }
    }
}