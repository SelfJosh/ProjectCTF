using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Shoot : MonoBehaviour
{
    public Transform ltpSpawn;
    public Transform lbpSpawn;
    public Transform rtpSpawn;
    public Transform rbpSpawn;

    public GameObject projectile;
    public GameObject Player;

    public ShootingFill shootingFill;

    public float reloadTime = 1.0f;

    public int timesFiredLeft = 0;
    public float leftBlastersTime = 0.0f; 
    public float rightBlastersTime = 0.0f;
    public int timesFiredRight = 0;



    // Start is called before the first frame update
    void Start()
    {
        ltpSpawn = ltpSpawn.gameObject.transform;
        lbpSpawn = lbpSpawn.gameObject.transform;
        rtpSpawn = rtpSpawn.gameObject.transform;
        rbpSpawn = rbpSpawn.gameObject.transform;

        

    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        shootingFill.DisplayBullets(timesFiredLeft,timesFiredRight,reloadTime,leftBlastersTime,rightBlastersTime);
    }

    public void shoot()
    {
        leftBlastersTime += Time.deltaTime;
        rightBlastersTime += Time.deltaTime;
        

        if (Input.GetKeyDown(KeyCode.Mouse0) && leftBlastersTime > reloadTime)
        {
            timesFiredLeft++;
            if(timesFiredLeft % 2 == 1)
            {
                Instantiate(projectile,ltpSpawn.position, Player.transform.rotation);
            }
            else
            {
                Instantiate(projectile,lbpSpawn.position, Player.transform.rotation);
                leftBlastersTime = 0.0f;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && rightBlastersTime > reloadTime)
        {
            timesFiredRight++;
            if (timesFiredRight % 2 == 1)
            {
                Instantiate(projectile, rtpSpawn.position, Player.transform.rotation);
            }
            else
            {
                Instantiate(projectile, rbpSpawn.position, Player.transform.rotation);
                rightBlastersTime = 0.0f;
            }
            
        }
    }
}
