using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int n = FindFibonacciNumber(a);

        Console.WriteLine(n);
    }

    static int FindFibonacciNumber(int a)
    {
        int prev = 0;
        int curr = 1;
        int n = 1;

        while (curr < a)
        {
            int temp = curr;
            curr = prev + curr;
            prev = temp;
            n++;
        }

        if (curr == a)
        {
            return n;
        }
        else
        {
            return -1;
        }
    }
}