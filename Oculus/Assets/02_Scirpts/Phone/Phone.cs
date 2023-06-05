using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public PlayerAudio playerAudio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GrabR") || collision.gameObject.CompareTag("GrabL"))
        {
            
            playerAudio.Play(PlayerAudio.AudioType.Phone, false);
            playerAudio.Play(PlayerAudio.AudioType.TakePhone, true);


        }

    }
}
