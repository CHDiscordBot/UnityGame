using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;
    private SpriteRenderer renderer;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(move, body.velocity.y);
        if(move < 0)
            renderer.flipX = true;
        else
            renderer.flipX = false;
        if(move == 0)
            anim.Play("a_idle");
        else
            anim.Play("a_move");
    }
}
