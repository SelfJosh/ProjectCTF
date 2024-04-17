using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour, IDataPersistence
{
    public Text coinTextNumber;
    public int coinNumber;

    private void Update()
    {
        coinTextNumber.text = string.Format(": {0}", coinNumber);
    }

    public int TotalCoins(int coinValue)
    {
        return coinNumber += coinValue;
    }

    public void LoadData(GameData data)
    {
        this.coinNumber = data.coinCount;
    }

    public void SaveData(ref GameData data)
    {
        data.coinCount = this.coinNumber;
    }
}
