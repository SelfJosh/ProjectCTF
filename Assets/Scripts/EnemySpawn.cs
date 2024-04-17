using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy1;
    public PlayerHealth playerHealth;

    public float spawnTime;
    public List<GameObject> enemySprites = new List<GameObject>();
    private int maxEnemies = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
       spawnTime = Random.Range(enemySprites.Count, enemySprites.Count + 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        spawnTime -= Time.deltaTime;
        spawnEnemy();
        for (int i = 0; i < enemySprites.Count; i++)
        {
            if (enemySprites[i] == null) 
            { 
                enemySprites.RemoveAt(i);
            }
        }
        
    }

    public void spawnEnemy()
    {
        if (playerHealth.currentHealth > 0 && 0 > spawnTime && enemySprites.Count < maxEnemies)
        {
            GameObject Enemies = Instantiate(Enemy1, this.transform.position +  new Vector3(Random.Range(0,5), Random.Range(0, 5), Random.Range(0, 5)), Quaternion.identity);
            enemySprites.Add(Enemies);
            spawnTime = spawnTime = Random.Range(enemySprites.Count, enemySprites.Count + 5);
        }
    }
}
