using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyBoxOpen : MonoBehaviour
{
    public GameObject ToyBox;
    public GameObject ToyBoxKey;
    private bool ToyBoxOpenCheck = false;
    public Transform targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BoxOpen();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            ToastManager.Instance.showMessage("Open ToyBox", 1f);
            ToyBoxOpenCheck = true;
            ToyBoxKey.transform.position = targetPosition.position;

        }
    }

    private void BoxOpen()
    {
        if (ToyBoxOpenCheck)
        {
            ToyBoxKey.GetComponent<Animator>().SetTrigger("ToyBoxKey");
            Invoke("BoxOpenAnim", 1f);
        }
    }

    void BoxOpenAnim()
    {
        ToyBox.GetComponent<Animator>().SetTrigger("ToyBoxOpen");
    }
}
