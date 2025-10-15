using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo.Entities
{
    public class Cliente: Person
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now.Date;
        public bool IsActive { get; set; }

        // Constructor
        public Cliente(string name, string surname, string dni, string address, string phone, string email, DateTime registrationDate, bool isActive)
            : base(name, surname, dni, address, phone, email)
        {
            RegistrationDate = registrationDate;
            IsActive = isActive;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} (DNI: {Dni}) - Activo: {IsActive}";
        }
    }
}
