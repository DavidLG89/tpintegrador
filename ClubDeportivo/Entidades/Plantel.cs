using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class Plantel
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
            
        // Constructor
        public Plantel(long id, string nombre, string email, string contrasenia)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Contrasenia = contrasenia;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Email}";
        }

    }
}
