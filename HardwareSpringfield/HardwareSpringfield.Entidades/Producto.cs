using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
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
