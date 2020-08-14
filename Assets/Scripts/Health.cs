using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathEffect;
    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathEffects();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathEffects()
    {
        if (!deathEffect)
        {
            return;
        }
        else
        {
            GameObject deathFX= Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(deathFX, 1f);
        }
    }
}
