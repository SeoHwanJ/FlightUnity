using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    // Start is called before the first frame update
     private float spawnInterval = 1.5f;

     [SerializeField]
     private Transform spawnTransform;
     [SerializeField]
     private GameObject enemy;
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
        
        int spawnCount =0;
        yield return new WaitForSeconds(3f);
        while(true)
        {
           
            SpawnEnemy(spawnTransform.position.x, moveSpeed);
            
            spawnCount++;
            if(spawnCount % 10 ==0)
            {
                moveSpeed += 2f;
            }
            float randomInterval = Random.Range(0.5f, 1.5f);
            yield return new WaitForSeconds(randomInterval);
        }
        
    }


    void SpawnEnemy(float posX, float moveSpeed)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
        
        GameObject monster = Instantiate(enemy, spawnPos, Quaternion.identity);
        monster.GetComponent<SpiderMonster>().SetMoveSpeed(moveSpeed);
    }
}