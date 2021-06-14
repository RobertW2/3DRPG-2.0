using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



    public class QuestGiver : MonoBehaviour
    {
      //  public Quest quest;

        public GameObject player;

        public GameObject questWindow;
        public TextMeshProUGUI titleText;
        public TextMeshProUGUI descriptionText;

    public bool isActive;

    public string title;
    public string description;
    public int experienceReward;
    public int goldReward;



    public void OpenQuestWindow()
        {

        // Sets Quest Book to open
            questWindow.SetActive(true);

        // Sets the text to update to what string is written on inspector
            titleText.text = title;
            descriptionText.text = description;
          //  experienceText.text = quest.experienceReward.ToString();
          //  goldText.text = quest.goldReward.ToString();

        }

        public void DeclineQuest()
        {
        // Sets Quest Book to close
            questWindow.SetActive(false);
          //  quest.isActive = false;
            
        }
    }

