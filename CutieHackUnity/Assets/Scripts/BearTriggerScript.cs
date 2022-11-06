using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTriggerScript : MonoBehaviour
{
    private CameraShake cShake;

    public SpriteRenderer bearPrefab;
    public Sprite bearSprite;

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
        if(other.tag == "Player") {
            Vector3 spawnPos = other.GetComponent<Rigidbody2D>().transform.position;
            spawnPos.x -= 1;
            SpriteRenderer instance = Instantiate(bearPrefab, spawnPos, Quaternion.identity);
            instance.flipX = true;
            instance.sprite = bearSprite;
            cShake.Shake(3f);
        }
    }
}
