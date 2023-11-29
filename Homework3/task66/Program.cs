/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке
от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// using System;

// class Program
// {
//     static void Main()
//     {
//         int result = SumNaturalNumbers(1, 15);
//         Console.WriteLine($"M = 1; N = 15 -> {result}");

//     }

//     static int SumNaturalNumbers(int m, int n)
//     {
//         if (m > n)
//         {
//             return 0;
//         }

//         return m + SumNaturalNumbers(m + 1, n);
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

        if (M <= 0 || N <= 0)
        {
            Console.WriteLine("Числа M и N должны быть больше 0");
        }
        else
        {
            PrintNumbers(M, N, out string numbersString, out int sum);

            Console.WriteLine($"M = {M}; N = {N} -> {sum}");
        }
    }

    private static void PrintNumbers(int M, int N, out string result, out int sum)
    {
        if (M > N)
        {
            result = "Некорректный диапазон";
            sum = 0;
            return;
        }

        result = "\"";
        sum = 0;

        for (int i = M; i <= N; i++)
        {
            result += i;
            sum += i;

            if (i < N)
            {
                result += ", ";
            }
        }

        result += "\"";
    }
}


