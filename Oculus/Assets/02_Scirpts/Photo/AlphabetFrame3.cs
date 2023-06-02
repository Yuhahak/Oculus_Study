using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetFrame3 : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject Alphabet;
    public GameObject AlphabetFrame1;

    private void Update()
    {
        switch (collidedObjectName)
        {
            case "I":
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
