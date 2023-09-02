using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyOne : EnemyBase
{
    public static EnemyOne instance;

    [Header("Setting")]
    public Transform target;
    NavMeshAgent nav;


    // Start is called before the first frame update
    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        EnemyOne.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(target.position);
    }

    public void EnemyTakeDamage(int PlusDamage)
    {
        enemy_Hp -= (player.damage + PlusDamage);
    }

}
