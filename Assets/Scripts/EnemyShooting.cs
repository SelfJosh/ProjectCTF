using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemyShooting : MonoBehaviour
{
    public EnemyStates enemyStates;
    public GameObject enemyProjectile;
    public Transform enemyProjectileSpawn;
    private GameObject playerMovement;
    public float distance;
    public float shotsFired = 0;
    public float reloadTime = 3;
    public float timeSinceLastReload;
    public string currentState;
    public bool shot;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>().gameObject;
    }

    public void Shoot()
    {
        timeSinceLastReload += Time.deltaTime;
        currentState = "Shooting";
        
        distance = Vector2.Distance(this.transform.position, playerMovement.transform.position);
        if (timeSinceLastReload > reloadTime && shotsFired < 3 && distance < 10 && shot == false)
        {
            Instantiate(enemyProjectile, enemyProjectileSpawn.transform.position, this.transform.rotation);
            shotsFired++;
            shot = true;
            StartCoroutine(waitfornextBullet());
        }
        if (shotsFired == 3)
        {
            shotsFired = 0;
            timeSinceLastReload = 0;
        }
    }

    IEnumerator waitfornextBullet()
    {
        yield return new WaitForSeconds(1);
        shot = false;
    }
}

