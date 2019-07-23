using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public GameObject Enemy1, Enemy2, Enemy3;
    //public GameObject Boss;
    public Vector3 spawnValues;
    public int EnemyCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    int whatToSpawn;


    public PoolManager poolManager;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        //whatToSpawn = Random.Range(0, 4);
        while (true)

        {
            for (int i = 0; i < EnemyCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.z));
                Quaternion spawnRotation = Quaternion.identity;
                whatToSpawn = Random.Range(0, 4);
                switch (whatToSpawn)
                {
                    case 1:
                        GameObject enemy1 = poolManager.SpawnEnemy1();
                        enemy1.transform.position = spawnPosition;
                        enemy1.transform.rotation = Quaternion.identity;
                       // Instantiate(Enemy1, spawnPosition, Quaternion.identity);
                        break;
                    case 2:
                        GameObject enemy2 = poolManager.SpawnEnemy2();
                        enemy2.transform.position = spawnPosition;
                        enemy2.transform.rotation = Quaternion.identity;
                        //Instantiate(Enemy2, spawnPosition, Quaternion.identity);
                        break;
                    case 3:
                        GameObject enemy3 = poolManager.SpawnEnemy3();
                        enemy3.transform.position = spawnPosition;
                        enemy3.transform.rotation = Quaternion.identity;
                        // Instantiate(Enemy3, spawnPosition, Quaternion.identity);
                        break;
                }
               

                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
