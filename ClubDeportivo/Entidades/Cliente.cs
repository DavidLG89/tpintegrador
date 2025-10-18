using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo.Entidades
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now.Date;
        public bool EsApto { get; set; }
        public bool EstaActivo { get; set; } = true;

        // Constructor
        public Cliente(long id, string nombre, string apellido, string dni, string direccion, string telefono,
            string correoElectronico, DateTime fechaRegistro,bool esApto)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            FechaRegistro = fechaRegistro;
            EsApto = esApto;
        }
        // Constructor con todos los atributos
        public Cliente(long id, string nombre, string apellido, string dni, string direccion, string telefono,
            string correoElectronico, DateTime fechaRegistro, bool esApto, bool estaActivo)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            FechaRegistro = fechaRegistro;
            EsApto = esApto;
            EstaActivo = estaActivo;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - DNI: {Dni} - Activo: {EstaActivo}";
        }
    }
}
