using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación___Promedio_1___Examen_Individual
{
    class ProductoTela
    {
        protected string nombre;
        protected string tamaño;
        protected Material material;
        protected string color;
        protected double precio;

        public ProductoTela(string nombre, string tamaño, Material material, string color, double precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.material = material;
            this.color = color;
            this.precio = precio;
        }

        public string getCaracteristicas()
        {
            return $"Nombre: {nombre}, Tamaño: {tamaño}, Material: {material.getNombre()}, Color: {color}";
        }

        public double getPrecio()
        {
            return precio;
        }
    }

}
