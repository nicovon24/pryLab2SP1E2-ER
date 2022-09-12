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
            //adding ids to the two first combo boxes!!!

            char separador = Convert.ToChar(","); //defining a separator for the Split
            //cliente id
            StreamReader srClienteId = new StreamReader("./cliente.txt");
            while (!srClienteId.EndOfStream)
            {
                string[] arrCliente = srClienteId.ReadLine().Split(separador);
                cbClienteId.Items.Add(arrCliente[0]);
            }
            srClienteId.Close();
            //vendedor id
            StreamReader srVendedorId = new StreamReader("./vendedor.txt");
            while (!srVendedorId.EndOfStream)
            {
                string[] arrVendedor = srVendedorId.ReadLine().Split(separador);
                cbVendedorId.Items.Add(arrVendedor[0]);
            }
            srVendedorId.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //variables
            int idVentas = 1;
            string idVendedor = cbVendedorId.Text;
            string idCliente = cbClienteId.Text;
            string facturaTipo = cbFactTipo.Text;
            int facturaNro = Convert.ToInt32(nudFactNum.Text);
            int monto = Convert.ToInt32(nudMonto.Text);

            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./ventas.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./ventas.txt");
            while (!sr2.EndOfStream)
            {
                string[] arr = sr2.ReadLine().Split(separador);
                string idVentas2 = arr[0];
                idVentas = Convert.ToInt32(idVentas2) + 1; //takes the last id and sums 1 to it, so each time the user registers data, the id sums +1
            }
            sr2.Close();
            if (idVendedor!="0" && idCliente!="0" && facturaTipo!="" && facturaNro!=0 && monto!=0)
            {
                using (StreamWriter sw = File.AppendText("./ventas.txt"))
                {
                    sw.WriteLine(idVentas + "," + idVendedor + "," + idCliente + "," + facturaTipo + "," + facturaNro + "," + monto);
                    sw.Close();
                }
                MessageBox.Show("Added data");
            }
            else
            {
                MessageBox.Show("Uncompleted data!");
            }
        }
    }
}
