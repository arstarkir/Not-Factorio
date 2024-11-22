using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemTest
{
    public int itemId;
    public string itemName;
    public int itemQuantity;
    public int itemMaxQuantity;
    public GameObject itemPrefab;
    public Sprite itemSprite;

    public InventoryItemTest(int itemId, string itemName, int itemQuantity, int itemMaxQuantity, GameObject itemPrefab, Sprite itemSprite)
    {
        this.itemId = itemId;
        this.itemName = itemName;
        this.itemQuantity = itemQuantity;
        this.itemMaxQuantity = itemMaxQuantity;
        this.itemPrefab = itemPrefab;
        this.itemSprite = itemSprite;
    }
}
