﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    internal interface IAccount
    {
       public void PasswordChecker(string password);
        public void ShowInfo();
    }
}
