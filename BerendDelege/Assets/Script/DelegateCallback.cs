using System;
using UnityEngine;

public class DelegateCallback : MonoBehaviour
{
    private void Start()
    {
        Combine("hoi", " hoe gaat het", print);
    }
    
    private void Combine(String a, String b, Action<String> action)
    {
        action(a + b);
    }
}