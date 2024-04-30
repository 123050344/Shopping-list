using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_list
{
    internal class slist
    {
        private int number;
        private string buys;

        public int Number { get => number; set => number = value; }
        public string Buys { get => buys; set => buys = value; }

        public slist(int _number, string _buys)
        {
            number = _number;
            buys=_buys;
        }
        public override string ToString()
        {
            return number + " - " + buys;
        }

    }
}
