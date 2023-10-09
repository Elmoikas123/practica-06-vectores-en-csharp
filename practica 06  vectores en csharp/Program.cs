using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declara una lista de cadenas
        List<string> aves = new List<string> { "Loro gris", "Paloma de diamante", "Cóctel" };

        Console.WriteLine("Los valores de la lista antes de insertar:");

        // Itera sobre la lista para imprimir los valores
        foreach (string ave in aves)
        {
            Console.Write(ave + " ");
        }

        Console.WriteLine();

        // Agrega tres valores al final de la lista utilizando el método Add()
        aves.Add("Mayna");
        aves.Add("Periquitos");
        aves.Add("Cacatúa");

        Console.WriteLine("Los valores de la lista después de insertar:");

        // Itera sobre la lista para imprimir los valores
        foreach (string ave in aves)
        {
            Console.Write(ave + " ");
        }

        Console.WriteLine();

        // Espera a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}