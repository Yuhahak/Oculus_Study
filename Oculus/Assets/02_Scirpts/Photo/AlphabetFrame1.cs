using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetFrame1 : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject Alphabet;
    public GameObject AlphabetFrame1_;

    private void Update()
    {
        switch (collidedObjectName)
        {
            case "U":
                Destroy(Alphabet);
                AlphabetFrame1_.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
