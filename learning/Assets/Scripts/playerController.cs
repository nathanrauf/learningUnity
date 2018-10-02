using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {


    Rigidbody2D rb;
    public float movementSpeed = 5f;
    public float jumpHeight = 5f;
    bool onGround;
    public Transform groundCheck;
    public LayerMask ground;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void FixedUpdate () {

        //horizontal movement
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * movementSpeed, rb.velocity.y);

        //onGround
        onGround = Physics2D.OverlapCircle(groundCheck.position, .2f, ground);
        
	}

    void Update()
    {
        //jumpman
        if(onGround && Input.GetButtonDown("Jump")){
            rb.AddForce(new Vector2(0,jumpHeight));
        }
         
    }
}
