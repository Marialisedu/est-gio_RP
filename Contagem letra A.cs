using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string entrada = Console.ReadLine();

        int quantidade = ContLetA(entrada);
        
        if (quantidade > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {quantidade} vezes.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não está presente na frase.");
        }
    }

    static int ContLetA(string texto)
    {
        int contador = 0;

        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        return contador;
    }
}
