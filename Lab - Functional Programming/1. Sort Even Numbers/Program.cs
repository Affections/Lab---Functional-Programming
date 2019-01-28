using System;
using System.Linq;

namespace Lab___Functional_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();
            Console.WriteLine(string.Join(", ",numbers));
                
        }
    }
}
