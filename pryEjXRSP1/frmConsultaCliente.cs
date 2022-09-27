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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgCliente.Rows.Clear();
            MessageBox.Show("Data erased!");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtgCliente.Rows.Clear();
            if (File.Exists("./cliente.txt"))
            {
                char separador = Convert.ToChar(",");
                StreamReader sr = new StreamReader("./cliente.txt");
                while (!sr.EndOfStream) {
                    string[] arrData = sr.ReadLine().Split(separador);
                    dtgCliente.Rows.Add(
                        arrData[1],
                        arrData[0]
                        );
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Clientes file does not exist!");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmNew = new frmPrincipal();
            frmNew.Show();
        }
    }
}
