using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemyMovement : MonoBehaviour
{

    private GameObject _player;
    public float _speed;
    public float _distance;
    public EnemyStates enemyStates;
    public int rngX;
    public int rngY;
    public Vector3 randomCords;
    public float currentTime;
    private ScoreKeeper scoreKeeper;
    public EnemyManager EnemyManager;
    public float radius = 2f;
    public float angle = 0f;
    //public int enemyID;

    void Start()
    {
        InvokeRepeating("Randomcords", 1.0f,2.0f);
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    private void Update()
    {
        
        currentTime = Time.unscaledTime;
        
    }

    public float DistanceRotation(GameObject enemy)
    {
        _player = FindObjectOfType<PlayerMovement>().gameObject;
        _distance = Vector2.Distance(enemy.transform.position, _player.transform.position);
        

        return _distance;
    }
    public void Randomcords()
    {
        rngX = Random.Range(-100, 100);
        rngY = Random.Range(-100, 100);
        randomCords = new Vector3(rngX, rngY);
    }
    public void CustomMovement(int enemyID, string enemyState)
    {
        ;
            if (enemyID == 00)
            {
                if (enemyState == "Seeking")
                {   
                     Vector2 direction = randomCords - EnemyManager.enemyList[enemyID].enemySprite.transform.position;
                     float directionAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                     transform.rotation = Quaternion.Euler(Vector3.forward * directionAngle);
                     transform.position = Vector2.MoveTowards(EnemyManager.enemyList[enemyID].enemySprite.transform.position, randomCords, _speed * Time.deltaTime);
                    
                }
                if (enemyState == "Chasing")
                {   
                    Vector2 direction = _player.transform.position - EnemyManager.enemyList[enemyID].enemySprite.transform.position;
                    float directionAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                    transform.rotation = Quaternion.Euler(Vector3.forward * directionAngle);
                    transform.position = Vector2.MoveTowards(EnemyManager.enemyList[enemyID].enemySprite.transform.position, _player.transform.position, _speed * Time.deltaTime);
                }
                
            }

            if (enemyID == 01)
            {
                if (enemyState == "Seeking")
                {
                    Vector2 direction = randomCords - EnemyManager.enemyList[enemyID].enemySprite.transform.position;
                    float directionAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                    transform.rotation = Quaternion.Euler(Vector3.forward * directionAngle);
                    transform.position = Vector2.MoveTowards(EnemyManager.enemyList[enemyID].enemySprite.transform.position, randomCords, _speed * Time.deltaTime);
                }
                if (enemyState == "Chasing")
                {
                    Vector2 direction = _player.transform.position - EnemyManager.enemyList[enemyID].enemySprite.transform.position;
                    float directionAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                    transform.rotation = Quaternion.Euler(Vector3.forward * directionAngle);
                    transform.position = Vector2.MoveTowards(EnemyManager.enemyList[enemyID].enemySprite.transform.position, _player.transform.position, _speed * Time.deltaTime);
                }
                
            }
            if (enemyID == 02)
            {
                if (enemyState == "Seeking")
                {

                 Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                 mousePos.z = transform.position.z;

                 Vector2 direction = mousePos - transform.position;
                 direction.Normalize();
                 float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                 transform.rotation = Quaternion.Euler(Vector3.forward * angle);
                 transform.position = Vector3.MoveTowards(EnemyManager.enemyList[enemyID].enemySprite.transform.position, mousePos, _speed * Time.deltaTime * 2);
                }
                if (enemyState == "Chasing")
                {
                    Vector2 direction = _player.transform.position - EnemyManager.enemyList[enemyID].enemySprite.transform.position;
                    float directionAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                    transform.rotation = Quaternion.Euler(Vector3.forward * directionAngle);
                    transform.position = Vector2.MoveTowards(EnemyManager.enemyList[enemyID].enemySprite.transform.position, _player.transform.position, (_speed / 2) * Time.deltaTime);
                }
                
            }
        
    }

    
}
