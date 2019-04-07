using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Wyjatki
{
    public class BrakAutoryzacjiException: Exception
    {
        public BrakAutoryzacjiException(string message)
            : base(message)
        {

        }
    }
}
