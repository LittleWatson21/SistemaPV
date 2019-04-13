using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPV
{
    class Ticket
    {
        //En este caso usaremos un método en el
        // No  necesitamos hacer 
        //Recordar inicializarlo en el constructor del ticket
        //No debemos permitir que el usuario tenga acceso a la 
        //Modificación de la lista de productos.
        private List<Producto> Productos;
        private const int IVA  = 16;
        private float _Pago;
        public float Subtotal { get; }
        public float CostoTotal { get { return Subtotal + Impuesto; } }
        //Value es una propiedad que esta contenida al momento 
        //Que declaramos un setter.
        public float Pago { get { return _Pago; } set
            { if(value >= CostoTotal)
                {
                    _Pago = value;
                }
              else
                {
                    Console.Write("El pago es insuficiente");
                }
              
            }
        }

        public float Impuesto { get { return Subtotal * (IVA / 100); } }
        
        public Ticket()
        {
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
            
        }      
    }
}
