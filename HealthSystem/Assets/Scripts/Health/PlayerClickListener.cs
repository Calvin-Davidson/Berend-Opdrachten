using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClickListener : MonoBehaviour
{
    [SerializeField] private Health health;

    private void OnMouseDown()
    {
        health.TakeDamage(10);
    }
}
