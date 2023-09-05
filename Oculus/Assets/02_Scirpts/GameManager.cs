using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public static GameManager instance;

    public int coin;
    public Text coin_Text;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coin_Text.text = coin.ToString();

        if (player.hp <= 0)
        {
            GameOver();
        }
    }

    public void ApplyDamageToLastSpawnedEnemy(float damage)
    {
        SpawnEnemy spawnEnemy = FindObjectOfType<SpawnEnemy>();
        if (spawnEnemy != null)
        {
            spawnEnemy.ApplyDamageToLastSpawnedEnemy(damage);
        }
    }

    void GameOver()
    {
        // 게임오버시
        Debug.Log("게임오버");
    }
}
