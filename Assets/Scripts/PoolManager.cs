using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject Enemy1;//triangle
    public GameObject Enemy2;//cross
    public GameObject Enemy3;//box

    public int enemy1Count;
    public int enemy2Count;
    public int enemy3Count;

    public Queue<GameObject> enemy1Queue;
    public Queue<GameObject> enemy2Queue;
    public Queue<GameObject> enemy3Queue;


    // Start is called before the first frame update
    void Start()
    {

        enemy1Queue = new Queue<GameObject>();
        enemy2Queue = new Queue<GameObject>();
        enemy3Queue = new Queue<GameObject>();


     for (int i=0;i<enemy1Count;i++)
        {
            GameObject enemy1Instance = Instantiate(Enemy1);
            enemy1Instance.SetActive(false);
            enemy1Queue.Enqueue(enemy1Instance);
        }
     for (int i = 0; i < enemy2Count; i++)
        {
            GameObject enemy2Instance = Instantiate(Enemy2);
            enemy2Instance.SetActive(false);
            enemy2Queue.Enqueue(enemy2Instance);
        }
      for (int i = 0; i < enemy3Count; i++)
        {
            GameObject enemy3Instance = Instantiate(Enemy3);
            enemy3Instance.SetActive(false);
            enemy3Queue.Enqueue(enemy3Instance);
        }

    }

    public GameObject SpawnEnemy1()
    {
        GameObject e1i = enemy1Queue.Dequeue();
        e1i.SetActive(true);
        return e1i;
    }

    public GameObject SpawnEnemy2()
    {
        GameObject e2i = enemy2Queue.Dequeue();
        e2i.SetActive(true);
        return e2i;
    }

    public GameObject SpawnEnemy3()
    {
        GameObject e3i = enemy3Queue.Dequeue();
        e3i.SetActive(true);
        return e3i;
    }

    public void Enemy1Dead(GameObject E1)
    {
        E1.SetActive(false);
        enemy1Queue.Enqueue(E1);
    }

    public void EnemyDead2(GameObject E2)
    {
        E2.SetActive(false);
        enemy2Queue.Enqueue(E2);
    }

    public void EnemyDead3(GameObject E3)
    {
        E3.SetActive(false);
        enemy3Queue.Enqueue(E3);
    }
}
