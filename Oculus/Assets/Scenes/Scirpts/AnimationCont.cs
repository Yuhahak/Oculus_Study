using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimationCont : MonoBehaviour
{
    public Animator anim;
    public Slider slider;

    [Range(0f, 1f)]
    public float animValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            animValue += Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            animValue -= Time.deltaTime;
        }
        anim.Play("Victory", -1, animValue);
    }
}
