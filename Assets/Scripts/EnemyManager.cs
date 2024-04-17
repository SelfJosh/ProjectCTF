using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public AllEnemyMovement AllEnemyMovement;
    public EnemyStates enemyStates;
    public EnemyShooting enemyShooting;
    public EnemyHealth enemyHealth;
    public ScoreKeeper scoreKeeper;
    public MoveProjectile projectileDamage;
    public Enemy Enemy;
    public List<Enemy> enemyList = new List<Enemy> { };
    public EnemyList list = new EnemyList();
    public GameObject beeGrunt;
    public GameObject flyGrunt;
    public GameObject mothGrunt;
    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        Enemy Enemy1 = new Enemy(beeGrunt.gameObject.name, 00, enemyHealth.currentHealth, 50, beeGrunt.gameObject);
        Enemy Enemy2 = new Enemy(flyGrunt.gameObject.name, 01, enemyHealth.currentHealth, 75, flyGrunt.gameObject);
        Enemy Enemy3 = new Enemy(mothGrunt.gameObject.name, 02, enemyHealth.currentHealth, 25, mothGrunt.gameObject);

        enemyList.Add(Enemy1);
        enemyList.Add(Enemy2);
        enemyList.Add(Enemy3);
        this.gameObject.SetActive(true);
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i< enemyList.Count; i++)
        {
            if (this.gameObject == enemyList[i].enemySprite && playerHealth.currentHealth > 0)
            {
                float dist = AllEnemyMovement.DistanceRotation(enemyList[i].enemySprite);
                AllEnemyMovement.CustomMovement(enemyList[i].ID, enemyStates.SetEnemyState(dist, enemyList[i].ID));
            }
            
            if (this.gameObject == enemyList[1].enemySprite && playerHealth.currentHealth > 0)
            {

            }
            else
            {
                StartCoroutine(DecideToShoot());
            }
        }
        
        projectileDamage = FindObjectOfType<MoveProjectile>();
    }

    IEnumerator DecideToShoot()
    {
        int rng = Random.Range(0, 100);

        if (rng % 2 == 1)
        {
            yield return new WaitForSeconds(3);
            enemyShooting.Shoot();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < enemyList.Count; i++)
        {
            
            if (collision.gameObject.tag == "Bullet" && this.gameObject == enemyList[i].enemySprite)
            {
                scoreKeeper.TotalScore(enemyList[i].enemyPoints);
                scoreKeeper.Kills(1);
                enemyHealth.takeDamage(projectileDamage.damage);
            }
        }
        
    }

}



