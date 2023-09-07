using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyOne : EnemyBase
{
    public static EnemyOne instance;
    private Rigidbody rigid;
    NavMeshAgent nav;

    [Header("Setting")]
    public Transform target;
    public Image enemy_HpBar;
    public Image enemy_HpBar_Back;
    private float maxHp;
    private float currentHp; // 새로운 변수 추가
    private bool isDead = false;

    private void Start()
    {
        maxHp = enemy_Hp;
        currentHp = enemy_Hp; // 초기 체력 설정
        target = GameObject.FindGameObjectWithTag("Player").transform;
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.GetComponent<Player>();
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        rigid = GetComponent<Rigidbody>();
        EnemyOne.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(target.position);
        nav.speed = enemy_MoveSpeed;
        transform.LookAt(target);

        FreezeVelocity();
        EnmeyUIFollow();

        if (currentHp <= 0f && !isDead)
        {
            EnemyDeath();
        }
    }

    
    public void EnemyTakeDamage(float BulletDamage)
    {
        currentHp -= (player.damage + BulletDamage);
    }

    void FreezeVelocity()
    {
        rigid.angularVelocity = Vector3.zero;
        rigid.velocity = Vector3.zero;
    }


    void EnemyDeath()
    {
        isDead = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        DropItem.instance.RandomItemDrop(new Vector3(transform.position.x, transform.position.y - 0.4f, transform.position.z));
        Destroy(gameObject);
    }

    void EnmeyUIFollow()
    {
        enemy_HpBar.fillAmount = currentHp / maxHp; // 현재 체력 사용
        enemy_HpBar.transform.LookAt(target);
        enemy_HpBar_Back.transform.LookAt(target);
    }

}
