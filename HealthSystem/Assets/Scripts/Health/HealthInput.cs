using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthInput : MonoBehaviour
{
    [SerializeField] private Health health;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            health.TakeDamage(10);
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            health.ReceiveHealth(10);
        }
    }
}
