//      Exercicio 03:
//      Implemente uma função que busca por um elemento em um array/lista 
//      e retorna a posição ou -1 se não encontrado.
//
//      Created by luhyxi 26-11-23

using System;
using Estrutura;
using System.Linq;

namespace Exercicios
{
    public class Finder: Problema
    {
        public override void Iniciar()
        {
            idClass(); // Aumenta o ID da resolução
            
            Console.WriteLine("Insira os elementos da lista");
            
            string[] inputArray = Console.ReadLine().Split(Separadores, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine("Qual elemento o usuario está pesquisando por?");
            string termoPesquisa = Console.ReadLine();
            
            string elementoEncontrado = inputArray.FirstOrDefault(elem => elem == termoPesquisa);
            
            if (elementoEncontrado != null)
            {
                Console.WriteLine($"Elemento encontrado na posição: [{Array.IndexOf(inputArray, elementoEncontrado)}]");
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}