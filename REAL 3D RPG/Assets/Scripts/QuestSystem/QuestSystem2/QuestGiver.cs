using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using InventorySystem;

public class QuestGiver : MonoBehaviour
    {
    //  public Quest quest;
        public PlayerQuest activeQuest;
        public GameObject player;

        public GameObject questWindow;
    public GameObject QuestNotFinishedWindow;
    public GameObject QuestCompleted;


    public TextMeshProUGUI titleText;
        public TextMeshProUGUI descriptionText;

    public TextMeshProUGUI goldText;
    public TextMeshProUGUI experienceText;

    public bool isActive;

    public string title;
    public string description;
    public int experienceReward;
    public int goldReward;



    public void OpenQuestWindow()
        {
        Debug.Log(FindObjectOfType<Inventory>().HasItem("Quest Item"));


        if (activeQuest.hasAcceptedQuest == false)
        {
            questWindow.SetActive(true);
        }

        else if (FindObjectOfType<Inventory>().HasItem("Quest Item"))
        {
            QuestCompleted.SetActive(true);

            activeQuest.hasCompletedQuest = true;

        }
            else
            {
                QuestNotFinishedWindow.SetActive(true);
            }


        // Sets Quest Book to open
            

        // Sets the text to update to what string is written on inspector
            titleText.text = title;
            descriptionText.text = description;
            experienceText.text = experienceReward.ToString();
            goldText.text = goldReward.ToString();

        }


        public void DeclineQuest()
        {
        // Sets Quest Book to close
            questWindow.SetActive(false);
          //  quest.isActive = false;
            
        }
    }

