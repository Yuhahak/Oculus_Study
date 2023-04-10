using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class OculusCon : MonoBehaviour
{
    public OVRInput.Controller controllerL; //왼손 컨트롤러
    public OVRInput.Controller controllerR; //오른손 컨트롤러

    public Text logText; //출력 메시지

    public GameObject hitL;
    public GameObject hitR;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            if (GameObject.FindGameObjectWithTag("Video"))
            {
                if (GameObject.FindGameObjectWithTag("Video").GetComponent<VideoPlayer>().isPlaying)
                {
                    GameObject.FindGameObjectWithTag("Video").GetComponent<VideoPlayer>().Pause();
                }
                else
                {
                    GameObject.FindGameObjectWithTag("Video").GetComponent<VideoPlayer>().Play();

                }
            }
        }




        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            logText.text = ("왼손 트리거");


            /*if (hitL)
            {
                if (hitL.GetComponent<Chest>())
                {
                    hitL.GetComponent<Chest>().ChestAnimUpdate();
                }
            }

            /*switch(hitL.transform.name)
            {
                case "Treasure_Chest":
                    {
                        hitL.GetComponent<Chest>().ChestAnimUpdate();
                        break;
                    }
            }*/
            //"Video"라는 태그를 가진 오브젝트가 있다면
            
        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            logText.text = ("오른손 트리거");

            if (hitR)
            {
                if (hitR.GetComponent<Chest>())
                {
                    hitR.GetComponent<Chest>().ChestAnimUpdate();
                }
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            logText.text = ("왼손 트리거");
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            logText.text = ("오른손 트리거");
        }

        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            logText.text = pos.ToString();
        }

        if (OVRInput.Get(OVRInput.Touch.SecondaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
            logText.text = pos.ToString();
        }

        //A버튼 (오른손)

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            logText.text = "A버튼";
        }

        //B버튼 (오른손)
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            logText.text = "B버튼";
        }

        //X버튼 (왼손)
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            logText.text = "X버튼";
        }

        //Y버튼 (왼손)
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            logText.text = "Y버튼";
        }

        //스타트 버튼 (왼손)

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            logText.text = "스타트 버튼";
        }
    }

    void VideoStateUpdate()
    {
        if (GameObject.FindGameObjectWithTag("Video"))
        {
            if (GameObject.FindGameObjectWithTag("Video").GetComponent<VideoPlayer>().isPlaying)
            {
                GameObject.FindGameObjectWithTag("Video").GetComponent<VideoPlayer>().Pause();
            }
            else
            {
                GameObject.FindGameObjectWithTag("Video").GetComponent<VideoPlayer>().Play();

            }
        }
    }
}
