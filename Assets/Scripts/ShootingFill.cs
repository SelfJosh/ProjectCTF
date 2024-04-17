using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingFill : MonoBehaviour
{
    public Slider bulletFill_1;
    public Slider bulletFill_2;
    public Slider bulletFill_3;
    public Slider bulletFill_4;
    

    public void DisplayBullets(int timesFL, int timesFR, float reloadTime, float lTime, float rTime)
    {
        if (lTime > reloadTime)
        {
            bulletFill_1.value = 1;
            bulletFill_2.value = 1;
        }
        if (timesFL != 0 && timesFL % 2 == 1)
        {
            bulletFill_1.value = 0;
        }
        if(timesFL != 0 && timesFL % 2 == 0 && lTime == 0)
        {
            bulletFill_2.value = 0;
        }
        
        if (rTime > reloadTime)
        {
            bulletFill_3.value = 1;
            bulletFill_4.value = 1;
        }
        if (timesFR != 0 && timesFR % 2 == 1 )
        {
            bulletFill_3.value = 0;
        }
        if(timesFR != 0 && timesFR % 2 == 0&& rTime == 0)
        {
            bulletFill_4.value = 0;
        }
        
    }
}
