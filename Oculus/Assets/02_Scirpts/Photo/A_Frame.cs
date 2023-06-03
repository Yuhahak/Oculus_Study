using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Frame : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject A;
    public GameObject A_;


    private void Update()
    {
        switch (collidedObjectName)
        {
            case "A":
                Destroy(A);
                A_.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
