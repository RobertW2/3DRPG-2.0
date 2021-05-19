using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Quests
{
    public enum QuestStage
    {
        // We cant get the quest
        Locked,
        // The quest is now avaliable
        Unlocked,
        // We have accepted the quest 
        InProgress,
        // We have done all the things in the quest, we just need to hand it in
        RequirementsMet, 
        // the quest is now done and we can ignore it.
        Complete
    }

    [System.Serializable]
    public abstract class Quest : MonoBehaviour
    {
        public string title;
        [TextArea] public string description;
        public QuestReward reward;

        public QuestStage stage;

        public bool locked;
        public bool inProgress;
        public bool isComplete;
        
        public int requiredLevel;
        [Tooltip("The title of the previous quest in the chain.")]
        public string previousQuest;
        [Tooltip("The title of the quests to be unlocked.")]
        public string[] unlockedQuests;

        public abstract bool CheckQuestCompletion(); 
        /* { return false; } */
    }

    [System.Serializable]
    public struct QuestReward
    {
        public float experience;
        public int gold;
       
    }
}
