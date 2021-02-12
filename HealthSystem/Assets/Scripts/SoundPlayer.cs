using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _source;

    public void PlaySound()
    {
        _source.Play();
    }
}
