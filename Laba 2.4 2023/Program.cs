using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо список рядків
        string[] strings = { "Volodymyr", "Georgiy", "Ivan", "Max" };

        // Створюємо делегат, який приймає рядок і повертає його довжину
        Func<string, int> stringLength = s => s.Length;

        // Виводимо довжини всіх рядків у списку
        foreach (string str in strings)
        {
            Console.WriteLine("{0} - {1} characters", str, stringLength(str));
        }
    }
}