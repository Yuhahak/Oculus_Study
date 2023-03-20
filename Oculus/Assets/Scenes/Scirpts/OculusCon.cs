using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OculusCon : MonoBehaviour
{
    public OVRInput.Controller controllerL; //왼손 컨트롤러
    public OVRInput.Controller controllerR; //오른손 컨트롤러

    public Text logText; //출력 메시지


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            logText.text = ("왼손 트리거");
        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            logText.text = ("오른손 트리거");
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
}
