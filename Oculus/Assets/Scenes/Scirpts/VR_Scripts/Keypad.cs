using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public GameObject Password;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") //플레이어와 닿았을때
        {
            Password.gameObject.SetActive(true); //패스워드 UI를 킨다
        }
    }

    private void OnCollisionExit(Collision collision) // 플레이어와 떨어졌을때
    {
        Password.gameObject.SetActive(false); // 패스워드 UI를 끈다

    }
}
