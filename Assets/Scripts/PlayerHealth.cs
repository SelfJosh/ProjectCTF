using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public HealthBar healthBar;
    public TMP_Text healthNumbers;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = GetComponent<PlayerStatManager>().SetPlayerHealthStat();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthNumbers.SetText(string.Format("{0}/{1}", currentHealth, maxHealth));
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        healthNumbers.SetText(string.Format("{0}/{1}", currentHealth,maxHealth));
    }
}
