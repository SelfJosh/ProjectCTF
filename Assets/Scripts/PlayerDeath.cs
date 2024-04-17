using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public PlayerMovement controls;
    public Shoot shooting;
    public GameObject gameOver;
    public GameObject FuelUI;
    public GameObject BulletsUI;
    public GameObject HealthBarUI;
    public GameObject HUD;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            controls.enabled = false;
            shooting.enabled = false;
            gameOver.SetActive(true);
            FuelUI.SetActive(false);
            BulletsUI.SetActive(false);
            HealthBarUI.SetActive(false);
            HUD.SetActive(false);
        }
    }


    public IEnumerator DelayControls()
    {
        yield return new WaitForSeconds(0.5f);
        controls.enabled = true;
        HUD.GetComponent<Image>().color = Color.green;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            playerHealth.takeDamage(20);
            controls.enabled = false;
            StartCoroutine(DelayControls());
            HUD.GetComponent<Image>().color = Color.red;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            playerHealth.takeDamage(20);
        }

    }
}
