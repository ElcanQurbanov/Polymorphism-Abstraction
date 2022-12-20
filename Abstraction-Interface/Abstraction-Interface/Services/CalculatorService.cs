//using Abstraction_Interface.Services.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstraction_Interface.Services
//{
//    internal class CalculatorService : ICalculateService
//    {
//        public void Calculate()
//        {
            
//        }

//        public string Calculation(int num1, int num2, string operation)
//        {
//            double result;

//            switch (operation)
//            {
//                case "+":
//                    result = num1 + num2;
//                    return result.ToString();
//                case "-":
//                    result = num1 - num2;
//                    return result.ToString();
//                case "*":
//                    result = num1 * num2;
//                    return result.ToString();
//                case "/":
//                    result = num1 / num2;
//                    return result.ToString();
//                default:
//                    return "Please add correct operation";

//            }
    
//        }
//    }
//}