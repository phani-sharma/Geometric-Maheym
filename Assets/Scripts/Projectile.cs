using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector2 Target;
    public float speed = 15;

    public void Start()
    {
        Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, Target) < 0.1f)
        {
            gameObject.SetActive(false);
        }
    }
}
