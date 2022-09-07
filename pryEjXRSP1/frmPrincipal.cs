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
            frmCliente newFrm = new frmCliente();
            newFrm.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor newFrm = new frmVendedor();
            newFrm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas newFrm = new frmVentas();
            newFrm.Show();
        }
    }
}
