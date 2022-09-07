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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //variables
            int id = Convert.ToInt32(nudID.Text);
            string nombre = txtNombre.Text;
            //flag
            bool flagId = false;
            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./clientes.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./clientes.txt");
            while (!sr2.EndOfStream)
            {
                string[] arrVendedor = sr2.ReadLine().Split(separador);
                int idArr = Convert.ToInt32(arrVendedor[0]);
                if (idArr == id)
                {
                    flagId = true;
                }
            }
            sr2.Close();
            if (flagId == false)
            {
                if (id != 0 && nombre != "")
                {
                    using (StreamWriter sw = File.AppendText("./clientes.txt"))
                    {
                        sw.WriteLine(id + "," + nombre);
                        sw.Close();
                    }
                    nudID.Focus();
                    nudID.Value = 0;
                    txtNombre.Text = "";
                    MessageBox.Show("Added data");
                }
                else { MessageBox.Show("Uncompleted data!"); }
            }
            else { MessageBox.Show("Id repeated!"); }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./cliente.txt", "");
            MessageBox.Show("Erased data");
        }
    }
}
