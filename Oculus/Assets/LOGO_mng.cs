using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOGO_mng : MonoBehaviour
{
    public Animation animlogo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(logo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator logo()
    {
        animlogo.Play();
        yield return new WaitForSeconds(3);
        Application.LoadLevel(1);
    }
}
