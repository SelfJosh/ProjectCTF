using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductCardManager : MonoBehaviour
{

    public ShopItemsSO[] shopItems;
    public ProductCardTemplate[] template;
    public GameObject productCardPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisplayCorrectTab(string tabName)
    {
        if (tabName == "Ship Upgrades")
        {
            foreach(ShopItemsSO item in shopItems)
            {
                if (item.purchaseType == "Ship Upgrades")
                {
                    List<ShopItemsSO> shipUpgrades = new List<ShopItemsSO>();
                    shipUpgrades.Add(item);
                    foreach (ProductCardTemplate template in template)
                    {
                        template.productImage.sprite = item.ProductImage;
                        template.CostTxt.text = string.Format(": {0}", item.itemCost.ToString());
                        template.productDescription.text = item.productDescription;
                    }
                }
            }
            
        }
        if (tabName == "Ship Customization")
        {
            foreach (ShopItemsSO item in shopItems)
            {
                if (item.purchaseType == "Ship Customization")
                {
                    List<ShopItemsSO> shipCustomization = new List<ShopItemsSO>();
                    shipCustomization.Add(item);
                    foreach (ProductCardTemplate template in template)
                    {
                        template.productImage.sprite = item.ProductImage;
                        template.CostTxt.text = string.Format(": {0}", item.itemCost.ToString());
                        template.productDescription.text = item.productDescription;
                    }
                }
            }
            
        }
    }

    public int GetCostOfDisplayedItems(string tabName)
    {
        if (tabName == "Ship Upgrades")
        {
            foreach (ShopItemsSO item in shopItems)
            {
                if (item.purchaseType == "Ship Upgrades")
                {
                    List<ShopItemsSO> shipUpgrades = new List<ShopItemsSO>();
                    shipUpgrades.Add(item);
                    return item.itemCost;
                }
            }

        }
        if (tabName == "Ship Customization")
        {
            foreach (ShopItemsSO item in shopItems)
            {
                if (item.purchaseType == "Ship Customization")
                {
                    return item.itemCost;
                }
            }

        }
        return 0;
    }
}
