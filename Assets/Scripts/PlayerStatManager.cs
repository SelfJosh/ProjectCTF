using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatManager : MonoBehaviour
{

    public PlayerStatSO playerStats;


    public int SetPlayerHealthStat()
    {
        var Health = GetComponent<PlayerHealth>().maxHealth;
        Health = playerStats.maxHealth;
        return Health;
    }
}
