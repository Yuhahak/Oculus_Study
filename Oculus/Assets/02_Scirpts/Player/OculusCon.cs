using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class OculusCon : MonoBehaviour
{
    [HideInInspector] public OVRInput.Controller controllerL; //왼손 컨트롤러
    [HideInInspector] public OVRInput.Controller controllerR; //오른손 컨트롤러

    public Text logText; //출력 메시지

    [HideInInspector] public OVRGrabber grabberL;
    [HideInInspector] public OVRGrabber grabberR;

    public GameObject grabL;
    public GameObject grabR;

    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(grabberL.m_grabbedObj)
        {
            grabL = grabberL.m_grabbedObj.gameObject;
        }
        else
        {
            grabL = null;
        }
        if(grabberR.m_grabbedObj)
        {
            grabR = grabberR.m_grabbedObj.gameObject;
        }
        else
        {
            grabR = null;
        }



        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {

           
            
        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            if (grabR)
            {
                switch(grabR.transform.name)
                {
                    case "Gun":
                        {
                            grabR.GetComponent<BulletCreate>().CheckGun();
                            break;
                        }
                    case "Game_Start":
                        {
                            UnityEngine.SceneManagement.SceneManager.LoadScene("Main_Scene");
                            break;
                        }
                    case "KeyPad_Col":
                        {
                            Keypad.s.KeyPad_Col_Open = true;
                            break;
                        }
                    case "KeyPad_1":
                        KeyPadOpen.instance.Ans.text += "1";
                        break;

                }
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
        }

        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        }

        if (OVRInput.Get(OVRInput.Touch.SecondaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        }

        //A버튼 (오른손)

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
        }

        //B버튼 (오른손)
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
        }

        //X버튼 (왼손)
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
        }

        //Y버튼 (왼손)
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
        }

        //스타트 버튼 (왼손)

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
        }
    }

}
