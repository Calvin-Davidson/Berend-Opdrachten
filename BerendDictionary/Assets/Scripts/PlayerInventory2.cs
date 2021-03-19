using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Wapen
{
    Handgun,
    Rifle,
    SniperRifle,
}
public class PlayerInventory2 : MonoBehaviour
{
    public Dictionary<Wapen, int> wapenMunities = new Dictionary<Wapen, int>();
    public Wapen currentItem;

    private void Awake()
    {
        wapenMunities.Add(Wapen.Handgun, 5);
        wapenMunities.Add(Wapen.Rifle, 4);
        wapenMunities.Add(Wapen.SniperRifle, 1);

        currentItem = Wapen.Handgun;
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
