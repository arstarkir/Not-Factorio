using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityInventoryTest : MonoBehaviour
{
    public List<InventoryItemTest> inventoryItems = new List<InventoryItemTest>();

    public bool AddItem(InventoryItemTest inventoryItem)
    {
        foreach (var item in inventoryItems)
        {
            if(item.itemId == inventoryItem.itemId)
            {
                if(item.itemQuantity + 1 <= item.itemMaxQuantity)
                    item.itemQuantity++;
                else
                    return false;
            }
        }

        inventoryItems.Add(inventoryItem);
        return true;
    }
}
