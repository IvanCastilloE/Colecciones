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
            Alumno alumno1 = new Alumno();

            alumno1.Nombre = "Jose Jose";
            alumno1.Materias.Add(new Materia("Historia", "HST8594"));
            alumno1.Materias.Add(new Materia("Matematicas", "MAT8594"));
            alumno1.Materias.Add(new Materia("Civismo", "CIV8594"));
            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Mariano Marrano";
            alumno2.Materias.Add(new Materia("Sonora", "HST8594"));
            alumno2.Materias.Add(new Materia("Matematicas", "MAT8594"));
            alumno2.Materias.Add(new Materia("Civismo", "CIV8594"));
            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Chabelo Televisa";
            alumno3.Materias.Add(new Materia("Programacion", "HST8594"));
            alumno3.Materias.Add(new Materia("Matematicas", "MAT8594"));
            alumno3.Materias.Add(new Materia("Fisica", "CIV8594"));
            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Maicol Torres";
            alumno4.Materias.Add(new Materia("Español", "HST8594"));
            alumno4.Materias.Add(new Materia("Matematicas", "MAT8594"));
            alumno4.Materias.Add(new Materia("Materia ULSA", "CIV8594"));

            alumnos.Add(alumno1);
            alumnos.Add(alumno3);
            alumnos.Add(alumno2);
            alumnos.Add(alumno4);


            foreach(Alumno elemento in alumnos)
            {
                Console.WriteLine("Alumno: " + elemento.Nombre);
                Console.WriteLine("Número de materias: " + elemento.Materias.Count);
                foreach (Materia materia in elemento.Materias)
                {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }
            }
            
            /* 
            //l'alumnos
            alumnos.Add(new Alumno());
            alumnos[0].Nombre = "Jose Jose";
            alumnos[0].Matricula="123654";
            alumnos[1].Nombre="Mariano Marrano";
            alumnos[1].Matricula = "985674";
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
            */
            Console.ReadLine();
        }
    }
}
