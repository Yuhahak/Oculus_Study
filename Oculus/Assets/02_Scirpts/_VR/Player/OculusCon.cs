using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class OculusCon : MonoBehaviour
{
    [HideInInspector] public OVRInput.Controller controllerL; //�޼� ��Ʈ�ѷ�
    [HideInInspector] public OVRInput.Controller controllerR; //������ ��Ʈ�ѷ�

    [HideInInspector] public OVRGrabber grabberL;
    [HideInInspector] public OVRGrabber grabberR;

    public GameObject grabL;
    public GameObject grabR;

    public GameObject Player;
    public PlayerSkill skill;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        GameObject skillObject = GameObject.Find("PlayerManager");
        if (skillObject != null)
        {
            skill = skillObject.GetComponent<PlayerSkill>();
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))  //������ Ʈ���Ÿ� ������ ��
        {
            Player.GetComponent<SS_Gun>().FireR();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Player.GetComponent<SS_Gun>().FireL();
        }

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            skill.OnSkill();

        }


        //if(grabberL.m_grabbedObj)
        //{
        //    grabL = grabberL.m_grabbedObj.gameObject;
        //}
        //else
        //{
        //    grabL = null;
        //}
        //if(grabberR.m_grabbedObj)
        //{
        //    grabR = grabberR.m_grabbedObj.gameObject;
        //}
        //else
        //{
        //    grabR = null;
        //}



        //    if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        //    {



        //    }
        //    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        //    {
        //        if (grabR)
        //        {
        //            switch(grabR.transform.name)
        //            {
        //                case "Gun":
        //                    {
        //                        grabR.GetComponent<BulletCreate>().CheckGun();
        //                        break;
        //                    }
        //                case "Game_Start":
        //                    {
        //                        UnityEngine.SceneManagement.SceneManager.LoadScene("Main_Scene");
        //                        break;
        //                    }
        //                case "KeyPad_Col":
        //                    {
        //                        Keypad.s.KeyPad_Col_Open = true;
        //                        break;
        //                    }
        //                case "KeyPad_1":
        //                    KeyPadOpen.instance.Ans.text += "1";
        //                    break;

        //            }
        //        }
        //    }
        //    if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        //    {
        //    }

        //    if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        //    {
        //    }

        //    if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        //    {
        //        Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        //    }

        //    if (OVRInput.Get(OVRInput.Touch.SecondaryThumbstick))
        //    {
        //        Vector2 pos = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        //    }

        //    //A��ư (������)

        //    if (OVRInput.GetDown(OVRInput.Button.One))
        //    {
        //    }

        //    //B��ư (������)
        //    if (OVRInput.GetDown(OVRInput.Button.Two))
        //    {
        //    }

        //    //X��ư (�޼�)
        //    if (OVRInput.GetDown(OVRInput.Button.Three))
        //    {
        //    }

        //    //Y��ư (�޼�)
        //    if (OVRInput.GetDown(OVRInput.Button.Four))
        //    {
        //    }

        //    //��ŸƮ ��ư (�޼�)

        //    if (OVRInput.GetDown(OVRInput.Button.Start))
        //    {
        //    }
        //}

    }
}