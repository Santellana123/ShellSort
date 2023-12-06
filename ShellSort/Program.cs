﻿int[] array = new int[8];
array[0] = 7;
array[1] = 3;
array[2] = 14;
array[3] = 20;
array[4] = 31;
array[5] = 4;
array[6] = 10;
array[7] = 11;

Console.WriteLine("Arreglo desordenado:");
PrintArray(array);

// Guardar el tiempo de inicio
DateTime startTime = DateTime.Now;

ShellSort(array);

// Guardar el tiempo de finalización
DateTime endTime = DateTime.Now;

// Calcular la duración del algoritmo
TimeSpan duration = endTime - startTime;
Console.WriteLine($"\nTiempo de ejecución: {duration.TotalMilliseconds} ms");

// Mostrar el arreglo ordenado
Console.WriteLine("\nArreglo ordenado:");
PrintArray(array);

Console.ReadLine();

static void ShellSort(int[] array)
{
    // se obtiene la longitud del array
    int n = array.Length;
    // se obtiene el tamaño de espacio entre elementos
    int gap = n / 2;

    Console.WriteLine("\nInicio del algoritmo Shell Sort:");

    // Mientras el espacio entre elementos sea mayor que 0
    while (gap > 0)
    {
        Console.WriteLine($"\nGap actual: {gap}");

        // Aplicar el algoritmo de inserción para cada "subarray" con el tamaño de gap
        for (int i = gap; i < n; i++)
        {
            // Guardar el valor actual del elemento en una variable temporal
            int temp = array[i];
            int j = i;

            Console.WriteLine($"\nComparando {temp} con los elementos en su subarray:");

            // Realizar la inserción
            while (j >= gap && array[j - gap] > temp)
            {
                // Desplazar elementos hacia la derecha hasta encontrar la posición correcta
                array[j] = array[j - gap];
                j -= gap;

                PrintArray(array);
            }

            // Colocar el valor temporal en la posición correcta en el subarray
            array[j] = temp;
            Console.WriteLine($"Insertar {temp} en la posición {j} del subarray:");
            PrintArray(array);
        }

        // Reducir el espacio entre elementos a la mitad en cada iteración
        gap /= 2;
    }

    Console.WriteLine("\nFin del algoritmo Shell Sort:");
}

static void PrintArray(int[] array)
{
    foreach (var num in array)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
