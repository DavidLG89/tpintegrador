namespace ClubDeportivo.Entities
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }

        // Constructor
        public Actividad(string nombre, string descripcion, DateTime fechaHora)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaHora = fechaHora;
        }

        public override string ToString()
        {
            return $"{Nombre} - Scheduled: {FechaHora}";
        }
    }
}