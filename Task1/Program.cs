//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

class Task1
{
    static void Main()
    {
        Console.WriteLine("Write range start nunber");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Write range end nunber");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Natural numbers between {start} and {end} are following ");
        RangeBetween(start, end);
    }
    static void RangeBetween(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            RangeBetween(m + 1, n);
        }
    }
}