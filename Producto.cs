using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPV
{
    class Producto
    {
        private int _cantidad;
        private float _costo, _total, _iva;
        private string _nombre;
        
        public void introducirNombre(string nombre)
        {
            _nombre = nombre;
        }

        public void  introducirCantidad(int cantidad)
        {
            _cantidad = cantidad;
        }

        public void introducirCosto(int costo)
        {
            _costo = costo;
        }

    }
}
