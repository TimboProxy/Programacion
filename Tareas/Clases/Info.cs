using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Clases
{
    internal class Info
    {
        private string _info;

        public Info(string info)
        {
            this._info = info;
        }
        public string info
        {
            get { return _info; }
            set { _info = value; }
        }

        public override string ToString()
        {
            return $"Informacion: {_info}";
        }

    }
}
