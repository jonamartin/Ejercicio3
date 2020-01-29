using System;
using System.Collections.Generic;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Ingrese la cantidad de valores a mostrar");
            m = Convert.ToInt32(Console.ReadLine());
            List<int> multiplos = new List<int>();

            for(int i = 1; i<= m ; i++)

            {
                multiplos.Add(3*i);
            }

            for(int v = 1; v<= m ; v++)
            {
                multiplos.Remove(5*v);
            }
            foreach(var multiplo in multiplos)
            {
                Console.WriteLine(multiplo + " ");
                Console.WriteLine("");
            }
        }
    }
}
