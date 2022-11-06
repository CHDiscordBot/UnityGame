using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTriggerScript : MonoBehaviour
{
    private CameraShake cShake;

    // Start is called before the first frame update
    void Start()
    {
        cShake = GameObject.FindObjectOfType<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
            cShake.Shake(3f);
    }
}
