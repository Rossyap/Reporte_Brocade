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
    public partial class RUCKUS_1 : Form
    {
        public RUCKUS_1()
        {
            InitializeComponent();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RUCKUS_1_Load(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=minisise;");
            conectar.Open();
            MySqlCommand logg = new MySqlCommand();
            MySqlConnection conecta = new MySqlConnection();
            logg.Connection = conectar;
            logg.CommandText = ("insert into repair values('" + FALLA.Text + "','" + CAUSE.Text + "','" + ACTION.Text + "','" + LOCATION.Text + "','" + PART_NUMBER.Text + "','" + quantity.Text + "','" + TECH.Text + "','" + VAINILLA.Text + "','" + serial_number.Text + "')");
            MySqlDataReader leer = logg.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Data incorrect");


            }
            else
            {
                MessageBox.Show("Saved Record");
                serial_number.Text = " ";
                VAINILLA.Text = " ";
                FALLA.Text = " ";
                CAUSE.Text = " ";
                ACTION.Text = " ";
                LOCATION.Text = " ";
                PART_NUMBER.Text = " ";
                quantity.Text = " ";
                TECH.Text = " ";
              
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
            logg.CommandText = ("update repair set SN_Chocolate=" + serial_number.Text + ", SN_Vainilla='" + VAINILLA.Text + "', fail='" + FALLA.Text + "', Root_cause='" + CAUSE.Text + "', Repair_Action='" + ACTION.Text + "', Reference='" + LOCATION.Text + "', PartNum='" + PART_NUMBER.Text + "', Qty='" + quantity.Text + "', Tech='" + TECH.Text + "'where SN_Chocolate=" + serial_number.Text);
            MySqlDataReader leer = logg.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Error en los Datos favor de Revisarlo");
            }
            else
            {
                MessageBox.Show("Registro Agregado!");
                serial_number.Text = " ";
                VAINILLA.Text = " ";
                FALLA.Text = " ";
                CAUSE.Text = " ";
                ACTION.Text = " ";
                LOCATION.Text = " ";
                PART_NUMBER.Text = " ";
                quantity.Text = " ";
                TECH.Text = " ";
            }
            conectar.Close();
        }
    }
}
