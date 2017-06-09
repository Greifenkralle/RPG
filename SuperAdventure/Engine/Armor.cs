using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Armor : Item
    {
        public int Protection { get; set; }

        public Armor(int id, string name, string namePlural, int protection) : base(id, name, namePlural)
        {
            Protection = protection;
        }
    }
}
