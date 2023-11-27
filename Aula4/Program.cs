// See https://aka.ms/new-console-template for more information

using Exercicios;

Console.WriteLine($@"Insira o programa desejado
1 - Gerador de Array com input do usuario
2 - Retorno Elemento do Array
3 - Soma de Arrays
4 - Soma, Média e Menor
5 - Some os números de 1 a 100 a imprima o valor
6 - Até Zero");

string input = Console.ReadLine();

switch (input) //TODO: Implementar a logica de um objeto separado chamado ´desafio´ que gera os cases
{
    case "1":
        Console.Clear();
        RandomArray desafio1 = new RandomArray();
        desafio1.Iniciar();
        break;
    case "2":
        Console.Clear();
        Finder desafio2 = new Finder();
        desafio2.Iniciar();
        break;
    case "3":
        Console.Clear();
        ArrayCompare desafio3 = new ArrayCompare();
        desafio3.Iniciar();
        break;
    case "4":
        Console.Clear();
        TenInts desafio4 = new TenInts();
        desafio4.Iniciar();
        break;
    case "5":
        Console.Clear();
        PrintHundred desafio5 = new PrintHundred();
        desafio5.Iniciar();
        break;
    case "6":
        Console.Clear();
        AteZero desafio6 = new AteZero();
        desafio6.Iniciar();
        break;
    default:
        Console.WriteLine("Por favor, insira um número válido da lista");
        break;
}