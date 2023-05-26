using Finisar.SQLite;
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
    public partial class fmrActualizarProducto : Form
    {
        string NombreP, ValorP;
        int Id;

        public void Limpiartxt()
        {
            txtID.Text = string.Empty;
            txtNombreP.Text = string.Empty;
            txtValorP.Text = string.Empty;

            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            // Establecer conexión a la base de datos
            Conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version = 3; Compress= True");
            try
            {
                Conexion_sqlite.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró la base de datos");
            }

            // Crear el comando de inserción y asignar los valores de los campos de texto
            cmd_sqlite = Conexion_sqlite.CreateCommand();
            try
            {
                Id = int.Parse(txtID.Text);
                NombreP = txtNombreP.Text;
                ValorP = txtValorP.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los valores no pueden ser nulos. Por favor, llena todos los campos.");
            }

            // Ejecutar la consulta de inserción en la base de datos
            cmd_sqlite.CommandText = $"UPDATE tblProducto SET Nombre_Producto = '{NombreP}', Valor_Producto = '{ValorP}' WHERE ID = '{Id}'";
            cmd_sqlite.ExecuteNonQuery();
            // Cerrar la conexión a la base de datos
            Conexion_sqlite.Close();

            Limpiartxt();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiartxt();
        }

        public fmrActualizarProducto()
        {
            InitializeComponent();
        }
    }
}
