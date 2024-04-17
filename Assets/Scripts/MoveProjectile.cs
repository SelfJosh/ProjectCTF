using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;

    public float moveSpeed = 1000f;

    public float timeAlive = 3f;
    public int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        projectile.AddForce( transform.up * moveSpeed * Time.deltaTime);
        if (timeAlive <= 0) 
        {
            Destroy(gameObject);
        }
        timeAlive -= Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boundary")
        {
            
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
