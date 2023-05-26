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
    public partial class fmrRegistro : Form
    {

        string UsuarioRegistro, ContrasenaRegistro, NombreRegistro, ApellidoRegistro, EdadRegistro, TelefonoRegistro, CorreoRegistro;


        public fmrRegistro()
        {
            InitializeComponent();
        }

        //Metodo que limpia todos los campos y cierra el formulario.
        public void limpiartxt() 
        {
            UsuarioRegistro = string.Empty;
            ContrasenaRegistro = string.Empty;
            NombreRegistro = string.Empty;
            ApellidoRegistro = string.Empty;
            EdadRegistro = string.Empty;
            TelefonoRegistro = string.Empty;
            CorreoRegistro = string.Empty;
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            //Utilizamos estos tres objetos de SQLite
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            //Crear una nueva conexión de la base de datos
            conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version=3;Compress=False;");

            try
            {
                //Abriremos la conexión
                conexion_sqlite.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La base de datos no se encuentra en la ruta");
            }
            cmd_sqlite = conexion_sqlite.CreateCommand();
            
            UsuarioRegistro = txtUsuario.Text;
            ContrasenaRegistro = txtContrasena.Text;
            NombreRegistro = txtNombre.Text;
            ApellidoRegistro = txtApellido.Text;
            EdadRegistro = txtEdad.Text;
            TelefonoRegistro = txtTelefono.Text;
            CorreoRegistro = txtCorreo.Text;

            try
            {
                //Insertando datos en la tabla
                cmd_sqlite.CommandText = $"INSERT INTO tblRegistros(Usuario, Contraseña, Rol, Nombres, Apellidos, Edad, Telefono, Correo) VALUES ('{UsuarioRegistro}', '{ContrasenaRegistro}','cliente','{NombreRegistro}','{ApellidoRegistro}','{EdadRegistro}','{TelefonoRegistro}','{CorreoRegistro}')";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario Existente.");
            }
            conexion_sqlite.Close();
            limpiartxt();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiartxt();
        }
    }
}
