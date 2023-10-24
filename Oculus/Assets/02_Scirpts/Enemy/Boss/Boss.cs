using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public static Boss instacne;

    public GameObject slash;
    public GameObject jumpSkill;


    private void Awake()
    {
        instacne = this;
    }

    private void Start()
    {
        InvokeRepeating("onSlash", 1f, 3f);
        InvokeRepeating("onJump", 5f, 10f);
    }

    void onSlash()
    {
        slash.SetActive(true);
        Invoke("offSlash", 0.7f);
    }

    void offSlash()
    {
        slash.SetActive(false);
    }

    void onJump()
    {
        jumpSkill.SetActive(true);
        Invoke("offJump", 2f);
    }

    void offJump()
    {
        jumpSkill.SetActive(false);
    }

}
