using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entities
{
    public class Carnet
    {
        public int Id { get; set; }
        public string NumeroCarnet { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now.Date;
        public DateTime FechaExpiracion { get; set; }
        public Cliente Cliente { get; set; }
        public RolCliente RolCliente { get; set; }

        // Constructor
        public Carnet(string numeroCarnet, DateTime fechaCreacion, DateTime fechaExpiracion, Cliente cliente, RolCliente rolCliente)
        {
            NumeroCarnet = numeroCarnet;
            FechaCreacion = fechaCreacion;
            FechaExpiracion = fechaExpiracion;
            Cliente = cliente;
            RolCliente = rolCliente;
        }

        public override string ToString()
        {
            return $"Client name: {Cliente.Nombre} - Card {NumeroCarnet} - Issued: {FechaCreacion.ToShortDateString()} - Expires: {FechaExpiracion.ToShortDateString()} - ClientRole: {RolCliente.Nombre}";
        }

        // Método de utilidad: verificar si la tarjeta está vigente
        public bool EsValido()
        {
            var hoy = DateTime.Now.Date;
            return hoy >= FechaCreacion.Date && hoy <= FechaExpiracion.Date;
        }
    }
}
