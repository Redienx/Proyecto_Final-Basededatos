using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;
using menu;
using Pantalla_Maestra;

namespace Login
{
    /// <summary>
    /// Hecho por Sneider Velasquez Iglesias 
    /// Este codigo es un login conectado a una base de datos
    /// </summary>
    public partial class fmrLogin : Form
    {

        // Variables para almacenar los datos del login
        string Usuario;
        string Contrasena;

        // Contador para llevar registro de intentos fallidos de login
        int contador;
        public fmrLogin()
        {
            InitializeComponent();
        }

        // Método para mostrar el panel de registro al hacer clic en el botón "Registrar"
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            fmrRegistro fmrRegistro = new fmrRegistro();
            fmrRegistro.Show();
        }
        // Método para validar el usuario y contraseña al hacer clic en el botón "Iniciar"
        private void btnIniciar_Click(object sender, EventArgs e)
        {

            //Utilizamos estos tres objetos de SQLite
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteDataReader datareader_sqlite;

            //Crear una nueva conexión de la base de datos
            conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version=3;Compress=True;");
            try
            {
                //Abriremos la conexión
                conexion_sqlite.Open();
            }catch (Exception ex) { MessageBox.Show("La base da datos no se encuentra en la ruta."); }
            
            cmd_sqlite = conexion_sqlite.CreateCommand();

            Usuario = txtUsuario.Text;
            Contrasena = txtContrasena.Text;

            cmd_sqlite.CommandText = $"SELECT Usuario, Contraseña FROM tblRegistros WHERE Usuario = '{Usuario}' AND Contraseña = '{Contrasena}'";
            datareader_sqlite = cmd_sqlite.ExecuteReader();

            // Si el usuario y contraseña coinciden con los registrados, muestra el formulario de bienvenida
            if (datareader_sqlite.Read())
            {
                fmrMenu fmrMenu = new fmrMenu();
                fmrMenu.Show();
                contador = 0;
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                conexion_sqlite.Close();
            }
            else
            {
                contador++;
                // Si hay menos de 3 intentos fallidos, muestra un mensaje de error
                if (contador < 3)
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto. Vuelva a intentar");
                }
                // Si hay 3 o más intentos fallidos, muestra un mensaje de error y cierra el formulario de login
                else
                {
                    MessageBox.Show("Muchos intentos erroneos. Bloqueado");
                    conexion_sqlite.Close();
                    this.Close();
                }
            }
        }
    }
}