using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Materia
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }

        public Materia()
        {
            Nombre = "Materia nueva";
            Identificador = "0";
        }
        public Materia(string nombre, string identificador)
        {
            Nombre = nombre;
            Identificador = identificador;
        }
    }
}
