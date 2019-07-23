using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxBullet : MonoBehaviour
{
    public AudioClip death;
    public PoolManager poolManager;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Box"))
        {
            GameManager.scoreCount++;
            soundManager.instance.PlaySingle(death);
            poolManager.EnemyDead3(this.gameObject);
           // Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            GameManager.PlayerHealth--;
            Debug.Log(GameManager.PlayerHealth);
            //Instantiate(effect, this.transform.position, Quaternion.identity);
            //Destroy(gameObject);
            soundManager.instance.PlaySingle(death);
            poolManager.EnemyDead3(this.gameObject);

        }
    }
}
