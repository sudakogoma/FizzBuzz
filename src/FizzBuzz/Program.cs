using System;
using System.Linq;

namespace FizzBuzz
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzExecuter();

            foreach (var s in Enumerable.Range(1, 100)
                .Select(x => fizzBuzz.Convert(x)))
            {
                Console.WriteLine(s);
            }

            _ = Console.ReadKey(true);
        }
    }
}
