using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager :MonoBehaviour
{
    public Slider playerHealthBar;
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        playerHealthBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) 
        {
            TakeDamage(10); 
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
