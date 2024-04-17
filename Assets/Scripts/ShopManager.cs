using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ShopManager : MonoBehaviour
{
    public CoinCount coinCount;
    public Purchasing purchasing;


    public ShopItemsSO[] shopItemArray;
    public List<Button> purchaseBtns;
    public List<Button> tabButtons;
    public List<GameObject> ProductCards;
    public ProductCardManager productManager;
    public int playerBalance;
    public string currentTab = "Ship Upgrades";

    private int costAmount;
    void Start()
    {
        productManager = GetComponentInChildren<ProductCardManager>();
        purchaseBtns = SetButtonList(GetComponentsInChildren<Button>().ToList());
        productManager.DisplayCorrectTab(currentTab);
    }

    // Update is called once per frame
    void Update()
    {
       playerBalance = coinCount.coinNumber;
       Purchasing purchasing = new Purchasing(playerBalance);
        foreach (ProductCardTemplate template in productManager.template)
        {
            foreach (Button btn in purchaseBtns)
            {
               btn.interactable =  purchasing.CheckIfCanAfford(productManager.GetCostOfDisplayedItems(currentTab));
            }
        }
    }

    public List<Button> SetButtonList(List<Button> allButtons)
    {
        List<Button> newList = new List<Button>();

        foreach (Button button in allButtons)
        {
            if (button.name == "Purchase Button")
            {
                newList.Add(button);
            }
        }
        return newList; 
    }

    public void SetTab(int tabNumber)
    {
        if ( tabNumber == 0)
        {
            currentTab = "Ship Upgrades";        }
        if (tabNumber == 1) 
        {
            currentTab = "Ship Customization";
        }
        productManager.DisplayCorrectTab(currentTab);
    }

    
}
