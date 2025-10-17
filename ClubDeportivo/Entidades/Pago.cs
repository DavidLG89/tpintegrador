using ClubDeportivo.Entidades;

namespace ClubDeportivo.Entities
{
    public class Pago
    {
        public long Id { get; set; }
        public string Concepto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public MetodoDePago MetodoDePago { get; set; }
        public Cuota Cuota { get; set; }
        public Actividad Actividad { get; set; }
        public Cliente Cliente { get; set; }
        // Constructor con parámetros
        public Pago(long id, string concepto, DateTime fecha, decimal monto, MetodoDePago metodoDePago,
            Cuota cuota, Actividad actividad, Cliente cliente)
        {
            Id = id;
            Concepto = concepto;
            Fecha = fecha;
            Monto = monto;
            MetodoDePago = metodoDePago;
            Cuota = cuota;
            Actividad = actividad;
            Cliente = cliente;
        }

        // Representación de texto
        public override string ToString()
        {
            string clienteNombre = Cliente != null ? $"{Cliente.Nombre} {Cliente.Apellido}" : "Sin cliente";
            string actividadNombre = Actividad != null ? Actividad.Nombre : "Sin actividad";
            return $"Pago #{Id} - {Concepto} - {Fecha.ToShortDateString()} - Monto: ${Monto:F2} " +
                $"- Metodo de pago: {MetodoDePago} - Cliente: {clienteNombre} - Actividad: {actividadNombre}";
        }
    }
}