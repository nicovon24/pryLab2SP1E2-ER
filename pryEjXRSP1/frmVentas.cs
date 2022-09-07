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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //variables
            int idCliente = Convert.ToInt32("./ventas.txt");
            //flag
            bool flagId = false;
            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./ventas.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./ventas.txt");
            while (!sr2.EndOfStream)
            {
                string[] arrVendedor = sr2.ReadLine().Split(separador);
                int idArr = Convert.ToInt32(arrVendedor[0]);
                if (idArr == idCliente)
                {
                    flagId = true;
                }
            }
            sr2.Close();
            if (flagId == false)
            {
                if (idCliente != 0)
                {
                    using (StreamWriter sw = File.AppendText("./cliente.txt"))
                    {
                        sw.WriteLine(idCliente + ",");
                        sw.Close();
                    }
                    MessageBox.Show("Added data");
                }
                else { MessageBox.Show("Uncompleted data!"); }
            }
            else { MessageBox.Show("Id repeated!"); }
        }
    }
}
