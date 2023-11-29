/*
Задача 64: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/


// using System;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Введите число M: ");
//         int M = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите число N: ");
//         int N = Convert.ToInt32(Console.ReadLine());

//       Console.WriteLine(PrintNumbers(M, N));
//     }

//     private static string PrintNumbers(int start, int end)
//     {
//         // Базовый случай
//         if (start > end) return string.Empty; // Если start > end, возвращаем пустую строку

//         // Рекурсивный случай
//         return start + "\t" + PrintNumbers(start + 1, end);
//     }
// }

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"M = {M}; N = {N}. -> {PrintNumbers(M, N)}  ");

    }

    private static string PrintNumbers(int M, int N)
    {
        if (M > N)
        {
           return "Некорректный диапазон";
        }

        string result = "\"";
        for (int i = M; i <= N; i++)
        {
            result += i;
            if (i < N)
            {
                result += ", ";
            }
        }
        result += "\"";

        return result;
    }
}
 
 