using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación___Promedio_1___Examen_Individual
{
    class Material
    {
        protected string nombre;

        public Material(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }
    }

}
