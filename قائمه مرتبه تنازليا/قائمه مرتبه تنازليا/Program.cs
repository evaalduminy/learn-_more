
using System;
using System.Collections.Generic;

class Program
{
    static void SortAlphabetically(List<string> words)
    {
        words.Sort();
        Console.WriteLine("القائمة مرتبة أبجديًا:");
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        List<string> words = new List<string> { "تفاح", "برتقال", "موز", "عنب" };
        SortAlphabetically(words);
    }
}
