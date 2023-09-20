using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody2D playerRig;
    public float jumpForce = 10f;
    public float moveSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        playerRig.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        // check if player is on the ground
        if (playerRig.velocity.y == 0)
        {
            // if player is on the ground, allow them to jump
            Jump();
        }

        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }

        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            playerRig.velocity = Vector2.up * jumpForce;
        }
    }
}
