using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedHenrikogKim
{
    internal class Store
    {
        public string _name { get; private set; }
        public string _type { get; private set; }
        public int _priceLvl { get; private set; }

        public Store(string name, string type, int priceLvl)
        {
            _name = name;
            _type = type;
            _priceLvl = priceLvl;
        }
    }
}
