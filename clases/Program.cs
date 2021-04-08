using System;

namespace clases
{
    class Program
    {
        static void Main(string[] args)
        {
            clase[] listaestudiantes = new clase[2];
             int aux = 0;

             while(aux < 2){

                 Console.WriteLine("Ingresa nombre: ");
                 String nombre = Console.ReadLine();
                 Console.WriteLine("Ingreda la edad: ");
                 int edad = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Ingresa el carnet: ");
                 String carnet = Console.ReadLine();
                 Console.WriteLine("Indique si está solvente: ");
                 Boolean solvente = Convert.ToBoolean(Console.ReadLine());
                 Console.WriteLine("Ingrese el curso: ");
                 String curso = Console.ReadLine();
                 Console.WriteLine("Ingrese la nota 1: ");
                 int nota1 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Ingrese la nota 2: ");
                 int nota2 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Ingrese la nota final: ");
                 int notaf = Convert.ToInt32(Console.ReadLine());

                 clase Clase = new clase(nombre, edad, carnet, solvente, curso, nota1, nota2, notaf);

                 listaestudiantes[aux] = Clase;

                 aux+=1;

             }

             Console.WriteLine("*******LISTA******");

             for (int i = 0; i < 2; i++)
             {
                 clase Clase = listaestudiantes[i];

                 Console.WriteLine("Nombre: "+Clase.nombre+" Edad: "+Clase.edad+" Carnet: "+Clase.carnet+" Solvente: "+Clase.solvente+" Curso: "+Clase.curso+" Nota Parcial 1: "+Clase.nota1+" Nota Parcial 2: "+Clase.nota2+" Nota final: "+Clase.notaf);
             }
             Console.ReadKey();
        }
    }
}
