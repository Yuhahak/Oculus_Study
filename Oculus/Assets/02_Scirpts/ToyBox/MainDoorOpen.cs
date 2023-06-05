using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorOpen : MonoBehaviour
{

    public Animator anim;
    public PlayerAudio playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key2"))
        {
            anim.SetTrigger("MainDoorOpen");
            playerAudio.Play(PlayerAudio.AudioType.MainDoorOpen, true);
            playerAudio.Play(PlayerAudio.AudioType.Clear, true);

        }
    }
}
