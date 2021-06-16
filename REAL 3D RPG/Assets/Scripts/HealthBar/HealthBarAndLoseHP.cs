using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarAndLoseHP : MonoBehaviour
{


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



        if (Input.GetKeyDown(KeyCode.K))
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
}
