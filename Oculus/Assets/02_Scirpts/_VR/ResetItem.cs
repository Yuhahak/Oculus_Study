using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetItem : MonoBehaviour
{
    //private Vector3 originalPosition;
    public Transform targetPosition;
    private bool isReturning;
    private Rigidbody rigidbody;

    public PlayerAudio playerAudio;

    private void Start()
    {
        //originalPosition = transform.position;
        isReturning = false;
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isReturning = true;
            ReturnToOriginalPosition();
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
            playerAudio.Play(PlayerAudio.AudioType.Reset, true);
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
        transform.position = targetPosition.position;
        isReturning = false;
    }
}
