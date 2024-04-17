using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 mousePos;
    public float playerSpeed = 20f;
    public float maxFuel;
    public float currentFuel;
    public Fuel fuel;
    

    // Start is called before the first frame update
    void Start()
    {
        maxFuel = 250;
        fuel.SetFuelUI(maxFuel);
        fuel.SetMaxFuel(maxFuel);
        currentFuel = maxFuel;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    { 

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePos.z = transform.position.z;

        Vector2 direction = mousePos -transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }

    private void FixedUpdate()
    {
       if(Input.GetKey(KeyCode.Space) && currentFuel > 0) 
        {
            currentFuel -= 0.1f;
            transform.position = Vector3.MoveTowards(transform.position, mousePos, playerSpeed * Time.deltaTime);
        }
        fuel.UpdateFuel(currentFuel);
        fuel.UpdateFuelUI(currentFuel, maxFuel);
    }

    


}
