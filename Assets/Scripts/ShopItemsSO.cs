using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]
public class ShopItemsSO : ScriptableObject
{
    public Sprite ProductImage;
    public string itemName;
    public string productDescription;
    public int itemCost;
    public string itemRank;
    public string purchaseType;
}
    
