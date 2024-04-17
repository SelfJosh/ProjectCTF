using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fuel : MonoBehaviour
{
    public Slider fuelSlider;
    public TMP_Text fuelNumbers;

    public void SetMaxFuel(float maxFuel)
    {
        fuelSlider.maxValue = maxFuel;
        fuelSlider.value = maxFuel;
    }

    public void UpdateFuel(float fuel)
    {
        fuelSlider.value = fuel;
    }

    public void SetFuelUI(float maxfuel)
    {
        fuelNumbers.SetText(string.Format("{0:.00} / {0:.00}", maxfuel));
    }

    public void UpdateFuelUI(float currentFuel, float maxfuel)
    {
        fuelNumbers.SetText(string.Format("{0:.00} / {1:.00}", currentFuel, maxfuel));
    }
}
