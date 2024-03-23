//@niallivmi
using System;

namespace Pgc1Aula03Ex03
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            bool TF;

            do {
                float n1, n2;
                string car, V;
                Console.Write("Digite o número 1: ");
                n1 = float.Parse(Console.ReadLine());

                Console.Write("Digite o número 2: ");
                n2 = float.Parse(Console.ReadLine());

                Console.Write("Digite o caractere desejado: ");
                car = Console.ReadLine();

                if (car == "+")
                {
                    float R = n1 + n2;
                    Console.WriteLine("O resultado da operação de " + n1 + car + n2 + " é igual a: " + R);
                } else if (car == "-")
                {
                    float R = n1 - n2;
                    Console.WriteLine("O resultado da operação de " + n1 + car + n2 + " é igual a: " + R);
                }
                else if (car == "*")
                {
                    float R = n1 * n2;
                    Console.WriteLine("O resultado da operação de " + n1 + car + n2 + " é igual a: " + R);
                }
                else if (car == "/") {
                    float R = n1 / n2;
                    Console.WriteLine("O resultado da operação de " + n1 + car + n2 + " é igual a: " + R);
                } 

                Console.WriteLine("Deseja refazer? (S/N)");
                V = Console.ReadLine();

                TF = (V.ToUpper() == "S");
                Console.Clear();
            }
            while (TF);
            {
                Console.WriteLine("O programa será fechado!");
                Environment.Exit(0);
            }
        }
    }
}