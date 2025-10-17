using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entities
{
    public class Carnet
    {
        public long Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now.Date;
        public DateTime FechaExpiracion { get; set; }
        public Cliente Cliente { get; set; }
        public RolCliente RolCliente { get; set; }

        // Constructor
        public Carnet(long id, DateTime fechaCreacion, DateTime fechaExpiracion, Cliente cliente, RolCliente rolCliente)
        {
            Id = id;
            FechaCreacion = fechaCreacion;
            FechaExpiracion = fechaExpiracion;
            Cliente = cliente;
            RolCliente = rolCliente;
        }

        public override string ToString()
        {
            return $"Nombre cliente: {Cliente.Nombre} - Carnet nro {Id} - Creado: {FechaCreacion.ToShortDateString()} " +
                $"- Expira: {FechaExpiracion.ToShortDateString()} - Rol: {RolCliente.ToString()}";
        }

        // Método de utilidad: verificar si la tarjeta está vigente
        public bool EsValido()
        {
            var hoy = DateTime.Now.Date;
            return hoy >= FechaCreacion.Date && hoy <= FechaExpiracion.Date;
        }
    }
}
