using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public List<GameObject> DropItemList = new List<GameObject>();


    public static DropItem instance;

    private void Awake()
    {
        instance = this;
    }
    public void RandomItemDrop(Vector3 position)
    {
        int r = Random.Range(0 ,DropItemList.Count + 10);
        switch (r)
        {
            case 0:
                Instantiate(DropItemList[0], position, Quaternion.identity);
                break;
            case 1:
                Instantiate(DropItemList[1], position, Quaternion.identity);
                break;

            default:
                break;
        }
    }
}
