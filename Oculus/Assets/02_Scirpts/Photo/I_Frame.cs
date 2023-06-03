using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_Frame : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject I;
    public GameObject I_;


    private void Update()
    {
        switch (collidedObjectName)
        {
            case "I":
                Destroy(I);
                I_.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
