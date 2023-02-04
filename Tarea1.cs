using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea1
{
    internal class Tarea1
    {
        static void Main(string[] args)
        {
            int[] edad = new int[] { 20, 22, 33 };
            float[] Salarios = new float[] { 200, 300, 150 };
            String[] musico = new string[3];
            musico[0] = "Ringo";
            musico[1] = "Paul";
            musico[2] = "John";
            
            Console.WriteLine(musico.Length);
            for (int i = 0; i < musico.Length; i++)
            {
                float IVA = 0;
                IVA = Salarios[i] * 0.13f;
                Console.WriteLine($" Nombre:{musico[i]} Edad: {edad[i]} Salario: {Salarios[i]} IVA:{IVA} + Total: {Salarios[i] + IVA} "); //Duré 2 horas asimilando que el Console.ReadLine() iba afuera del for, pero se logró
                        

            }
             Console.ReadLine();
        }
    }
}