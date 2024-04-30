using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new String[5];
            double[] peso = new double[5];
            double[] altura = new double[5];

        for (int i = 0; i <= 4; i++)
            {
                Console.Write("Digite seu nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Informe o seu peso: ");
                peso[i] = double.Parse(Console.ReadLine());

                Console.Write("Informe a sua altura: ");
                altura[i] = double.Parse(Console.ReadLine());

                if (peso[i] > 18.5) 
            }
        }
    }
}
