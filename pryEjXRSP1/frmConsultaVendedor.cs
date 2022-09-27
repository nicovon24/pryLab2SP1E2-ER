using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjXRSP1
{
    public partial class frmConsultaVendedor : Form
    {
        public frmConsultaVendedor()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtgVendedor.Rows.Clear();
            if (File.Exists("./vendedor.txt"))
            {
                char separador = Convert.ToChar(",");
                StreamReader sr = new StreamReader("./vendedor.txt");
                while (!sr.EndOfStream)
                {
                    string[] arrData = sr.ReadLine().Split(separador);
                    dtgVendedor.Rows.Add(
                        arrData[1],
                        arrData[0],
                        arrData[2],
                        arrData[3]
                    );
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Vendedor file does not exist!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgVendedor.Rows.Clear();
            MessageBox.Show("Data erased!");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmPrincipal frmNew = new frmPrincipal();
            frmNew.Show();
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
