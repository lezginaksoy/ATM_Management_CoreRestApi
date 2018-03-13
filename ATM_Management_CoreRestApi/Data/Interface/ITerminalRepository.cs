﻿using ATM_Management_CoreRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Management_CoreRestApi.Data.Interface
{
   public  interface ITerminalRepository:IRepository<Terminal>
    {
        IEnumerable<Terminal> GetAllWithCode();
        IEnumerable<Terminal> FindWithCode(Func<Terminal, bool> predicate);
        IEnumerable<Terminal> FindWithBrand(Func<Terminal, bool> predicate);

    }
}
