using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class NPC : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Speech { get; set; }

        public NPC(int id, string name, string speech, int currentHitPoints, int maximumHitPoints)
            : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            Speech = speech;
        }
    }
}
