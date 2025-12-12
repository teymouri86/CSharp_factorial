using System;

class Program
{
    // متد بازگشتی برای فاکتوریل
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        int[] numbers = new int[6];

        // دریافت 6 عدد از کاربر
        for (int i = 0; i < 6; i++)
        {
            Console.Write("عدد " + (i + 1) + " را وارد کنید: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nنتایج فاکتوریل:");

        // نمایش فاکتوریل هر عدد
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(numbers[i] + "! = " + Factorial(numbers[i]));
        }
    }
}
