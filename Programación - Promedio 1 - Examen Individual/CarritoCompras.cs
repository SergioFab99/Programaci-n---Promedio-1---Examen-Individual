using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación___Promedio_1___Examen_Individual
{
    class CarritoCompras
    {
        internal List<object> listaProductos;

        public CarritoCompras()
        {
            listaProductos = new List<object>();
        }

        public void agregarProducto(object producto)
        {
            listaProductos.Add(producto);
        }

        public double calcularPrecioTotal()
        {
            double total = 0;
            foreach (object producto in listaProductos)
            {
                if (producto is ProductoTela)
                {
                    total += ((ProductoTela)producto).getPrecio();
                }
                else if (producto is ProductoArcilla)
                {
                    total += ((ProductoArcilla)producto).getPrecio();
                }
            }
            return total;
        }
    }

}
