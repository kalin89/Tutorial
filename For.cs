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
    }
}
