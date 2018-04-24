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
    public partial class COSMETICS : Form
    {
        public COSMETICS()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chocolate_TextChanged(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {

            MySqlConnection conectar = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=minisise;");
            conectar.Open();
            MySqlCommand logg = new MySqlCommand();
            MySqlConnection conecta = new MySqlConnection();
            logg.Connection = conectar;
            logg.CommandText = ("insert into repair values('" + chocolate.Text + "','" + top_cover.Text + "','" + botton_cover.Text + "','" + mayla.Text + "','" + agency_label.Text + "')");
            MySqlDataReader leer = logg.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Data incorrect");


            }
            else
            {
                MessageBox.Show("Saved Record");
                chocolate.Text = " ";
                top_cover.Text = " ";
                botton_cover.Text = " ";
                mayla.Text = " ";
                agency_label.Text = " ";

            }
            conectar.Close();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=minisise;");
            conectar.Open();
            MySqlCommand logg = new MySqlCommand();
            MySqlConnection conecta = new MySqlConnection();
            logg.Connection = conectar;
            logg.CommandText = ("update cosmetics set sn_chocolate=" + chocolate.Text + ", top_cover='" + top_cover.Text + "', botton_cover='" + botton_cover.Text + "', mayla='" + mayla.Text + "', agency='" + agency_label.Text +  "'where sn_chocolate=" + chocolate.Text);
            MySqlDataReader leer = logg.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Error en los Datos favor de Revisarlo");
            }
            else
            {
                MessageBox.Show("Registro Agregado!");
                chocolate.Text = " ";
                top_cover.Text = " ";
                botton_cover.Text = " ";
                mayla.Text = " ";
                agency_label.Text = " ";
               
            }
            conectar.Close();

        }
    }
}
