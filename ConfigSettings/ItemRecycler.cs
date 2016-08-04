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

        public ItemRecycler()
        {
            Key = "";
            Value = 0;
        }

        public ItemRecycler(string Key, int Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
