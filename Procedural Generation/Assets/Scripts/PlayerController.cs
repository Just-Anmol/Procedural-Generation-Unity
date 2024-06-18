using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f; // Speed of the player movement
    public float jumpSpeed = 5f; // Jump Speed of the player movement
    private bool OnGround;
    private Rigidbody2D rb;
   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Get input from horizontal axis (A/D keys or Left/Right arrow keys)
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Jump movement
        if (Input.GetKeyDown(KeyCode.Space) && OnGround)
            jump();
    }

    void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        OnGround = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            OnGround = true;
    }

}
