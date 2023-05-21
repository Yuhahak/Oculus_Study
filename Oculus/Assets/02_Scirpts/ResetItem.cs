using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetItem : MonoBehaviour
{
    private Vector3 originalPosition;
    private bool isReturning;

    private void Start()
    {
        originalPosition = transform.position;
        isReturning = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isReturning = true;
            ReturnToOriginalPosition();
        }
    }

    private void Update()
    {
        if (isReturning)
        {
            ReturnToOriginalPosition();
        }
    }

    private void ReturnToOriginalPosition()
    {
        transform.position = originalPosition;
        isReturning = false;
    }
}
