using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayingCurrentWeoapon : MonoBehaviour
{
    public enum BulletsTexture { Square, Triangle, Cross }
    public BulletsTexture textureState;
    public RawImage image;
    //public Transform MuzzlePos;
    public Texture Bullet1, Bullet2, Bullet3;
    int index;

    //public AudioClip shootSound;

    public void Start()
    {
        textureState = BulletsTexture.Cross;
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
        selectBullet(textureState);
    }
    public void selectBullet(BulletsTexture n)
    {
        switch (n)
        {
            case BulletsTexture.Cross:
                if (index == 0)
                {

                    image.texture = Bullet1;
                    
                }
                break;
            case BulletsTexture.Square:
                if (index == 1)
                {
                    image.texture = Bullet2;
                }
                break;
            case BulletsTexture.Triangle:
                if (index == 2)
                {
                    image.texture = Bullet3;
                }
                break;
        }
    }
    public void SetState(int state)
    {
        switch (state)
        {
            case 0:
                textureState = BulletsTexture.Cross;
                break;
            case 1:
                textureState = BulletsTexture.Square;
                break;
            case 2:
                textureState = BulletsTexture.Triangle;
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
