using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leia_5_número_e_exiba_a_soma_total_deles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1, jonas = 1, ku = 0;

            for (numero = 1; numero <= 5; numero++)
            {
                Console.WriteLine("digite um numero: \n ");
                jonas = int.Parse (Console.ReadLine());
                ku = jonas + ku;
                {
                    Console.WriteLine("a soma dos seus numeros e:"+ ku);
                }

            }
        }
    }
}
