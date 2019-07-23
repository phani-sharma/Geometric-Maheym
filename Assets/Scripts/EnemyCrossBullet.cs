using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrossBullet : MonoBehaviour
{
    public PoolManager poolManager;
    public AudioClip death;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cross"))
        {
            GameManager.scoreCount++;
            soundManager.instance.PlaySingle(death);
            //Destroy(gameObject);
            poolManager.EnemyDead2(this.gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            GameManager.PlayerHealth--;
            Debug.Log(GameManager.PlayerHealth);
            //Instantiate(effect, this.transform.position, Quaternion.identity);
            //Destroy(gameObject);
            soundManager.instance.PlaySingle(death);
            poolManager.EnemyDead2(this.gameObject);

        }
    }

}
