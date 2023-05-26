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
    public partial class fmrTablaProductos : Form
    {
        // Varibles
        int indice = 0;
        public fmrTablaProductos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se activa cuando se carga el formulario.
        /// Establece la conexión con la base de datos y carga los datos de la tabla de clientes en el DataGridView.
        /// </summary>
        private void fmrTablaProductos_Load(object sender, EventArgs e)
        {
            // Se establece la conexión con la base de datos SQLite
            SQLiteConnection Conexion_sqlite;
            Conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version = 3; Compress= True");

            try
            {
                Conexion_sqlite.Open(); // Se abre la conexión
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró la base de datos");
            }

            // Consulta para obtener todos los registros de la tabla de clientes
            string Consulta = "SELECT * FROM tblProducto";
            // Ejecutar la consulta y llenar un DataTable con los resultados
            SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
            DataTable dt = new DataTable();
            dataAdapter_sqlite.Fill(dt);
            dtgProducto.DataSource = dt; // Se asigna el resultado de la consulta a un DataGridView llamado "dtgUsuarios"

            Conexion_sqlite.Close(); // Se cierra la conexión
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Actualizar Base".
        /// Vuelve a cargar los datos de la tabla de clientes desde la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void btnActualizarBase_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            Conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version = 3; Compress= True");

            try
            {
                Conexion_sqlite.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró la base de datos");
            }

            string Consulta = "SELECT * FROM tblProducto";
            SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
            DataTable dt = new DataTable();
            dataAdapter_sqlite.Fill(dt);
            dtgProducto.DataSource = dt;

            Conexion_sqlite.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            fmrCrearProducto fmrCrearProducto = new fmrCrearProducto();
            fmrCrearProducto.Show();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Buscar".
        /// Realiza una consulta a la base de datos según los criterios de búsqueda seleccionados por el usuario y muestra el resultado en el DataGridView.
        /// </summary>

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            Conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version = 3; Compress= True");

            try
            {
                Conexion_sqlite.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró la base de datos");
            }

            if (rbnid.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * FROM tblProducto WHERE ID = " + txtBuscar.Text + "";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgProducto.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnNombreP.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * FROM tblProducto WHERE Nombre_Producto = '" + txtBuscar.Text + "'";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgProducto.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnProducto.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * FROM tblProducto WHERE Valor_Producto = '" + txtBuscar.Text + "'";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgProducto.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dtgProducto.CurrentCell = dtgProducto.Rows[Siguiente].Cells[dtgProducto.CurrentCell.ColumnIndex];
            }
            catch (Exception ex) { MessageBox.Show("Llego al tope maximo"); }
        }

        // Evento que se activa al hacer clic en el botón "Anterior"
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int Anterior = indice - 1;
            try
            {
                dtgProducto.CurrentCell = dtgProducto.Rows[Anterior].Cells[dtgProducto.CurrentCell.ColumnIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llego al tope Maximo");
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            dtgProducto.CurrentCell = dtgProducto.Rows[0].Cells[dtgProducto.CurrentCell.ColumnIndex];
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            dtgProducto.CurrentCell = dtgProducto.Rows[dtgProducto.RowCount - 1].Cells[0];
        }

        private void dtgProducto_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dtgProducto.CurrentRow != null)
            {
                indice = dtgProducto.CurrentRow.Index;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            fmrActualizarProducto fmrActualizarProducto = new fmrActualizarProducto();
            fmrActualizarProducto.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            fmrBorrarProducto fmrBorrarProducto = new fmrBorrarProducto();
            fmrBorrarProducto.Show();
        }
    }
}
