using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New item", menuName = "New Item/item")]

public class Item : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public Sprite itemImage;
    public GameObject itemPrefab;

    public static Item instance;

    public string Type;

    private void Awake()
    {
        instance = this;
    }
    public enum ItemType
    {
        Used,
        ETC
    }
}