using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public static GameManager instance;

    public int coin;
    public Text coin_Text;

    public bool SS = false;

    private void Awake()
    {
        if (instance != this && instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null && SS)
        {
            StartCoroutine(FindPlayer());
            if(player != null)
            {
                SS = false;
            }
        }

        coin_Text.text = coin.ToString();
        GameOver();
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
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("게임오버");
            DataManager.instance.playerData.coin += coin;
            DataManager.instance.SaveData();
            SceneManager.LoadScene("Main");
            MouseControll.instance.unLock();
            SS = false;
        }

    }

    IEnumerator FindPlayer()
    {

        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.GetComponent<Player>();
        }

        GameObject coin_textObj = GameObject.Find("Coin_text");
        if (coin_textObj != null)
        {
            coin_Text = coin_textObj.GetComponent<Text>();
        }
        DataManager.instance.LoadData();
        yield return null;

    }
}
