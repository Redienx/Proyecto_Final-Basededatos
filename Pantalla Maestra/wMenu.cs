using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace menu
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void img_barras_Click(object sender, EventArgs e)
        {
            
        }

        private void img_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void img_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            img_restaurar.Visible = true;
            img_maximizar.Visible = false;
        }

        private void img_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void img_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            img_restaurar.Visible = false;
            img_maximizar.Visible = true;
        }

        private void pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void formproduc(object formhijo)
        {
            if (this.pnl_contenedor.Controls.Count > 0) 
                this.pnl_contenedor.Controls.RemoveAt(0);
            Form forhijo = formhijo as Form;
            forhijo.TopLevel = false;
            forhijo.Dock = DockStyle.Fill;
            this.pnl_contenedor.Controls.Add(forhijo);
            this.pnl_contenedor.Tag = forhijo;
            forhijo.Show();

        }
        private void btn_productos_Click(object sender, EventArgs e)
        {

        }
    }
}
