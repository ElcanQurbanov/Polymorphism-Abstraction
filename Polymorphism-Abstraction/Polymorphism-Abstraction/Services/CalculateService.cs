using Polymorphism_Abstraction.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction.Services
{
    internal class CalculateService : ICalculateService, ICommonServise
    {
        public void SumNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        public int GetSumNumbersFromArray(int[] numbers)
        {
            int sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }

            return sum;
        }

        public string FullData()
        {
            throw new NotImplementedException();
        }
    }
}
