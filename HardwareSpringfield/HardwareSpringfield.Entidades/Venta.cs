using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
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
}
