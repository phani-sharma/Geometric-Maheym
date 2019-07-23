using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    
    public enum Bullets { Square, Triangle, Cross }
    public Bullets bulletState;
    public Transform MuzzlePos;
    public GameObject Bullet1, Bullet2, Bullet3;
    int index;

    public AudioClip shootSound;

    public void Start()
    {
        bulletState = Bullets.Cross;
        index = 0;
       // Debug.Log("Default Value" + index);
        //Debug.Log("Default Bullet" + index);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            index = setOne(index);
         //   Debug.Log(index);
            SetState(index);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            index = setTwo(index);
           // Debug.Log(index);
            SetState(index);
        }
        selectBullet(bulletState);
    }
    public void selectBullet(Bullets n)
    {
        switch (n)
        {
            case Bullets.Cross:
                if (index == 0)
                {
                    
                    if (Input.GetMouseButtonDown(0))
                    {
                        soundManager.instance.PlaySingle(shootSound);
                        Instantiate(Bullet1, MuzzlePos.position, Quaternion.identity);
                    }
                }
                break;
            case Bullets.Square:
                if (index == 1)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        soundManager.instance.PlaySingle(shootSound);
                        Instantiate(Bullet2, MuzzlePos.position, Quaternion.identity);
                    }
                }
                break;
            case Bullets.Triangle:
                if (index == 2)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        soundManager.instance.PlaySingle(shootSound);
                        Instantiate(Bullet3, MuzzlePos.position, Quaternion.identity);
                    }
                }
                break;
        }
    }
    public void SetState(int state)
    {
        switch (state)
        {
            case 0:
                bulletState = Bullets.Cross;
                break;
            case 1:
                bulletState = Bullets.Square;
                break;
            case 2:
                bulletState = Bullets.Triangle;
                break;
        }
    }
    public int setOne(int n)
    {
        if (n < 2)
        {
            n++;
        }
        return n;
    }
    public int setTwo(int n)
    {
        if (n > 0)
        {
            n--;
        }
        return n;
    }

}
