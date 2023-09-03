using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform[] spawnPos;
    public GameObject enemyOne;
    private List<GameObject> spawnedEnemies = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy_());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy_()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            Transform spawnPoint = spawnPos[Random.Range(0, 3)];
            GameObject newEnemy = Instantiate(enemyOne, spawnPoint.position, Quaternion.identity);
            spawnedEnemies.Add(newEnemy);
        }
    }

    public void ApplyDamageToLastSpawnedEnemy(float damage)
    {
        if (spawnedEnemies.Count > 0)
        {
            GameObject lastEnemy = spawnedEnemies[spawnedEnemies.Count - 1];
            EnemyOne enemyScript = lastEnemy.GetComponent<EnemyOne>();
            if (enemyScript != null)
            {
                enemyScript.EnemyTakeDamage(damage);
            }
        }
    }
}
