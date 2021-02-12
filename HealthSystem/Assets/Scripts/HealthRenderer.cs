using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRenderer : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private Health health;


    private void Awake()
    {
        health.onTakeDamage.AddListener(UpdateUi);
        health.onRegenEvent.AddListener(UpdateUi);
    }

    public void UpdateUi()
    {
        
    }
}
