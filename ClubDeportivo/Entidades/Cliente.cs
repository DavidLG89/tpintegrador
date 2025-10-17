using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now.Date;
        public bool EstaActivo { get; set; }

        // Constructor
        public Cliente(string nombre, string apellido, string dni, string direccion, string telefono,
            string correoElectronico, DateTime fechaRegistro, bool estaActivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            FechaRegistro = fechaRegistro;
            EstaActivo = estaActivo;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - DNI: {Dni} - Activo: {EstaActivo}";
        }
    }
}
