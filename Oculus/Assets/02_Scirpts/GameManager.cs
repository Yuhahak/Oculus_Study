using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.hp <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // 게임오버시
        Debug.Log("게임오버");
    }
}
