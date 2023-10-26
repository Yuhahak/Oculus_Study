using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //GameManager.instance.audioManager.Play(AudioManager.AudioType.Shoot, true);

    [SerializeField] AudioSource shootSound = null;
    [SerializeField] AudioSource snowAoeSound = null;
    [SerializeField] AudioSource shopOpen = null;
    [SerializeField] AudioSource shopClose = null;
    [SerializeField] AudioSource statUp = null;
    [SerializeField] AudioSource statReset = null;


    public enum AudioType
    {
        Shoot, SnowAoe, ShopOpen, ShopClose, StatUp, StatReset
    }


    public void Play(AudioType audioType, bool playState)
    {
        AudioSource audioSource = null;
        switch (audioType)
        {
            case AudioType.Shoot:
                audioSource = shootSound;
                break;
            case AudioType.SnowAoe:
                audioSource = snowAoeSound;
                break;
            case AudioType.ShopOpen:
                audioSource = shopOpen;
                break;
            case AudioType.ShopClose:
                audioSource = shopClose;
                break;
            case AudioType.StatUp:
                audioSource = statUp;
                break;
            case AudioType.StatReset:
                audioSource = statReset;
                break;
        }
        if (audioSource != null)
        {
            if (playState)
            {
                audioSource.Play();
            }
            else
            {
                audioSource.Stop();
            }
        }
    }
}
