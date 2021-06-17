using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void Update()
    {

    }

    public void HealthReset()
    {
        currentHealth = maxHealth;
    }

    public void OnTriggerEnter(Collider other)
    {
        TakeDamage(100);
    }






    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    public void Death()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
    }





}
