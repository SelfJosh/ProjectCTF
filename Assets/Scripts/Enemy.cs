using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy 
{
    public string Name;
    public int ID;
    public int Health;
    public int enemyPoints;
    public GameObject enemySprite;


    public Enemy()
    {

    }
    public Enemy(string name, int id, int health, int points, GameObject enemy)
    {
        Name = name;
        ID = id;
        Health = health;
        enemySprite = enemy;
        enemyPoints = points;
    }
}
