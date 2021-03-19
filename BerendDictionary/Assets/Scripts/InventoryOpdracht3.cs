using System;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Rock,
    Wood,
    Flint,
    Fiber,
}


public class InventoryOpdracht3 : MonoBehaviour
{
    private Dictionary<ItemType, List<String>> Inventory = new Dictionary<ItemType, List<String>>();

    private void Awake()
    {
        Inventory.Add(ItemType.Rock, new List<string>());
        Inventory.Add(ItemType.Wood, new List<string>());
        Inventory.Add(ItemType.Flint, new List<string>());
        Inventory.Add(ItemType.Fiber, new List<string>());
    }

    public void AddItem(ItemType type, String item)
    {
        Inventory[type].Add(item);
    }

    public void RemoveItem(ItemType type, String item)
    {
        Inventory[type].Remove(item);        
    }

    public int GetItemCount(ItemType type)
    {
        return Inventory[type].Count;
    }
}