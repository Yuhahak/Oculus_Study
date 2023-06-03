using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U_Frame : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject U;
    public GameObject U_;


    private void Update()
    {
        switch (collidedObjectName)
        {
            case "U":
                Destroy(U);
                U_.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
