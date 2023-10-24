using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeClone : MonoBehaviour
{
    private EnemyOne enemyOne;
    public GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        enemyOne = GetComponent<EnemyOne>();
    }

    // Update is called once per frame
    void Update()
    {
        Clone();
    }

    public void Clone()
    {
        if(Input.GetKeyDown(KeyCode.K)) //enemyOne.currentHp <= 0f && !enemyOne.isDead
        {
            GameObject go = Instantiate(clone);
            go.transform.position = transform.position;
            go.transform.localScale = transform.localScale * 0.5f ;

            GameObject go1 = Instantiate(clone);
            go1.transform.position = transform.position;
            go1.transform.localScale = transform.localScale * 0.5f ;
        }
    }
}
