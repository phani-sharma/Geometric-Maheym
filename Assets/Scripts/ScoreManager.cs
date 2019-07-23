using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
   // private GameManager manager;
    Text score;

    public void Start()
    {
       // manager = GetComponent<GameManager>();
        score = GetComponent<Text>();
    }
    public void Update()
    {
        score.text = "Enemies Killed :" + GameManager.scoreCount;
    }
}
