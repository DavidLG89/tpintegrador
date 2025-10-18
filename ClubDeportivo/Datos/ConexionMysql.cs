using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class ConexionMysql
    {
        private MySqlConnection conexion;
        private readonly string cadenaConexion;

        // Constructor: ajusta los valores según tu base de datos
        public ConexionMysql()
        {
            cadenaConexion = "Server=localhost;Database=club_deportivo;User ID=root;Password=elge-846;SslMode=none;";
            conexion = new MySqlConnection(cadenaConexion);
        }

        // Método para abrir la conexión
        public MySqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        // Método para obtener la conexión actual
        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
