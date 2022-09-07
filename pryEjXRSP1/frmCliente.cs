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
            int id = Convert.ToInt32(nudID.Text);
            string nombre = txtNombre.Text;
            if(id!=0 && nombre != "")
            {
                using (StreamWriter sw = File.AppendText("./cliente.txt"))
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./cliente.txt", "Cliente\n");
            MessageBox.Show("Erased data");
        }
    }
}
