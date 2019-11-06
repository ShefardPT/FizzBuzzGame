using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Models
{
    public class FizzBuzzResult
    {
        public bool IsFizz { get; set; }
        public bool IsBuzz { get; set; }

        public FizzBuzzResult()
        {
            IsFizz = false;
            IsBuzz = false;
        }
    }
}
