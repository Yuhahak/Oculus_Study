using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    // playerAudio.Play(PlayerAudio.AudioType.Attack, true); 예시
    // playerAudio.OtherPlay(PlayerAudio.OtherAudioType.BossBGM, true); 예시

    [SerializeField] AudioSource mainEffectAudioSouce;
    [Header("Audio Sources")]


    [SerializeField] AudioSource DrawerOpenSound = null;
    [SerializeField] AudioSource AlphabetSound = null;
    [SerializeField] AudioSource ClearSound = null;
    [SerializeField] AudioSource GunSound = null;
    [SerializeField] AudioSource MainDoorOpenSound = null;
    [SerializeField] AudioSource ResetSound = null;
    [SerializeField] AudioSource ButtonSound = null;


    public enum AudioType
    {
        DrawerOpen, Alphabet, Clear, Gun, MainDoorOpen, Reset, Button
    }

    public void Play(AudioType audioType, bool playState)
    {
        AudioSource audioSource = null;
        switch (audioType)
        {
            case AudioType.DrawerOpen:
                audioSource = DrawerOpenSound;
                break;
            case AudioType.Alphabet:
                audioSource = AlphabetSound;
                break;
            case AudioType.Clear:
                audioSource = ClearSound;
                break;
            case AudioType.Gun:
                audioSource = GunSound;
                break;
            case AudioType.MainDoorOpen:
                audioSource = MainDoorOpenSound;
                break;
            case AudioType.Reset:
                audioSource = ResetSound;
                break;
            case AudioType.Button:
                audioSource = ButtonSound;
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
