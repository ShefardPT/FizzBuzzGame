using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Services
{
    public class SimpleAnalizer : IAnalizer
    {
        public FizzBuzzResult Analize(int number)
        {
            var result = new FizzBuzzResult();

            if (number % 3 == 0)
                result.IsFizz = true;
            if (number % 5 == 0)
                result.IsBuzz = true;

            return result;
        }
    }
}
