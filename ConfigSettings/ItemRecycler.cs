using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSettings
{
    class ItemRecycler
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return "Key: " + Key + " - Value: " + Value;
        }
    }
}
