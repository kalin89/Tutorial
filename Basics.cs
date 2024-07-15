using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public static class Basics
    {
        public static void BasicThings()
        {
            int a = 2;
            var b = 8;
            var text = "Hello";
            string text2 = "Hello again";
            bool abierto = false;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(text);
            Console.WriteLine(abierto);
            Console.WriteLine(text2);


            //Mayor que >
            //Menor que <
            //Mayor igual >=
            //Meno igual <=
            // Igual que ==
            // Igual que != 

            //Operadores Aritmeritocos
            // suma +, resta -, multiplicar *, dividir, % ;

            //Console.WriteLine(4 % 3);

            Console.WriteLine("Inserta un numero:");
            var entrada = Console.ReadLine();

            var numero = int.Parse(entrada!);

            if (numero == 0)
            {
                Console.WriteLine($"el numero es 0");
            }
            else if (numero > 0)
            {
                Console.WriteLine($"el numero {numero} es positivo");
            }
            else
            {
                Console.WriteLine("El numero es Negativo");
            }


            Console.WriteLine("Inserta un numero:");
            var entrada2 = Console.ReadLine();
            var dia = int.Parse(entrada2!);

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                default:
                    Console.WriteLine("Días no validos");
                    break;

            }
        }
    }
}
