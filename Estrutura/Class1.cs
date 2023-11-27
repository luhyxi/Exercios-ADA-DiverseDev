namespace Estrutura;

public abstract class Problema
{
    private string nome { get; set; }
    private string resultado { get; set; }
    public static int idDaClasse { get; set; } //Id da Classe que sempre aumenta
    
    public static char[] Separadores = { ' ', ',' };  //Separadores para parsing
    public virtual void Iniciar()
    {
        idDaClasse++;
        Console.WriteLine("Inicializar resolução");
    }
    public List<int> GerarArrayInts(int tamanhoArray)
    {
        List<int> arrayInt = new List<int>(); // Lista de ints
        do
        {
            if (arrayInt.Count >= tamanhoArray)
            {
                arrayInt = arrayInt.Take(tamanhoArray).ToList();
                break;
            }

            Console.WriteLine("Insira 10 numeros ´int´");
            string[] input = Console.ReadLine().Split(Separadores, StringSplitOptions.RemoveEmptyEntries);

            foreach (string elem in input)
            {
                if (int.TryParse(elem, out int num))
                {
                    arrayInt.Add(num);
                }
            }
        } while (arrayInt.Count <= tamanhoArray);

        return arrayInt;
    }
    public virtual void idClass() { idDaClasse++; } // Desnecessário
}