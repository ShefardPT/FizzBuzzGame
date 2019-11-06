using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Services.Interfaces
{
    public interface IAnalizer
    {
        FizzBuzzResult Analize(int number);
    }
}
