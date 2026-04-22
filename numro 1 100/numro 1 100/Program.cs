using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numro_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, numerobimbas;

            for (numerobimbas = 1; numerobimbas <= 100; numerobimbas++) 
            {
                soma =+ numerobimbas;
            }
            Console.WriteLine("O resultado de todos os numeros de 1 a 100 somados é " + soma);


        }
    }
}
