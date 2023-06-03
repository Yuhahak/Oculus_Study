using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Frame : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject L;
    public GameObject L_;


    private void Update()
    {
        switch (collidedObjectName)
        {
            case "L":
                Destroy(L);
                L_.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
