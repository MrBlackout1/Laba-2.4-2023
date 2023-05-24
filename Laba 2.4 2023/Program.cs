using System;
using System.Collections.Generic;
class Program
{
    delegate int StringLengthDelegate(string input);
    static void Main()
    {
        List<string> strings = new List<string>
        {
            "Hello",
            "World",
            "This",
            "Is",
            "A",
            "Test"
        };

        StringLengthDelegate stringLength = s => s.Length;

        foreach (string str in strings)
        {
            int length = stringLength(str);
            Console.WriteLine($"Length of '{str}': {length}");
        }
    }
}
