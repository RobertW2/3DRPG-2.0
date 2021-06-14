using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

    public class PlayerQuest : MonoBehaviour
    {

    // Players default stats
        public int health = 5;
        public int experience = 100;
        public int gold = 1000;

    // TMPro Texts
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI experienceText;

        public void GoBattle()
        {


        // Minus or add value when In battle
            health -= 1;
            experience += 50;
            gold += 5;

        // Update values that have been changed to the string ingame
            goldText.text = gold.ToString();
            experienceText.text = experience.ToString();
        }
        
        










    }

