using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Maestra
{
    public partial class fmrPagarCuota : Form
    {
        int ID_Clientes, ID_Prductos, NumeroCuota, Pago;

        public fmrPagarCuota()
        {
            InitializeComponent();
        }

        private void Restringirsolonumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                ID_Clientes = int.Parse(txtIDClientes.Text);
                ID_Prductos = int.Parse(txtIDProductos.Text);
                NumeroCuota = int.Parse(txtNumeroCuota.Text);
                Pago = int.Parse(txtPago.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los valores no pueden ser nulos. Por favor, llena todos los campos.");
            }

            txtIDClientes.Text = null;
            txtIDProductos.Text = null;
            txtNumeroCuota.Text = null;
            txtPago.Text = null;

            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDClientes.Text = null;
            txtIDProductos.Text = null;
            txtNumeroCuota.Text = null;
            txtPago.Text = null;

            this.Close();
        }
    }
}
