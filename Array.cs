using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public static class ArrayClass
    {
        public static void BasicArrayUse()
        {
            int[] numeros = new int[2];
            int[] edades = {23,37,34,12 };
            //llenar los espacios
            numeros.Append(0);
            numeros.Append(4);

            //Length para saber el tamaño del arreglo.
            Console.WriteLine($"Tamaño: {edades.Length}");
            int buscar = Array.IndexOf(edades, 12);
            Console.WriteLine($"La posición de 37 es {buscar}");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine($"{i+1} edad {edades[i]}");
            }

            Console.WriteLine("--------------------------");
            string[] names = { "Carlos", "Jorge", "Adry", "Citlalli" };
            //int[] edades = { 23, 37, 34, 12 };

            for(int i= 0 ; i < names.Length; i++)
            {
                Console.WriteLine($"La edad de {names[i]} es {edades[i]}");
            }

            //Ejercicio encuentra el numero mayor
            int[] numero2 = { -4, -1, -8, -6 };

            int mayor = 0; //Clave esta aquí
            for(int i= 0 ;i < numero2.Length; i++)
            {
                if (numero2[i] > mayor)
                {
                    mayor = numero2[i];
                }
            }

            Console.WriteLine("El Mayor es {0}", mayor);
        }
    }
}
