using Polymorphism_Abstraction.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction.Services
{
    internal class AccountService : IAccountService, ICommonServise
    {
        public string FullData()
        {
            throw new NotImplementedException();
        }
    }
}
