using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OculusLaser : MonoBehaviour
{
    public enum HandType
    {
        LeftHand, RightHand
    }
    public HandType handType; //�޼� ������ ����

    public OculusCon player; //��ŧ���� �÷��̾�

    private LineRenderer line; //���η�����
    private float maxDistance = 3f; //������ �ִ� �Ÿ�
    public GameObject hitObject; //�������� �浹�� ��ü -> �������� ������ ��ü
    // Start is called before the first frame update
    void Start()
    {
        //�� ��ũ��Ʈ ������ ������Ʈ���� LineRenderer��� ������Ʈ�� ã�Ƽ� line�� �����Ѵ�.
        line = GetComponent<LineRenderer>();

        line.SetPosition(0, Vector3.zero); //������ ������ ���� (������, �������� ��ġ)

        line.SetPosition(1, transform.forward * maxDistance); //������ ������ ���� ���� (������, �������� ��ġ)
    }

    // Update is called once per frame
    void Update()
    {
        ////�� ��ũ��Ʈ ������ ������Ʈ���� LineRenderer��� ������Ʈ�� ã�Ƽ� line�� �����Ѵ�.
        //line = GetComponent<LineRenderer>();

        //line.SetPosition(0, transform.position); //������ ������ ���� (������, �������� ��ġ)

        //line.SetPosition(1, transform.forward * maxDistance); //������ ������ ���� ���� (������, �������� ��ġ)
        //(0, 0, 1) * 30.0f = (0, 0, 30) -> ������ ���� ����


        RaycastHit hit;//�浹ü ����

        //���࿡ ���̰� �浹�Ѵٸ�(���� �߻� ��ġ, ���� �߻� ����, �浹 ����, ������ ����)
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            //���̰� �浹�� ��ü�� hitObject�� ��´�.
            hitObject = hit.transform.gameObject;
        }

        //���̰� �浹���� �ʴ´ٸ�
        else
        {
            //hitObject�� ����.
            hitObject = null;
        }

        switch (handType)
        {
            //�޼��� ���
            case HandType.LeftHand:
                {
                    //�÷��̾��� �޼տ� �浹ü ������ ��´�.
                    player.grabL = hitObject;
                    break;
                }

            //�������� ���
            case HandType.RightHand:
                {
                    //�÷��̾��� �����տ� �浹ü ������ ��´�.
                    player.grabR = hitObject;
                    break;
                }
        }

        if (hitObject)
        {
            switch (hitObject.transform.name)
            {
                case "KeyPad_Col":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {
                        Keypad.s.KeyPad_Col_Open = true;
                        break;
                    }
                    break;
                case "KeyPad_1":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {
                        KeyPadOpen.instance.Ans.text += 1.ToString();
                        break;
                    }
                    break;
                case "KeyPad_2":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {

                    }
                    break;
                case "KeyPad_3":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {

                    }
                    break;
                case "KeyPad_4":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {

                    }
                    break;
                case "KeyPad_5":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {

                    }
                    break;
                case "KeyPad_6":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {

                    }
                    break;
                case "KeyPad_7":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {

                    }
                    break;
                case "KeyPad_8":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {

                    }
                    break;
                case "KeyPad_9":
                    if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                    {

                    }
                    break;


            }
        }
        

    }
}
