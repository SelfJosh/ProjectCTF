using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LootManager : MonoBehaviour
{
    public GameObject lootPrefab;
    public List<Loot> LootList = new List<Loot>();
   
    
    Loot  GetDroppedItem()
    {
        int rng = Random.Range(1, 101);
        List<Loot> possibleItems = new List<Loot>();
        foreach (Loot item in LootList)
        {
            if(rng <= item.dropRate)
            {
                
                possibleItems.Add(item);
            }
        }
        if (possibleItems.Count > 0)
        {
            Loot droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
            return droppedItem;
        }
        return null;
    }

    public void SpawnLoot(Vector3 SpawnPosition)
    {
        Loot droppedItem = GetDroppedItem();
        if (droppedItem != null)
        {
            GameObject lootGameObject = Instantiate(lootPrefab, SpawnPosition, Quaternion.identity);

            LootPickUp namer = FindAnyObjectByType<LootPickUp>();
            namer.SetLootName(droppedItem.lootName);
            lootGameObject.GetComponent<SpriteRenderer>().sprite = droppedItem.lootSprite;
            if (droppedItem.lootName == "Coin")
            {
                lootGameObject.GetComponent<Animator>().runtimeAnimatorController = droppedItem.animatorController;
            }
        }
    }
}
