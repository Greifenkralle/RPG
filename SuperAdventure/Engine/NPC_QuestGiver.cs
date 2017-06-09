using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class NPC_QuestGiver : NPC
    {
        public string AssignmentText { get; set; }
        public string CompletionText { get; set; }
        public Quest Quest { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }

        public NPC_QuestGiver(int id, string name, int currentHitPoints, int maximumHitPoints, 
            string speech, string assingmentText, string completionText, Quest quest, int rewardExperience, int rewardGold) 
            : base(id, name, speech, currentHitPoints, maximumHitPoints)
        {
            AssignmentText = assingmentText;
            CompletionText = completionText;
            Quest = quest;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
        }
    }
}
