using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void SortEvenOddDescending(List<int> numbers)
    {
        List<int> sortedList = numbers.Where(x => x % 2 == 0).OrderByDescending(x => x)
            .Concat(numbers.Where(x => x % 2 != 0).OrderByDescending(x => x)).ToList();

        Console.WriteLine("الأرقام مرتبة تنازليًا مع الزوجية أولاً:");
        foreach (int num in sortedList)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 7, 3, 8, 5, 6, 2, 9 };
        SortEvenOddDescending(numbers);
    }
}

