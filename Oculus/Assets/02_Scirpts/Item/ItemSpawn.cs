using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject itemPrefab;



    // Start is called before the first frame update
    void Start()
    {       
        itemPrefab.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropItem(float x, float y, float z)
    {
        //itemPrefab�� ��ġ ����
        itemPrefab.SetActive(true);
    }
    
    //���Ͱ� ���� ������(����) ������ ������ ȣ���Ͽ�����
}
