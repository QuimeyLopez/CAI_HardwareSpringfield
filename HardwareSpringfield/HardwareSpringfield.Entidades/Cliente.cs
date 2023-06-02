using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
    public class Cliente : Persona
    {
        // ATRIBUTOS     
        private int _codigo;

        // PROPIEDADES      
        public int Codigo { get => _codigo; set => _codigo = value; }

        // CONSTRUCTOR
        public Cliente(string nombre, string apellido, string email, DateTime fechaNacimiento, int codigo) : base(nombre, apellido, email, fechaNacimiento)
        {
            Codigo = codigo;
        }

    }
}
