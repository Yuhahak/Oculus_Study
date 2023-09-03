using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyOne enemy = other.gameObject.GetComponent<EnemyOne>();
            if (enemy != null)
            {
                enemy.EnemyTakeDamage(0); // 개별 데미지 값을 전달
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
