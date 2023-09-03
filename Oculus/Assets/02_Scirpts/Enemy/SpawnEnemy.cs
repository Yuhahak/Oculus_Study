using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform[] spawnPos;

    public GameObject enemyOne;

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

            Instantiate(enemyOne, spawnPos[Random.Range(0, 3)]);
        }
    }
}
