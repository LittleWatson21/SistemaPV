using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPV
{
    class Producto
    {
       public string Nombre { get; set; }
       public int Cantidad { get; set; }
       public float Costo { get; set;}
       public float Importe { get { return Cantidad * Costo; } }

        public Producto (string _Nombre, int _Cantidad, float _Costo)
        {
            Nombre = _Nombre;
            Cantidad = _Cantidad;
            Costo = _Costo;
        }

        public override string ToString()
        {
            return   Nombre + "  " + Cantidad + "   "+ Importe; 
        }


    }
}
