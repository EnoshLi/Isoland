using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : Singleton<InventoryManager>
{
    public ItemDataListSO itemDataListSO;
    
    [SerializeField]
    private List<ItemName> itemList = new();
    public void AddItem(ItemName itemName)
    {
        if (!itemList.Contains(itemName))
        {
            itemList.Add(itemName);
            //TODO:UI显示
        }
    }
}
