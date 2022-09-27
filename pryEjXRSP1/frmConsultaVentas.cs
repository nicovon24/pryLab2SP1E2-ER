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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (File.Exists("./ventas.txt"))
            {
                dtgVentas.Rows.Clear();
                char separador = Convert.ToChar(",");
                StreamReader sr = new StreamReader("./ventas.txt");
                while (!sr.EndOfStream)
                {
                    string[] arrData = sr.ReadLine().Split(separador);
                    dtgVentas.Rows.Add(
                        arrData[0],
                        arrData[1],
                        arrData[2],
                        arrData[4],
                        arrData[3],
                        arrData[5]
                    );
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Ventas file does not exist!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgVentas.Rows.Clear();
            MessageBox.Show("Data erased!");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmPrincipal frmNew = new frmPrincipal();
            frmNew.Show();
        }

        private void dtgVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
