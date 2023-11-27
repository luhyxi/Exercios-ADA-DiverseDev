//      EXERCÍCIO 06
//      Some os números de 1 a 100 a imprima o valor.
//      
//      Created by luhyxi 26-11-23

using System;
using Estrutura;
using System.Linq;


namespace Exercicios
{
    public class PrintHundred : Problema
    {
        public override void Iniciar()
        {
            idClass();
            Console.WriteLine($"A soma de 1 a 100 usando a soma de Gauss é: {(100 * (100 + 1)) / 2}");
            
            int viaLinq = Enumerable.Range(1, 100).ToArray().Sum();
            Console.WriteLine($"A soma de 1 a 100 usando LINQ é: {viaLinq}");

            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"A soma de 1 a 100 usando loop é: {sum}");
        }
    }
}