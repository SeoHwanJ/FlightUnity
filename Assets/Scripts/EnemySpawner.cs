using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;
    private float[] arrPosX = {-1.8f, -0.9f, 0, 0.9f, 1.8f};


    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
       StartEnemyRoutine();
    }

    void StartEnemyRoutine()
    {
        StartCoroutine(enemyRoutine());
    }
    IEnumerator enemyRoutine()
    {
        float moveSpeed = 5f;
        int enemyIndex =0;
        int spawnCount =0;
        yield return new WaitForSeconds(3f);
        while(true)
        {
            foreach (float posX in arrPosX)
            {
                int index = Random.Range(0, enemies.Length);
                SpawnEnemy(posX, enemyIndex,moveSpeed);
            }
            spawnCount++;
            if(spawnCount % 10 ==0)
            {
                enemyIndex++;
                moveSpeed += 2f;
            }

            yield return new WaitForSeconds(spawnInterval);
        }
        
    }


    void SpawnEnemy(float posX, int index,float moveSpeed)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
        if(Random.Range(0, 5)==0)
        {
            index++;
        }
        if(index >= enemies.Length)
        {
            index--;
        }
        GameObject enemy = Instantiate(enemies[index], spawnPos, Quaternion.identity);
        enemy.GetComponent<Enemy>().SetMoveSpeed(moveSpeed);
    }
}