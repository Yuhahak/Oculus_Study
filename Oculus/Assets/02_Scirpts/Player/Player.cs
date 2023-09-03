using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;


    [Header("Stat")]
    public float hp;
    public float moveSpeed;
    public float damage;

    private void Awake()
    {
        Player.instance = this;
    }


    public void Damaged(float EnemyDamage)
    {
        hp -= EnemyDamage;
    }
}
