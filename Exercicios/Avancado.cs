//      Bubble sort!!
//      Created by luhyxi 26-11-23

using System;
using Estrutura;
using System.Linq;

namespace Exercicios
{
    public class BubbleSort: Problema
    {
        public override void Iniciar()
        {
            idClass(); // Aumenta o ID da resolução
            
            Console.WriteLine("Insira os elementos da lista \n(Somente ints serão reconhecidos)");

            List<int> listaInt = Console.ReadLine()
                .Split(Separadores)
                .Where(s => int.TryParse(s, out _))
                .Select(int.Parse)
                .ToList();
            
            //// BUBBLE SORT!!! ////

            int temp;
            for (int i = 0; i < listaInt.Count - 1; i++)
            {
                for (int j = 0; j < listaInt.Count - 1 - i; j++) 
                {
                    if (listaInt[j] > listaInt[j + 1])
                    {
                        temp = listaInt[j];
                        listaInt[j] = listaInt[j + 1];
                        listaInt[j + 1] = temp; 
                    }
                }
            }

            foreach (var num in listaInt) { Console.WriteLine(num); } // Printing
            
            //// BUBBLE SORT!!! ////
        }
    }
}