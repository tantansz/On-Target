using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    public float moveSpeed = 5;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        PreventLeavingScreen();
    }

    void PreventLeavingScreen()
    {
        if(transform.position.x <= -8.5f || transform.position.x >= 8.5f){
            float xPos = Mathf.Clamp (transform.position.x, -8.5f,8.5f);
            transform.position = new Vector3(xPos,transform.position.y, transform.position.z);
        } else if (transform.position.y <= -4.26f || transform.position.y >= -2.50f){
            float yPos = Mathf.Clamp (transform.position.y, -4.26f,-2.50f);
            transform.position = new Vector3(transform.position.x,yPos, transform.position.z);
        }
    }

    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
