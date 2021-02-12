using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Vector3 _originalPos;

    void Awake()
    {
        _originalPos = transform.localPosition;
    }

    public void ShakeCamera()
    {
        StartCoroutine(shake(0.2f, 0.3f));
    }
    
    private IEnumerator shake (float duration, float amount) {
        float endTime = Time.time + duration;

        while (Time.time < endTime) {
            transform.localPosition = _originalPos + Random.insideUnitSphere * amount;

            duration -= Time.deltaTime;

            yield return null;
        }

        transform.localPosition = _originalPos;
    }
}
