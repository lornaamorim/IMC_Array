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

            int[] peso = new int[5];
            double[] altura = new double[5];
            string[] nome = new string[5];
            int count = 0;


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Digite o nome:");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite o peso:");
                peso[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a altura:");
                altura[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Informe o nome: " + nome[i]);
                Console.WriteLine("Informe a altura: " + altura[i]);
                Console.WriteLine("Informe o peso: " + peso[i]);

                Console.WriteLine("IMC: " + (peso[i] / (altura[i] * altura[i])));

                if ((peso[i] / (altura[i] * altura[i])) <= 18.5)
                {
                    Console.WriteLine("Abaixo do peso ideal"); count--;
                }


                else if ((peso[i] / (altura[i] * altura[i])) <= 24.9)
                {
                    Console.WriteLine("Está no peso ideal"); count--;
                }


                else if ((peso[i] / (altura[i] * altura[i])) <= 29.9)
                {
                    Console.WriteLine("Levemente acima do peso"); count++;
                }


                else if ((peso[i] / (altura[i] * altura[i])) <= 34.9)
                {
                    Console.WriteLine("Obesidade I"); count++;
                }


                else if ((peso[i] / (altura[i] * altura[i])) <= 39.9)
                {
                    Console.WriteLine("Obesidade II"); count++;
                }


                else Console.WriteLine("Obesidade III"); count++;
            }


            Console.ReadKey();

        }

    }
}
