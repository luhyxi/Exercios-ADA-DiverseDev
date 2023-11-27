//      Gerador de Array com input do usuario
//      Created by luhyxi 26-11-23

using System;
using Estrutura;
using System.Linq;

namespace Exercicios
{
    public class RandomArray : Problema
    {
        public override void Iniciar()
        {
            idClass();         // Aumenta o ID da resolução
            int ArraySize;     // Declarações universais
            
            // Recebe a quantidade de itens do array
            do 
            {
                Console.WriteLine("Insira a quantidade de numeros no array");
                if (!int.TryParse(Console.ReadLine(), out int userInput) || userInput <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Insira uma quantidade positiva de numeros");
                    continue;
                }
                ArraySize = userInput;
                break;
            } while (true);


             // Recebe os elementos do array
             Console.WriteLine("Insira os valores do Array");
             string[] userInputArray = Console.ReadLine().Split(Separadores);

             int[] integers = userInputArray
                 .Where(str => int.TryParse(str, out _))
                 .Select(int.Parse)
                 .ToArray();
             
             // Valida se o resizing é necessário
            if (integers.Length != ArraySize)
            {
                    Console.WriteLine($"O tamanho do array deve ser {ArraySize}. Redimensionando... \n");
                    Array.Resize(ref integers, ArraySize);
            }

                
                // Output dos elementos no Array
                for (int lugarElemento = 0; lugarElemento < integers.Length; lugarElemento++)
                {
                    Console.WriteLine($"O elemento na posição [{lugarElemento}]: {integers[lugarElemento]}");
                }
        }
    }
}
