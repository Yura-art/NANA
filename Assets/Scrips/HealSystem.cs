using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSistem : MonoBehaviour
{
    float currentHealth;
    float maxhealth;

    private void Start()
    {
        currentHealth = maxhealth;
    }

    public void RecieveDamage(float damage)
    {
        currentHealth -= maxhealth;

        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void recieveHealth(float heal)
    {
        currentHealth += heal;

        if (currentHealth > maxhealth)
        {
            currentHealth = maxhealth;
        }
    }
}