using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStates : MonoBehaviour
{
    public const string SEEKING = "Seeking";
    public const string SHOOTING = "SHOOTING";
    public const string CHASING = "Chasing";
    public const string DEAD = "Dead";
    public string enemyState;
    public EnemyShooting shootingState;
    public EnemyHealth enemyHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string SetEnemyState(float Distance, int enemyID)
    {
        enemyState = SEEKING;
        if(Distance > 30 && enemyID == 00 )
        {
            enemyState = SEEKING;
        }
        if(Distance < 30 && enemyID == 00 )
        {
            enemyState = CHASING;
        }
        if (Distance > 40 && enemyID == 01 ) 
        {
            enemyState = SEEKING;
        }
        if (Distance < 40 && enemyID == 01)
        {
            enemyState = CHASING;
        }
        if (Distance > 20 && enemyID == 02)
        {
            enemyState = SEEKING;
        }
        if (Distance < 20 && enemyID == 02)
        {
            enemyState = CHASING;
        }
        if (shootingState.currentState == SHOOTING)
        {
            enemyState = SHOOTING;
        }
        if(enemyHealth.currentHealth == 0)
        {
            enemyState = DEAD;
        }
        return enemyState;
    }
}
