using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public Player player;

    [Header("Stat")]
    public int enemy_Hp;
    public float enemy_MoveSpeed;
    public int enemy_Damage;
}
