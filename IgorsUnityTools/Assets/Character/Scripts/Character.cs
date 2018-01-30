using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    [SerializeField] private int maxHealth = 100;
    [SerializeField]
    private int currentHealth;

    void Awake()
    {
        currentHealth = maxHealth;

    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth -= amount;

    }
}
