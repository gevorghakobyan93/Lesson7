// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
class Task3
{
    static void Main()
    {
        Console.WriteLine($"Write numbers dividing by {','} to create array");
        string input = Console.ReadLine();
        if (input.Length == 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        int[] array = Array.ConvertAll(input.Split(','), Convert.ToInt32);
        ReverseArrayOrder(array, array.Length - 1);
    }

    static void ReverseArrayOrder(int[] array, int index)
    {
        if (index == -1)
            return;
        Console.WriteLine(array[index]);
        ReverseArrayOrder(array, index - 1);
    }
}