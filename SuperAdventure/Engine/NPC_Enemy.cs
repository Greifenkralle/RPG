using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class NPC_Enemy : NPC
    {
        public string DeathText { get; set; }
        public int MaximumDamage { get; set; }
        public Weapon Weapon { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }

        public NPC_Enemy(int id, string name, int currentHitPoints, int maximumHitPoints, string speech, 
            string deathText, int maximumDamage, Weapon weapon, int rewardExperience, int rewardGold) 
            : base(id, name, speech, currentHitPoints, maximumHitPoints)
        {
            DeathText = deathText;
            MaximumDamage = maximumDamage;
            Weapon = weapon;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
        }
    }
}
