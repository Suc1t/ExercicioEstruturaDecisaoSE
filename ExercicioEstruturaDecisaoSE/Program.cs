using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExercicioEstruturaDecisaoSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercicio:
                    -Construa um algoritimo que informe se o numero digitado é positivo, negativo ou zero
            */

            int valor;
            Console.Write("Digite um valor:");
            valor = int.Parse(Console.ReadLine());

            if (valor > 0) //quando temos um unico comando as{} são opcionais.
            {
                Console.WriteLine("Você escolheu um numero positivo");
            }
            else
            {
                if (valor < 0)
                {
                    Console.WriteLine("Você escolheu um numero negativo");
                }
                else
                {
                    Console.WriteLine("Você escolheu um numero neutro");
                }
            }
            Console.ReadKey();
        }
    }
}




