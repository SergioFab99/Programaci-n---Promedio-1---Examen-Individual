using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación___Promedio_1___Examen_Individual
{
    class ProductoArcilla
    {
        protected string nombre;
        protected double peso;
        protected string tamaño;
        protected string color;
        protected double precio;

        public ProductoArcilla(string nombre, double peso, string tamaño, string color, double precio)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.tamaño = tamaño;
            this.color = color;
            this.precio = precio;
        }

        public string getCaracteristicas()
        {
            return $"Nombre: {nombre}, Peso: {peso}, Tamaño: {tamaño}, Color: {color}";
        }

        public double getPrecio()
        {
            return precio;
        }
    }

}
