using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    Vector2 moveVelocity;

    public void Start()
    {
        GameManager.PlayerHealth = 10;
        rb = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }
    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    /*public Transform player;

    public float speed = 5f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public void Update()
    {
        if(Input.GetMouseButtonDown(0)&&Input.mousePosition.x<Screen.width/2)
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        if(Input.GetMouseButton(0) && Input.mousePosition.x < Screen.width / 2)
        {
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchStart = false;
        }
    }

    public void FixedUpdate()
    {
        if(touchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 dir = Vector2.ClampMagnitude(offset, 1.0f);
            movePlayer(dir*1);
        }

    }

   

    void movePlayer(Vector2 dir)
    {
        player.Translate(dir * speed * Time.deltaTime);
    }*/
}
