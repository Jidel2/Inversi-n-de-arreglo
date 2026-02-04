using System;

class InvertirArreglo
{
    static void Main()
    {
        int[] numeros = new int[6];

        Console.WriteLine("Ingrese 6 números:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nArreglo en orden inverso:");

        for (int i = 5; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}
