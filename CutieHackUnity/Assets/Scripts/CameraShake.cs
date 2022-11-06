using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Transform transform;

    public float shakeDuration = 0f;

    public float shakeAmount = 0.2f;
    public float decreaseFactor = 1.0f;
    Vector3 originalPos;

    void Awake() 
    {
        transform = GetComponent<Transform>();
    }

    void OnEnable()
    {
        originalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(shakeDuration > 0) {
            Vector3 newPos = originalPos + Random.insideUnitSphere * shakeAmount;
            //newPos.x = Mathf.Clamp(newPos.x, newPos.x - 1, newPos.x + 1);
            newPos.y = Mathf.Clamp(newPos.y, -1, 1);
            newPos.z = -10f;
            transform.localPosition = newPos;

            shakeDuration -= Time.deltaTime * decreaseFactor;
        } else {
            shakeDuration = 0f;
            transform.localPosition = originalPos;
        }
    }

    public void Shake(float seconds) 
    {
        this.shakeDuration = seconds;
    }
}
