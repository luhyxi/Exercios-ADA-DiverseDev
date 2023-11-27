//  Exercício 04: 
//  Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
//  a partir deles, crie um vetor C, composto pela somados elementos, sendo: 
// 
//  C[1] = A[1] + B[9], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.
//     Created by luhyxi 26-11-23

using System;
using Estrutura;
using System.Linq;

namespace Exercicios
{
    
    public class ArrayCompare: Problema
    {
        public override void Iniciar()
        {
            idClass(); // Aumenta o ID da resolução
            List<int> arrayA, arrayB = new List<int>();
            arrayA = GerarArrayInts(10);
            
            Console.Clear();
            Console.WriteLine($"O array A é:"); //Printing
            foreach (var num in arrayA) { Console.WriteLine(num); }
            
            arrayB = GerarArrayInts(10);
            
            Console.Clear();
            Console.WriteLine($"O array B é:"); //Printing
            foreach (var num in arrayB) { Console.WriteLine(num); }
            
            List<int> arrayC = new List<int>();
            for (int i = 0; i < arrayA.Count; i++)
            {
                int j = arrayB.Count - 1 - i;
                int temp = arrayA[i] + arrayB[j];
                arrayC.Add(temp);
            }

            Console.Clear();
            Console.WriteLine("O resultado é: \n");
            foreach (var num in arrayC) { Console.WriteLine(num); }
        }
    }
}