using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace practica_conexion
{
    class coneccion
    {
        MySqlConnection conexion = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password=; database = ruckus;");
        private MySqlCommand cmd;


        public bool Conectar()
        {
            bool conectado = false;

            try
            {
                conexion.Open();
                conectado = true;
            }
            catch (MySqlException)
            {
                conectado = false;
            }
            finally
            {
                conexion.Close();
            }
            return conectado;
        }

        public bool Insertar(string consulta)
        {
            bool agregado = false;
            int rows = 0;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                agregado = true;
            }

            conexion.Close();

            return agregado;
        }
        public bool Actualizar(string consulta)
        {
            bool actualizado = false;
            int rows = 0;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);

            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                actualizado = true;
            }

            conexion.Close();

            return actualizado;
        }
        public bool Eliminar(string consulta)
        {

            bool eliminar = false;
            int rows = 0;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                eliminar = true;
            }

            conexion.Close();

            return eliminar;
        }
    }
}
