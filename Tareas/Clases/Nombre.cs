using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Clases
{
    internal class Nombre
    {
        private string _nombre;

        public Nombre(string nombre)
        {
            this._nombre = nombre;
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public override string ToString()
        {
            return $"Nombre: {_nombre}";
        }
    }
}
