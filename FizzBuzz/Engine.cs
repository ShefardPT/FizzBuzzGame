using FizzBuzz.Services;
using FizzBuzz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class Engine
    {
        IAnalizer _analizer;

        public Engine(IAnalizer analizer)
        {
            _analizer = analizer;
        }

        public void Run()
        {
            for (int i = 0; i <= 100; i++)
            {
                var result = _analizer.Analize(i);

                if (result.IsFizz && result.IsBuzz)
                    Console.WriteLine("FizzBuzz!");
                else if (result.IsFizz)
                    Console.WriteLine("Fizz!");
                else if (result.IsBuzz)
                    Console.WriteLine("Buzz!");
                else
                    Console.WriteLine($"{i}!");
            }
        }
    }
}
