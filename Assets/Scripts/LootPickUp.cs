using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootPickUp : MonoBehaviour
{
    public Loot coin;
    public string lootName;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if ( lootName == coin.lootName)
            {
                CoinCount coin = FindObjectOfType<CoinCount>();
                coin.TotalCoins(5);
            }
            Debug.Log("PlayerPickup");
            Destroy(gameObject);
        }
    }

    public string SetLootName(string lootString)
    {
        return lootName = lootString;
    }
}
