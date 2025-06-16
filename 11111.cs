using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];

        // Pedir al usuario que ingrese 10 números
        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar de forma ascendente
        Array.Sort(numeros);

        Console.WriteLine("\nNúmeros ordenados de forma ASCENDENTE:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        // Ordenar de forma descendente
        Array.Reverse(numeros);

        Console.WriteLine("\n\nNúmeros ordenados de forma DESCENDENTE:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}
