using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed;
    private Transform playerPos;
    public GameObject effect;

    public AudioClip PlayerDeath;
   
    public float rotationSpeed;
   // public 

    public void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //Invoke("endScreen", 3f);


    }

    public void Update()
    {
        if (GameManager.PlayerHealth <= 0)
        {
            soundManager.instance.musicSource.Stop();
            soundManager.instance.PlaySingle(PlayerDeath);
            //Time.timeScale = Time.timeScale / 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Invoke("endScreen", 3f);
            
        }

       

        transform.Rotate(0, 0, rotationSpeed);
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

       

    }

   /* public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GameManager.PlayerHealth--;
            Debug.Log(GameManager.PlayerHealth);
            Instantiate(effect, this.transform.position, Quaternion.identity);
            //Destroy(gameObject);
           

        }
        
    }*/

    
}
