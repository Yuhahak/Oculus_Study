using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalReset : MonoBehaviour
{
    private Vector3 originalPosition;
    private Rigidbody rigidbody;

    private void Start()
    {
        originalPosition = transform.position;
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            // 원래 위치로 이동
            transform.position = originalPosition;

            // 운동값 초기화
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}
