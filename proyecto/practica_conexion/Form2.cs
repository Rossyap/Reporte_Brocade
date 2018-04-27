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
using practica_conexion.Resources;

namespace practica_conexion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();

        }

        coneccion fn = new coneccion();

        private void Form1_Load(object sender, EventArgs e)

        {
            bool conectado = fn.Conectar();

            if (conectado)
            {
                MessageBox.Show("Conectado");
            }
            else
            {
                MessageBox.Show("Error de conexion");
            }

        }

        
        private void btnvisualizar_Click_1(object sender, EventArgs e)
        {
            Visualizar();
        }

        public void Visualizar()
        {
            string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password=; database = ruckus;";
            string query = "SELECT * FROM usuarios";


            MySqlConnection databaseConecction = new MySqlConnection(connectionString);

            databaseConecction.Open();

            DataTable usua = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(query, databaseConecction);
            mdaDatos.Fill(usua);
            dataGridView1.DataSource = usua;
            DataTable cuid = new DataTable();

            databaseConecction.Close();

        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            string agregar = "insert into usuarios values ('" + usuario.Text + "', '" + password.Text + "', '" + tipo.Text + "' , '" + nombre.Text + "')";

            if (fn.Insertar(agregar))
            {
                MessageBox.Show("Agregado");
                Visualizar();
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string actualizar = "update usuarios set no_reloj =  '" + usuario.Text + "', password = '" + password.Text + "', tipo = '" + tipo.Text + "' where nombre = '" + nombre.Text + "'";


            if (fn.Actualizar(actualizar))
            {
                MessageBox.Show("Registro actualizado");

                Visualizar();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }

        }

        private void btnregresar_Click_1(object sender, EventArgs e)
        {
            login inicio = new login();
            inicio.Show();
            this.Hide();
        }
    }
}

