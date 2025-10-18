using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class ClienteDao
    {
        private readonly ConexionMysql conexion;

        public ClienteDao()
        {
            conexion = new ConexionMysql();
        }

        // Crear un nuevo cliente
        public bool Crear(Cliente cliente)
        {
            string query = @"INSERT INTO cliente 
                            (nombre, apellido, dni, direccion, telefono, correoElectronico, fechaRegistro, esApto, estaActivo)
                             VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @correoElectronico, @fechaRegistro, @esApto, @estaActivo)";
            try
            {
                MySqlConnection con = conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@dni", cliente.Dni);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                cmd.Parameters.AddWithValue("@fechaRegistro", cliente.FechaRegistro);
                cmd.Parameters.AddWithValue("@esApto", cliente.EsApto);
                cmd.Parameters.AddWithValue("@estaActivo", cliente.EstaActivo);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear cliente: " + ex.Message);
                MessageBox.Show("No se pudo crear el cliente: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Editar cliente existente
        public bool Editar(Cliente cliente)
        {
            string query = @"UPDATE cliente SET 
                                nombre = @nombre,
                                apellido = @apellido,
                                dni = @dni,
                                direccion = @direccion,
                                telefono = @telefono,
                                correoElectronico = @correoElectronico,
                                esApto = @esApto,
                                estaActivo = @estaActivo
                             WHERE id = @id";

            try
            {
                MySqlConnection con = conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@dni", cliente.Dni);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                cmd.Parameters.AddWithValue("@esApto", cliente.EsApto);
                cmd.Parameters.AddWithValue("@estaActivo", cliente.EstaActivo);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar cliente: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Buscar cliente por DNI
        public bool BuscarPorDni(string dni)
        {
            string query = "SELECT * FROM cliente WHERE dni = @dni";
            bool encontrado = false;

            try
            {
                MySqlConnection con = conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dni", dni);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    encontrado = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar cliente: " + ex.Message);
                MessageBox.Show("No se pudo buscar el cliente: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return encontrado;
        }

        // Obtener todos los clientes
        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            string query = "SELECT * FROM cliente ORDER BY nombre, apellido";

            try
            {
                MySqlConnection con = conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente c = new Cliente(
                        reader.GetInt64("id"),
                        reader.GetString("nombre"),
                        reader.GetString("apellido"),
                        reader.GetString("dni"),
                        reader.GetString("direccion"),
                        reader.GetString("telefono"),
                        reader.GetString("correoElectronico"),
                        reader.GetDateTime("fechaRegistro"),
                        reader.GetBoolean("esApto"),
                        reader.GetBoolean("estaActivo")
                    );
                    lista.Add(c);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener clientes: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return lista;
        }

        // Eliminar cliente (por id)
        public bool Eliminar(long id)
        {
            string query = "DELETE FROM cliente WHERE id = @id";

            try
            {
                MySqlConnection con = conexion.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar cliente: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
