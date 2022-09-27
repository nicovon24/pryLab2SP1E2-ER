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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCliente newFrm = new frmCliente();
            newFrm.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVendedor newFrm = new frmVendedor();
            newFrm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentas newFrm = new frmVentas();
            newFrm.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a good one!");
            this.Hide();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Have a good one!");
            this.Hide();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaCliente newFrm = new frmConsultaCliente();
            newFrm.Show();
        }

        private void consultarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaVendedor newFrm = new frmConsultaVendedor();
            newFrm.Show();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaVentas newFrm = new frmConsultaVentas();
            newFrm.Show();
        }
    }
}
