using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetFrame2 : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject Alphabet;
    public GameObject AlphabetFrame1;

    private void Update()
    {
        switch (collidedObjectName)
        {
            case "L":
                Destroy(Alphabet);
                AlphabetFrame1.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
