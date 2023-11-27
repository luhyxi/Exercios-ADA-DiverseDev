//      Crie um programa que peça 10 números inteiros
//      e apresente a média, a soma e o menor.
//      Created by luhyxi 26-11-23

using System;
using Estrutura;
using System.Linq;

namespace Exercicios
{
    public class TenInts: Problema
    {
        public override void Iniciar()
        {
            idClass(); // Aumenta o ID da resolução
            
            List<int> tenInts = GerarArrayInts(10);

            Console.Clear();
            Console.WriteLine
($@"A média dos numeros inseridos é {tenInts.Average()}
A soma dos numeros inseridos é {tenInts.Sum()}
O menor dos numeros inseridos é {tenInts.Min()}");
        }
    }
}