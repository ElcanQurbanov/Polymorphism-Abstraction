//using Abstraction_Interface.Services.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Abstraction_Interface.Services
//{
//    internal class AccountService : IAccountService
//    {
//        public string Name;
//        public string Password;

//        public AccountService(string name, string password)
//        {
//            Name = name;
//            Password = password;
//        }

//        public void sign()
//        {
//            throw new NotImplementedException();
//        }

//        internal void Sign()
//        {
//            if (Name == "Alakbar" && Password == "alakbar123")
//            {
//                Console.WriteLine("Uguruludur");
//            }
//            else
//            {
//                Console.WriteLine("Username ve yaxud password yanlisdir");
//            }
//        }

//        void IAccountService.AccountService()
//        {
//            throw new NotImplementedException();
//        }

//        void IAccountService.Sign()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
