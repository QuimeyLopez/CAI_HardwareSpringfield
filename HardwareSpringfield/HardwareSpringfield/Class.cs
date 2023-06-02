using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield
{
    public class Persona
    {
        // ATRIBUTOS     
        private string _nombre;
        private string _apellido;    
        private string _email;
        private DateTime _fechaNacimient;
        

        // PROPIEDADES      
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
       

        // CONSTRUCTOR
        public Persona (string nombre, string apellido, string email, DateTime fechaNacimiento)
        {       
            Nombre = nombre;
            Apellido = apellido;
            Email = email;        
            FechaNacimiento = fechaNacimiento;
        }      
    }

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

    public class Venta
    {
        // ATRIBUTOS     
        private int _codigo;
        private DateTime _fechaDeVenta;
        private int _monto;
        private List<Producto> _productos;
        //CLIENTE

        // PROPIEDADES      
        public int Codigo { get => _codigo; set => _codigo = value; }
        public DateTime FechaDeVenta { get => _fechaDeVenta; set => _fechaDeVenta = value; }
        public int Monto { get => _monto; set => _monto = value; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }

        // CONSTRUCTOR
        public Venta(int codigo, DateTime fechaDeVenta, int monto) 
        {
            Codigo = codigo;
            FechaDeVenta = fechaDeVenta;
            Monto = monto;    
            Productos = new List<Producto>();
        }

    }

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



    public class Producto
    {
        // ATRIBUTOS     
        private int _codigo;
        private string _descripcion;
        private int _stock;
        private double _precio;
       

        // PROPIEDADES      
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public double Precio { get => _precio; set => _precio = value; }

        // CONSTRUCTOR
        public Producto(int codigo, string descripcion, int stock, double precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Stock = stock;
            Precio = precio;    
        }

    }


}