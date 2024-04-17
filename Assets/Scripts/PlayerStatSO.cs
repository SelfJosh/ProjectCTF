using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerStatSO : ScriptableObject
{
    public int maxHealth;
    public int maxShield;
    public int maxFuel;
    public Sprite playerSprite;
}
