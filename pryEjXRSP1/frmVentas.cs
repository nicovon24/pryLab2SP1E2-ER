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
        char separador = Convert.ToChar(","); //defining a separator for the Split

        private void hideFormulare() //will be used in case one of the files does not exist
        {
            cbFactTipo.Enabled = false;
            nudFactNum.Enabled = false;
            nudMonto.Enabled = false;
            btnCargar.Enabled = false;
            btnBorrar.Enabled = false;
            cbClienteId.Enabled = false;
            cbVendedorId.Enabled = false;
        }

        public frmVentas()
        {
            InitializeComponent();
            if (File.Exists("./cliente.txt")){
                //adding ids to the two first combo boxes!!!
                //cliente id
                StreamReader srClienteId = new StreamReader("./cliente.txt", true);
                while (!srClienteId.EndOfStream)
                {
                    string[] arrCliente = srClienteId.ReadLine().Split(separador);
                    cbClienteId.Items.Add(arrCliente[1] + " " + arrCliente[0]); //Fer 1 
                }
                srClienteId.Close();
            }
            else
            {
                MessageBox.Show("No existe el archivo clientes, no va a poder ingresar datos en este formulario");
                hideFormulare();
            }


            if (File.Exists("./vendedor.txt"))
            {
                //vendedor id
                StreamReader srVendedorId = new StreamReader("./vendedor.txt");
                while (!srVendedorId.EndOfStream)
                {
                    string[] arrVendedor = srVendedorId.ReadLine().Split(separador);
                    cbVendedorId.Items.Add(arrVendedor[1] + " " + arrVendedor[0]); //Nico 1
                }
                srVendedorId.Close();
            }
            else
            {
                MessageBox.Show("No existe el archivo vendedor, no va a poder ingresar datos en este formulario");
                hideFormulare();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //variables
            int idVentas = 1;
            string vendedor = cbVendedorId.Text;
            string cliente = cbClienteId.Text;
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
            if (vendedor != "" && cliente != "" && facturaTipo != "" && facturaNro != 0 && monto != 0)
            {
                using (StreamWriter sw = File.AppendText("./ventas.txt"))
                {
                    sw.WriteLine(idVentas + "," + vendedor + "," + cliente + "," + facturaTipo + "," + facturaNro + ",$" + monto);
                    sw.Close();
                }
                MessageBox.Show("Added data");
                cbVendedorId.Text = "";
                cbClienteId.Text = "";
                cbFactTipo.Text = "";
                nudFactNum.Value = 0;
                nudMonto.Value = 0;
                cbVendedorId.Focus();
            }
            else
            {
                MessageBox.Show("Uncompleted data!");
            }
        }

        private void cbClienteId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./ventas.txt", "");
            MessageBox.Show("Erased data");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmNew = new frmPrincipal();
            frmNew.Show();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
