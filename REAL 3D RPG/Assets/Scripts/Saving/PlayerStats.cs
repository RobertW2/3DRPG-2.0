using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public PlayerQuest PlayerQuest;

    

    public int level = 3;
    public int health = 40;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        


        if(Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(20);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        TakeDamage(20);
    }




    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }



    /// <summary>
    /// Saving Section
    /// </summary>
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        

        level = data.level;
        health = data.health;
       
       
        

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
}
