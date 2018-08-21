using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }

        public List<Materia> Materias { get; set; }

        public Alumno()
        {
            Materias = new List<Materia>();
        }
    }
}
