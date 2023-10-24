using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject slash;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            onSlash();
        }
    }

    void onSlash()
    {
        slash.SetActive(true);
        Invoke("offSlash", 1f);
    }

    void offSlash()
    {
        slash.SetActive(false);
    }
}
