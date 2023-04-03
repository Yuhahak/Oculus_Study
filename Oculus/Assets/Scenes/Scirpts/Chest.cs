using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Animator chestAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChestAnimUpdate()
    {
        switch (chestAnim.GetInteger("ChestState"))
        {
            case 0:
                chestAnim.SetInteger("ChestState", 1);
                break;
            case 1:
                chestAnim.SetInteger("ChestState", 0);
                break;

        }
    }
}
