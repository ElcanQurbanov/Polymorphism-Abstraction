using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction.Services.Interfaces
{
    internal interface ICalculateService
    {
        void SumNumbers(int num1, int num2);
        int GetSumNumbersFromArray(int[] numbers);
        
    }
}
