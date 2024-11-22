using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    List<InventoryItemTest> itemsList = new List<InventoryItemTest>(); 
    
    public static ItemList instance;
    private void Awake()
    {
        if(instance != null)
            Destroy(instance);
        if(instance == null)
            instance = this;
    }

    public void GetItemByID(int id)
    {
    }
}
