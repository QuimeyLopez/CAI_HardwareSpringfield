using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
    public class Proveedor
    {
        // ATRIBUTOS     
        private int _codigo;
        private string _razonSocial;
        private List<Producto> _productos;
        private string _telefono;
        private string _email;
        private string _direccion;


        // PROPIEDADES      
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        


        // CONSTRUCTOR
        public Proveedor(int codigo, string razonSocial, string telefono, string email, string direccion)
        {
            Codigo = codigo;
            RazonSocial = razonSocial;
            Productos = new List<Producto>();
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        
        }
    }
}
