using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    public GameObject lineAxis;
    public GameObject line;


    public GameObject hitObject;
    private float maxDistance = 30.0f;
    public Material laserMat;
    [SerializeField]
    private float dist;

    public Text text;

    Button buttonUI;
    // Start is called before the first frame update
    void Start()
    {
        lineAxis = new GameObject();
        lineAxis.name = "LineAxis";
        lineAxis.transform.parent = transform;
        line = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        line.transform.localPosition = transform.localPosition;
        line.transform.localScale = new Vector3(0.01f, 0.5f, 0.01f);
        line.transform.parent = lineAxis.transform;
        line.transform.rotation = Quaternion.Euler(90.0f, 0, 0);
        line.transform.localPosition = new Vector3(line.transform.localPosition.x, line.transform.localPosition.y, line.transform.localPosition.z + line.transform.localScale.y);
        line.GetComponent<Renderer>().material = laserMat;
        line.GetComponent<CapsuleCollider>().enabled = false;
        text.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 9;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, layerMask))
        {
            dist = Vector3.Distance(transform.position, hit.point);
            lineAxis.transform.localScale = new Vector3(lineAxis.transform.localScale.x, lineAxis.transform.localScale.y, dist);
            hitObject = hit.transform.gameObject;

            if (hit.transform.GetComponent<RaycastButton>())
            {
                hit.transform.GetComponent<RaycastButton>().RaycastButtonOn();
            }
        }
        else
        {
            lineAxis.transform.localScale = new Vector3(lineAxis.transform.localScale.x, lineAxis.transform.localScale.y, maxDistance);
        }



        check();
        KeyPad();
    }

    void check()
    {
        if (hitObject != null)
        {
            switch (hitObject.name)
            {
                case "KeyPad_Col":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        Keypad.s.KeyPad_Col_Open = true;

                    }
                    break;

            }
        }
    }

    void KeyPad()
    {
        if (hitObject != null)
        {
            switch (hitObject.name)
            {
                case "KeyPad1":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 1.ToString();
                        }

                    }
                    break;
                case "KeyPad2":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 2.ToString();
                        }

                    }
                    break;
                case "KeyPad3":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 3.ToString();
                        }

                    }
                    break;
                case "KeyPad4":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 4.ToString();
                        }

                    }
                    break;
                case "KeyPad5":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 5.ToString();
                        }

                    }
                    break;
                case "KeyPad6":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 6.ToString();
                        }

                    }
                    break;
                case "KeyPad7":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 7.ToString();
                        }

                    }
                    break;
                case "KeyPad8":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 8.ToString();
                        }

                    }
                    break;
                case "KeyPad9":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 9.ToString();
                        }

                    }
                    break;
                case "KeyPad0":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text.Length < 4)
                        {
                            text.text += 0.ToString();
                        }

                    }
                    break;
                case "KeyPadOk":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        if (text.text == "1234")
                        {
                            text.text = "";

                            text.text += "Correct";
                        }
                        else
                        {
                            text.text = "";

                            text.text += "Wrong";
                        }

                    }
                    break;
                case "KeyPadBack":
                    if (OVRInput.GetDown(OVRInput.Button.One))
                    {
                        
                        
                            text.text = "" ;
                        

                    }
                    break;

            }
        }
    }
}
