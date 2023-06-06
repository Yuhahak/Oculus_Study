using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;

    public MainPayerAudio MainPayerAudio;

    private void Update()
    {
        Invoke("On1", 5f);
        Invoke("On2", 10f);
        Invoke("FadeIN", 15f);

        Invoke("GoMain", 17f);

    }

    void On1()
    {
        Image1.gameObject.SetActive(false);
        MainPayerAudio.Play(MainPayerAudio.AudioType.Book, true);
    }

    void On2()
    {
        Image2.gameObject.SetActive(false);
        MainPayerAudio.Play(MainPayerAudio.AudioType.Book, true);
    }


    void GoMain()
    {
        MainPayerAudio.Play(MainPayerAudio.AudioType.EndingBGM, false);

        SceneManager.LoadScene("Start_Scene");
    }

    void FadeIN()
    {
        OVRScreenFade.instance.FadeIn2();
    }
}
