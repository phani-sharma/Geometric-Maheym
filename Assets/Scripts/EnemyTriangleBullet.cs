using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriangleBullet : MonoBehaviour
{
    public PoolManager poolManager;
    public AudioClip death;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Triangle"))
        {
            GameManager.scoreCount++;
            // Destroy(gameObject);
            soundManager.instance.PlaySingle(death);
            poolManager.Enemy1Dead(this.gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            GameManager.PlayerHealth--;
            Debug.Log(GameManager.PlayerHealth);
            //Instantiate(effect, this.transform.position, Quaternion.identity);
            //Destroy(gameObject);
            soundManager.instance.PlaySingle(death);
            poolManager.Enemy1Dead(this.gameObject);

        }
    }
}
