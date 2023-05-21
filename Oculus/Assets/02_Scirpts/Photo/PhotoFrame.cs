using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoFrame : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject Photo1;
    public GameObject PhotoFrame1;

    private void Update()
    {
        switch (collidedObjectName)
        {
            case "Photo1":
                Destroy(Photo1);
                PhotoFrame1.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
