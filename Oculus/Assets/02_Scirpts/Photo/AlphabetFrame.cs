using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetFrame : MonoBehaviour
{
    public string collidedObjectName;

    public GameObject J;
    public GameObject J_;
    public GameObject U;
    public GameObject U_;
    public GameObject L;
    public GameObject L_;
    public GameObject I;
    public GameObject I_;
    public GameObject A;
    public GameObject A_;

    private void Update()
    {
        switch (collidedObjectName)
        {
            case "J":
                Destroy(J);
                J_.gameObject.SetActive(true);
                break;
            case "U":
                Destroy(U);
                U_.gameObject.SetActive(true);
                break;
            case "L":
                Destroy(L);
                L_.gameObject.SetActive(true);
                break;
            case "I":
                Destroy(I);
                I_.gameObject.SetActive(true);
                break;
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
