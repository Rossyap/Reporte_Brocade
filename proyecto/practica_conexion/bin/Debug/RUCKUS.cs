using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Runtime.InteropServices;

namespace practica_conexion
{
    public partial class RUCKUS : Form
    {
        public RUCKUS()
        {
            InitializeComponent();
        }
       

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
           restaurar.Visible = true;
           
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            maximizar.Visible = true;
            restaurar.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TITULO_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormHijo(object formhijo)
        {
            if (this.mostrar.Controls.Count > 0)
                this.mostrar.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mostrar.Controls.Add(fh);
            this.mostrar.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new RUCKUS_1());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(new COSMETICS());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(new INSPECTION());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(new SEARCH());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Inicio());
        }

        private void mostrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TITULO_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void MENU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Usuarios());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }
    }
}
