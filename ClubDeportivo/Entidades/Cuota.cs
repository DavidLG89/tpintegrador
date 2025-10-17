using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entities
{
    public class Cuota
    {
        public long Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool EstaPago { get; set; }
        public Cliente Cliente { get; set; }

        // Constructor
        public Cuota(decimal monto, DateTime fechaVencimiento, Cliente cliente)
        {
            Monto = monto;
            FechaVencimiento = fechaVencimiento;
            Cliente = cliente;
            EstaPago = false;
        }

        public override string ToString()
        {
            return $"Cuota: {Monto:C} - Vencimiento: {FechaVencimiento.ToShortDateString()} - Pago: {EstaPago}";
        }

        // Método de utilidad: marcar cuota como pagada
        public void MarcarComoPago()
        {
            EstaPago = true;
        }

        // Método de utilidad: verificar si la cuota está vencida
        public bool EstaVencida()
        {
            return !EstaPago && FechaVencimiento.Date < DateTime.Now.Date;
        }
    }
}
