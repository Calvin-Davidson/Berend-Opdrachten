using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasShowAndHide : MonoBehaviour
{
    private Canvas _canvas;

    private void Awake()
    {
        _canvas = GetComponent<Canvas>();
        if (_canvas == null)
        {
            this.enabled = false;
            Debug.LogError("Canvas not found!");
        }
    }

    public void ShowCanvas()
    {
        _canvas.enabled = true;
    }

    public void HideCanvas()
    {
        _canvas.enabled = false;
    }
}
