using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();

            //l'alumnos
            alumnos.Add(new Alumno());
            alumnos[0].Nombre = "Jose Jose";
            alumnos[0].Matricula="123654";
            alumnos[1].Nombre="Mariano Marrano";
            alumnos[2].Nombre = "Chabelo Televisa";
            alumnos[2].Matricula = "859746";
            alumnos[3].Nombre = "Maicol Torres";
            alumnos[4].Matricula = "987586";

            //Materias alumno
            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            alumnos[0].Materias[1].Add(new Materia());
            alumno.Materias.Add(matematicas);
            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "HT96465";
            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "E5S45D";
            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.Clear();
            //Materias alumno2

            Console.WriteLine("Alumno: " + alumno.Nombre);
            Console.WriteLine("Número de materias: " + alumno.Materias.Count);
            foreach (Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
                //alumno.Materias[1].Nombre;
            }

            Console.ReadLine();
        }
    }
}
