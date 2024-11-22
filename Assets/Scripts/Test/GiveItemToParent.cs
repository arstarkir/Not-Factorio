using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveItemToParent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 13)
        {
            if(transform.parent.TryGetComponent<EntityInventoryTest>(out EntityInventoryTest entityInventory))
            {
                // InventoryItemTest inventoryItem = ItemList.instance.GetItemByID(other.GetComponent<ItemTest>().itemId);
                // entityInventory.AddItem(inventoryItem);
                Destroy(other.gameObject);
            }
        }
    }
}
