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
    /// <summary>
    /// Representa el formulario para actualizar información de clientes en una base de datos SQLite.
    /// </summary>
    public partial class fmrActualizarClientes : Form
    {
        // Variables de clase
        string Usuario, Contrasena, Rol, Nombre, Apellido, Telefono, Correo, Edad;
        int id;
        /// <summary>
        /// Evento que se activa al presionar una tecla en el campo de texto "Edad".
        /// Permite solo la entrada de dígitos en el campo de texto.
        /// </summary>
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Constructor de la clase fmrActualizarClientes.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public fmrActualizarClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Actualizar Clientes".
        /// Actualiza los datos del cliente en la base de datos y cierra el formulario.
        /// </summary>
        /// 
        public void limpiartxt()
        {
            // Limpiar los campos de texto
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            txtRol.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;

            // Cerrar el formulario
            this.Close();
        }
        private void btnActualizarClientes_Click(object sender, EventArgs e)
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

            // Crear el comando de actualización y asignar los valores de los campos de texto
            cmd_sqlite = Conexion_sqlite.CreateCommand();
            try
            {
                id = int.Parse(txtid.Text);
                Usuario = txtUsuario.Text;
                Contrasena = txtContrasena.Text;
                Rol = txtRol.Text;
                Nombre = txtNombre.Text;
                Apellido = txtApellido.Text;
                Edad = txtEdad.Text;
                Telefono = txtTelefono.Text;
                Correo = txtCorreo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los valores no pueden ser nulos. Por favor, llena todos los campos.");
            }

            string RolS = Rol.ToLower();

            // Ejecutar la consulta de actualización en la base de datos
            cmd_sqlite.CommandText = $"UPDATE tblRegistros SET Usuario = '{Usuario}', Contraseña = '{Contrasena}', Rol = '{RolS}', Nombres = '{Nombre}', Apellidos = '{Apellido}', Edad = '{Edad}', Telefono = '{Telefono}', Correo = '{Correo}' WHERE ID = '{id}';";
            cmd_sqlite.ExecuteNonQuery();

            // Cerrar la conexión a la base de datos
            Conexion_sqlite.Close();

            limpiartxt();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Cancelar".
        /// Limpia los campos de texto y cierra el formulario sin guardar los cambios.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiartxt();
        }
    }
}
