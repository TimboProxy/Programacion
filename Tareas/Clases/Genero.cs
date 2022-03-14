using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Clases
{
    internal class Genero
    {
        private string _genero;

        public Genero(string genero)
        {
            this._genero = genero;
        }
        public string genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public override string ToString()
        {
            return $"Genero: {_genero}";
        }
    }
}
