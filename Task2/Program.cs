//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
class Task2
{
    static void Main()
    {
        Console.WriteLine("Write first value");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Write second value");
        int n = Convert.ToInt32(Console.ReadLine());
        int ack = Ackerman(m, n);
        Console.WriteLine($"Result {ack}");
    }
    static int Ackerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackerman(m - 1, 1);
        else if (m > 0 && n > 0)
            return Ackerman(m - 1, Ackerman(m, n - 1));
        else
            return -1; // Ackermann function is undefined for negative integers
    }
}