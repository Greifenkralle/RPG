using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{ 
    public class Monster_Big : Monster
    {
        public int SpecialReward { get; set; }

        public Monster_Big(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, 
            int currentHitPoints, int maximumHitPoints, int specialReward) 
            : base(id, name, maximumDamage, rewardExperiencePoints, rewardGold, currentHitPoints, maximumHitPoints)
        {
            SpecialReward = specialReward;
        }
    }
}
