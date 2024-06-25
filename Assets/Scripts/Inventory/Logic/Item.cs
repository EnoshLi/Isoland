using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemName itemName;

    public void ItemClick()
    {
        InventoryManager.Instance.AddItem(itemName);
        gameObject.SetActive(false);
    }
}
