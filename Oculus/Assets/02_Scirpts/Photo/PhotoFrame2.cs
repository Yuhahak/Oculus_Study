using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoFrame2 : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject Photo2;
    public GameObject PhotoFrame_2;

    private void Update()
    {
        switch (collidedObjectName)
        {
            case "Photo2":
                Destroy(Photo2);
                PhotoFrame_2.gameObject.SetActive(true);
                break;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        // Access the name of the object colliding with this game object
        collidedObjectName = collision.gameObject.name;
    }
}
