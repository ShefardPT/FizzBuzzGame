using FizzBuzz.Models;
using FizzBuzz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Services
{
    public class AdvancedAnalizer : IAnalizer
    {
        private IAnalizer _simpleAnalizer;

        public AdvancedAnalizer()
        {
            _simpleAnalizer = new SimpleAnalizer();
        }

        public FizzBuzzResult Analize(int number)
        {
            var result = _simpleAnalizer.Analize(number);

            var stringNumber = number.ToString();

            for (int i = 0; i < stringNumber.Length; i++)
            {
                if (result.IsFizz && result.IsFizz)
                    break;
                if (!result.IsFizz && stringNumber[i] == '3')
                    result.IsFizz = true;
                if (!result.IsBuzz && stringNumber[i] == '5')
                    result.IsBuzz = true;
            }

            return result;
        }
    }
}
