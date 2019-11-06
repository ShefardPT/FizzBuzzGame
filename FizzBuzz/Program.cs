using FizzBuzz.Services;
using FizzBuzz.Services.Interfaces;
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play FizzBuzz!");

            IAnalizer analizer = new SimpleAnalizer();
            var eng = new Engine(analizer);
            eng.Run();

            Console.WriteLine("That's all!");
        }
    }
}
