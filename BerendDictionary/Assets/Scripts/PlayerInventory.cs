using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Dictionary<string, int> wapenMunities = new Dictionary<string, int>();
    public string currentItem;

    private void Awake()
    {
        wapenMunities.Add("wapen1", 5);
        wapenMunities.Add("wapen2", 4);
        wapenMunities.Add("wapen3", 1);

        currentItem = "wapen1";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (wapenMunities[currentItem] != 0)
            {
                wapenMunities[currentItem] -= 1;
            }
        }
    }
}
