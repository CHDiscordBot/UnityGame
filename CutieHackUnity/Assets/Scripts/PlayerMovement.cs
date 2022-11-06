using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;
    private SpriteRenderer renderer;

    private bool canJump = false;

    private static float jumpForce = 3f;

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
        else if(move > 0)
            renderer.flipX = false;
        
        if(Input.GetKeyDown("space") && canJump) {
            Debug.Log("space");
            canJump = false;
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if(move == 0)
            anim.Play("a_idle");
        else
            anim.Play("a_move");
    }

    private void OnCollisionEnter2D(Collision2D col) {
        canJump = true;
    }
}
