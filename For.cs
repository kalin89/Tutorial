using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public static class For
    {
        public static void CiclyFor()
        {
            // 1+2+3+4+5+6+7+8+9+10
            int suma = 0;
            for(var i = 0; i <= 10; i+=5)
            {
                //Quiero la suma de los numero pares de 1 al 20
                //lo mismo pero de los impares 15 al 30;
                //La suma de los numero primos!!!! 
                suma+= i;
            }

            Console.WriteLine($"La suma es {suma}");
        }

        public static void CiclyWhile() 
        {
            //i = 8;
            for(int i = 0; i <= 10;i++)
            {
                if(i <= 1)
                {
                    //no hacer nada;
                }

                for(int y = 2; y < i; y++)
                {
                    if(i % y == 0)
                    {
                        // == 
                        //no sería primero
                        //Si no entro aquí nunca
                        //Es primo
                    }
                }


                // 8, sea divido entre 1,2,3,4,5,6,7,8,9
                //0,1 descartado
                // Test
                //2 /1 reciduo es 0
                //2/2 reciduo es 0

                //Test
                // 3/1 = 0
                // 3/2 = hay reciduo
                // 3/3 = 0

                //test 4


            }
        }
    }
}
