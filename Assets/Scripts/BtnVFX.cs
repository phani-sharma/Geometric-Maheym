using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnVFX : MonoBehaviour
{
    public AudioSource VFX;
    public AudioClip highligh;
    public AudioClip clicked;

    public void hoverMouse()
    {
        VFX.PlayOneShot(highligh);
    }

    public void Clicked()
    {
        VFX.PlayOneShot(clicked);
    }
}
