using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSystem : MonoBehaviour
{
    float currentHeal;
    float maxHeal;

    private void Start()
    {
        currentHeal = maxHeal;
    }

    public void ReciveDamage(float damage)
    {
        currentHeal -= damage;

        if (currentHeal <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void ReciveHeal(float heal)
    {
        currentHeal += heal;

        if (currentHeal > maxHeal)
        {
            currentHeal = maxHeal;
        }
    }
}
