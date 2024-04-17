using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchasing
{
    public int playerBalance;

    public Purchasing(int playerBalance)
    {
        this.playerBalance = playerBalance;
    }

    public bool CheckIfCanAfford(int costAmount)
    {
        if ( playerBalance >= costAmount)
        {
            return true;
        }
        return false;
    }

    public int Purchase(int costAmount)
    {
        return playerBalance -= costAmount;
    }
}
