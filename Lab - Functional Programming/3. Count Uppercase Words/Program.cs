using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = n => char.IsUpper(n[0]);
            var text = Console.ReadLine()
                .Split(new string[] { " " } , StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();
            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
                
        }
    }
}
