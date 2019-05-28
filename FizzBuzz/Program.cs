using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            IEnumerable<string> value = fizzBuzz.DoFizzBuzz(0, 100, 3, 5);
            Console.WriteLine(value.Aggregate((a, b) => a + ", " + b));
        }
    }
}
