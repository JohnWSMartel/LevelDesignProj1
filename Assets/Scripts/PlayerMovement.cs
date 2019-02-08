using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    float runSpeed = 150f;
    float horizontalMove = 0;
    bool jump = false;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump") || Input.GetKeyDown("w") || Input.GetKeyDown("up"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        //Character movement
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.name.Equals("Second Mover")||col.gameObject.name.Equals("Final Mover"))
        {
            this.transform.parent = col.transform;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Second Mover")|| col.gameObject.name.Equals("Final Mover"))
        {
            this.transform.parent = null;
        }
    }

    void OnTriggerEnter2D(Collider2D spike)
    {
        if(spike.tag == "Spike")
        {
            this.transform.position = new Vector3(-6.8f, 1.03f, 0f);
        }
    }
}
