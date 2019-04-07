using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Wyjatki
{
    public class BrakSrodkowNaKoncieException: Exception
    {
        public BrakSrodkowNaKoncieException(string message)
            : base(message)
        {

        }
    }
}
