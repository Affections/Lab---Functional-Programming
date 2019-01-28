using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();
            for (int i = 0; i < numberOfPeople; i++)
            {
                var person = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                people.Add(person[0], int.Parse(person[1]));
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();
                   
            var filter = CreateFilter(condition, age);
            var print = CreatePrint(format);
            foreach (var person in people)
            {
                if(filter(person))
                {
                    print(person);
                }
            }
        }

      

        static Func<KeyValuePair<string,int>,bool> CreateFilter(string condition, int age)
        {
            if (condition == "younger")
            {
                return n => n.Value < age;
            }
            else
                return n => n.Value >= age;
        }
        static Action<KeyValuePair<string, int>> CreatePrint(string format)
        {
            switch (format)
            {
                case "name":
                    {
                        return n => Console.WriteLine(n.Key);
                    }
                    break;
                case "age":
                    {
                        return n => Console.WriteLine(n.Value);
                    }
                    break;
                case "name age":
                    {
                        return n => Console.WriteLine(n.Key + " - " + n.Value);
                    }
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }
}
}
