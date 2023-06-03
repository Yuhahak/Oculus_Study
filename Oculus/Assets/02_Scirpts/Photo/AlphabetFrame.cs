using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetFrame : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject J;
    public GameObject J_;


    private void Update()
    {
        switch (collidedObjectName)
        {
            case "J":
                Destroy(J);
                J_.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
