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
    public partial class INSPECTION : Form
    {
        public INSPECTION()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=minisise;");
            conectar.Open();
            MySqlCommand logg = new MySqlCommand();
            MySqlConnection conecta = new MySqlConnection();
            logg.Connection = conectar;
            logg.CommandText = ("update repair set sn_chocolate=" + choco.Text + ", sn_vainilla='" + snvai.Text + "', SKU='" + sku.Text + "', MAC='" + mac.Text + "', country='" + country.Text + "', rj45='" + rj45.Text + "', sfp='" + sfp.Text + "', cover='" + cover.Text + "', chasis='" + chasis.Text + "', mayla='" + mayla.Text + "', agency='" + agency.Text + "', staing='" + staing.Text + "', inspector='" + inspector.Text + "'where sn_chocolate=" + choco.Text);
            MySqlDataReader leer = logg.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Error en los Datos favor de Revisarlo");
            }
            else
            {
                MessageBox.Show("Registro Agregado!");
                choco.Text = " ";
                snvai.Text = " ";
                sku.Text = " ";
                mac.Text = " ";
                country.Text = " ";
                rj45.Text = " ";
                sfp.Text = " ";
                cover.Text = " ";
                chasis.Text = " ";
                mayla.Text = " ";
                agency.Text = " ";
                staing.Text = " ";
                inspector.Text = " ";
            }
            conectar.Close();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {

            MySqlConnection conectar = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=minisise;");
            conectar.Open();
            MySqlCommand logg = new MySqlCommand();
            MySqlConnection conecta = new MySqlConnection();
            logg.Connection = conectar;
            logg.CommandText = ("insert into inspection values('" + choco.Text + "','" + snvai.Text + "','" + sku.Text + "','" + mac.Text + "','" + country.Text + "','" + rj45.Text + "','" + sfp.Text + "','" + cover.Text + "','" + chasis.Text + "','" + mayla.Text + "','" + agency.Text + "','" + staing.Text + "','" + inspector.Text + "')");
            MySqlDataReader leer = logg.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Data incorrect");


            }
            else
            {
                MessageBox.Show("Saved Record");
                choco.Text = " ";
                snvai.Text = " ";
                sku.Text = " ";
                mac.Text = " ";
                country.Text = " ";
                rj45.Text = " ";
                sfp.Text = " ";
                cover.Text = " ";
                chasis.Text = " ";
                mayla.Text = " ";
                agency.Text = " ";
                staing.Text = " ";
                inspector.Text = " ";

            }
            conectar.Close();
        }
    }
}
