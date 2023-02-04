using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static string[] nombre = new string[3]; //variable global
        static float[] notas = new float[3]; //variable global
        static byte indice = 0; //variable global para la posicion del arreglo
        static void Main(string[] args)
        {

                                                       
            Estudiante.menu();

          
            Console.Read();


        }
    }
}
