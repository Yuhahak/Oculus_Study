using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOculusCon : MonoBehaviour
{
    [HideInInspector] public OVRInput.Controller controllerL; //�޼� ��Ʈ�ѷ�
    [HideInInspector] public OVRInput.Controller controllerR; //������ ��Ʈ�ѷ�

    [HideInInspector] public OVRGrabber grabberL;
    [HideInInspector] public OVRGrabber grabberR;

    public GameObject grabL;
    public GameObject grabR;

    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))  //������ Ʈ���Ÿ� ������ ��
        {
            Player.GetComponent<SS_Gun>().FireR();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Player.GetComponent<SS_Gun>().FireL();
        }
    }
}