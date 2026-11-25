using System;

class Program
{
    // Вычислите факториал n (рекурсивный вариант)
    static long Factorial(int n)
    {
        return n <= 1 ? 1 : n * Factorial(n - 1);
    }

    static void Main()
    {
        Check(5, 120);
        Check(4, 24);
        Check(0, 1);
        Check(1, 1);
        Check(6, 720);
    }

    static void Check(int n, long expected)
    {
        long result = Factorial(n);
        string status = result == expected ? "OK" : "ОШИБКА";
        Console.WriteLine($"n = {n}: получено {result}, ожидалось {expected} - {status}");
    }
}