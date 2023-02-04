using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Estudiante
    {
        static string[] nombre = new string[3]; //variable global
        static float[] notas = new float[3]; //variable global
        static byte indice = 0; //variable global para la posicion del arreglo
        static byte indiceNota = 0;
        public static void menu()

        {
            
           

            byte opcion = 0;

            do
            {
                Console.WriteLine("1- Agregar Estudiantes: ");
                Console.WriteLine("2- Buscar Estudiante: ");
                Console.WriteLine("3- Asignar nota al estudiante");              
                Console.WriteLine("4- Imprimir Estudiantes");              
                Console.WriteLine("5- Modificar Estudiantes");
                Console.WriteLine("6- Salir"); 
                Console.WriteLine("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        CrearEstudiantes();
                        break;
                    case 2:
                        BuscarEstudiantes();
                        break;
                    case 3:
                        NotaEstudiante();
                        break;                       
                    case 4:
                        Imprimir();
                        break;
                    case 5:
                        Modificar();
                        break;                   
                    case 6:
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;

                }

            } while (opcion != 6); 


        }
        private static void CrearEstudiantes() 
        {
            string continuar = "s";

            do
            {
                Console.WriteLine("Digite el nombre del estudiante ({0})", (indice + 1)); 
                nombre[indice] = Console.ReadLine();
                indice++;
                Console.WriteLine("Desea continuar(s/n): ");
                continuar = Console.ReadLine();
            } while (!continuar.Equals("n")); 
            {
            }
            
        }
        private static void BuscarEstudiantes()
        {
            Console.WriteLine("Digite el nombre: ");
            string nombre = Console.ReadLine();
            bool existe = false;
            
                for (int i = 0; i < Estudiante.nombre.Length; i++)
                {
                    if (nombre.Equals(Estudiante.nombre[i]))
                    {
                        Console.WriteLine("Estudiante Existe en la posicion " + i);             
                        existe = true;
                        break;
                    }
                }
                if (existe == false)
                { 
                    Console.WriteLine("Estudiante No Existe");
                }

        }
        private static void NotaEstudiante()
        {
            
            
            bool existe = false;
            string continuar = "s";

            do
            { 
                
                Console.WriteLine("Digite el nombre del estudiante: ");
                string nombre = Console.ReadLine();
                indice++;
                for (int i = 0; i < Estudiante.nombre.Length; i++)
                {
                    if (nombre.Equals(Estudiante.nombre[i]))
                    {
                        Console.WriteLine("Digite la nota del estudiante: ({0})", (indiceNota + 1));
                        notas[indiceNota] = float.Parse(Console.ReadLine());
                        indiceNota++;
                        existe= true;
                        break;
                    }                                          
                }
                if (existe == false)
                    {
                        Console.WriteLine("Estudiante no existe");
                    }

             Console.WriteLine("Desea continuar con el siguiente estudiante? (s/n): ");
             continuar = Console.ReadLine();
            } while (!continuar.Equals("n"));
            
            
        }
        private static void Imprimir()
        {

            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                Console.WriteLine($" Nombre del estudiante: {nombre[i]} Nota: {notas[i]} ");
            }
        }

        private static void Modificar()
        {
            Console.WriteLine("Digite el nombre: ");
            string nombre = Console.ReadLine();
            bool existe = false;
            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Digite el nuevo nombre: ");
                    string nombreEstudiante = Console.ReadLine();
                    Estudiante.nombre[i] = nombreEstudiante;

                    existe = true;
                    break;
                }
            }
            if (existe == false)
            {
                Console.WriteLine("Estudiante No Existe");
            }

        }



    }
}
