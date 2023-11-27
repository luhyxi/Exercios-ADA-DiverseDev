//      EXERCÍCIO 07
// 
//      Faça um algoritmo que leia números até o usuário digitar 0, após
//      finalizar, mostre quantos números lidos, a soma e quantos são pares.
//      Created by luhyxi 26-11-23

using System;
using Estrutura;
using System.Linq;

namespace Exercicios
{
    public class AteZero: Problema
    {
        public override void Iniciar()
        {
            idClass();
            do
            {
                Console.Clear();
                Console.WriteLine("Adicione Numeros até 0, separados por espaços, ou escreva 'exit' para sair:");
                string[] input = Console.ReadLine().Split();

                if (input.Contains("exit", StringComparer.OrdinalIgnoreCase))
                {
                    Environment.Exit(0);
                }

                List<int> serieNum = new List<int>();

                for (int i = 0; i < input.Length; i++)
                {
                    if (!int.TryParse(input[i], out int intInput))
                    {
                        Console.WriteLine("Os números passados não são `integers`.");
                        Console.ReadKey();
                        return;
                    }
                    serieNum.Add(intInput);
                }

                if (!serieNum.Contains(0))
                {
                    Console.WriteLine("O seu input não contem 0.");
                    Console.ReadKey();
                    break;
                }
                
                List<int> subList = serieNum.TakeWhile(i => i != 0).ToList();

                Console.WriteLine($"A serie de numeros lidos: {string.Join(", ", subList)}");
                Console.WriteLine($"A quantidade de numeros lidos: {subList.Count}");
                Console.WriteLine($"A Soma dos numeros lidos: {subList.Sum()}");
                Console.WriteLine(
                    $"A quantidade de pares: {subList.Count(num => num % 2 == 0)}");
                Console.ReadKey();
            } while (true);

        }
    }
}