using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;


    [Header("Stat")]
    private float maxHp;
    public float hp;
    public float moveSpeed;
    public float damage;

    private void Awake()
    {
        Player.instance = this;
        maxHp = hp;
    }


    public void Damaged(float EnemyDamage)
    {
        hp -= EnemyDamage;
        if (hp < 0)
        {
            hp = 0;
        }
    }

    public void Heal(float Heal)
    {
        hp += Heal;
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }
}
