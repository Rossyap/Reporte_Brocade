using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace practica_conexion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MySqlConnection coneccion = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password=; database = ruckus");
            coneccion.Open();

            MySqlCommand id = new MySqlCommand();
            MySqlConnection conectar = new MySqlConnection();
            id.Connection = coneccion;

<<<<<<< HEAD
            id.CommandText = ("select * from usuarios where  no_reloj = '" + textBox1.Text + "' and password = '" + textBox2.Text + "' ");

            MySqlDataReader leer = id.ExecuteReader();

            if (leer.Read())
            {
                
                
                    MessageBox.Show("Bienvenido");
                    RUCKUS llamar = new RUCKUS();
                    llamar.Show();
                    this.Hide();
                                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                coneccion.Close();
            }


            coneccion.Close();
=======
            id.CommandText = ("select * from usuarios where  no_reloj = '" + user.Text + "' and password = '" + password.Text + "' ");

            MySqlDataReader leer = id.ExecuteReader();
>>>>>>> 6630794f459b478f38789656cfcb1e6ec44dedf4

            if (leer.Read())
            {
                RUCKUS llamar = new RUCKUS();
                llamar.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("incorrect data, please check!");
                coneccion.Close();
            }


            coneccion.Close();
        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
    }
}
