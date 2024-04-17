using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

[CreateAssetMenu]
public class Loot : ScriptableObject
{
    public Sprite lootSprite;
    public string lootName;
    public int dropRate;
    public RuntimeAnimatorController animatorController;

    public Loot(string lootName, int dropRate)
    {
        this.lootName = lootName;
        this.dropRate = dropRate;
    }


}
