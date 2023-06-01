using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
    public class Persona
    {
        // ATRIBUTOS     
        private string _nombre;
        private string _apellido;
        private string _email;
        private DateTime _fechaNacimiento;


        // PROPIEDADES      
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }


        // CONSTRUCTOR
        public Persona(string nombre, string apellido, string email, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
