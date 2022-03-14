using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Clases
{
    internal class Pelicula
    {
        private string _nombre;
        private string _info;
        private string _genero;


        public Pelicula(string nombre, string info, string genero)
        {
            this._nombre = nombre;
            this._info = info;
            this._genero = genero;
        }

        public string nombre
        {
            get { return _nombre; } 
            set { _nombre = value; }    
        }

        public string info
        {
            get { return _info; }
            set { _info = value; }
        }

        public string genero
        { 
            get { return _genero; }
            set { _genero = value; }
        }

        



    }
}
