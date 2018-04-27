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
    public partial class INSPECTION : Form
    {
        public INSPECTION()
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
           

        }

       
        private void SAVE_Click(object sender, EventArgs e)
        {
            string agregar = "insert into inspection values ('" + choco.Text + "', '" + snvai.Text + "', '" + sku.Text + "' , '" + mac.Text + "', '"+country.Text+"', '"+rj45.Text+"', '"+sfp.Text+"', '"+cover.Text+"', '"+chasis.Text+"', '"+mayla.Text+"', '"+agency.Text+"', '"+staing.Text+"', '"+fecha.Text+"', '"+inspector.Text+"')";

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

        private void UPDATE_Click(object sender, EventArgs e)
        {
            string actualizar = "update inspection set  SN_Vainilla =  '" + snvai.Text + "', SKU = '" + sku.Text + "', Mac = '" + mac.Text + "', Pais = '"+country.Text+"', RJ45= '"+rj45.Text+"', SFP='"+sfp.Text+"', Cover= '"+cover.Text+"', Chasis='"+chasis.Text+"', Maylar='"+mayla.Text+"', Etiq_Age= '"+agency.Text+"', Stagin_Inicial= '"+staing.Text+"', inspector='"+inspector.Text+"' where SN_Chocolate = '" + choco.Text + "'";


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

        private void btnvisualizar_Click(object sender, EventArgs e)
        {
            Visualizar();
        }

        public void Visualizar()
        {
            string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password=; database = ruckus;";
            string query = "SELECT * FROM inspection";


            MySqlConnection databaseConecction = new MySqlConnection(connectionString);

            databaseConecction.Open();

            DataTable inspec = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(query, databaseConecction);
            mdaDatos.Fill(inspec);
            dataGridView1.DataSource = inspec;
            DataTable cuid = new DataTable();

            databaseConecction.Close();
        }
    }
}
