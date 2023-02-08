using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 10f;
    Animator moveani;
    public bool move;
    public Rigidbody2D rb;
    Vector2 movement;
    void Start()
    {
        moveani = GetComponent<Animator>();
    }
    void Update()
    {
        //Vector3 pos = transform.position;

        //if (Input.GetKey("w"))
        //{
        //    pos.y += speed * Time.deltaTime;
        //    GetComponent<SpriteRenderer>().flipY = false;
        //}
        //if (Input.GetKey("s"))
        //{
        //    pos.y -= speed * Time.deltaTime;
        //    //GetComponent<SpriteRenderer>().flipY = true;
        //}
        //if (Input.GetKey("a"))
        //{
        //    pos.x -= speed * Time.deltaTime;
        //    GetComponent<SpriteRenderer>().flipX = true;
        //    move = true;
        //}
        //else
        //{
        //    move = false;
        //}
        //if (Input.GetKey("d"))
        //{
        //    pos.x += speed * Time.deltaTime;
        //    GetComponent<SpriteRenderer>().flipX = false;
        //    move = true;
        //}
        //transform.position = pos;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if(movement.x != 0 | movement.y != 0)
        {
            move = true;
            
        }
        else
        {
            move = false;
        }
        if (movement.x == 1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            moveani.SetFloat("h", 1);
            moveani.SetFloat("v", 0);
        }
        if (movement.x == -1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            moveani.SetFloat("h", -1);
            moveani.SetFloat("v", 0);
        }
        if (moveani.GetBool("isMoving") == false && moveani.GetFloat("h") == 1 && moveani.GetFloat("v") == 0)
        {
            moveani.SetBool("leftstop", true);
        }
        else if (moveani.GetBool("isMoving") == false && moveani.GetFloat("h") == -1 && moveani.GetFloat("v") == 0)
        {
            moveani.SetBool("leftstop", true);
        }
        else
        {
            moveani.SetBool("leftstop", false);
        }
        if (movement.y == 1)
        {
            moveani.SetFloat("v", 1);
            moveani.SetFloat("h", 0);
        }
        if (moveani.GetBool("isMoving") == false && moveani.GetFloat("h") == 0 && moveani.GetFloat("v") == 1)
        {
            moveani.SetBool("upstop", true);
        }
        else
        {
            moveani.SetBool("upstop", false);
        }
        if (movement.y == -1)
        {
            moveani.SetFloat("v", -1);
            moveani.SetFloat("h", 0);
        }
        if (moveani.GetBool("isMoving") == false && moveani.GetFloat("h") == 0 && moveani.GetFloat("v") == -1)
        {
            moveani.SetBool("downstop", true);
        }
        else
        {
            moveani.SetBool("downstop", false);
        }
        if (move == true)
        {
            moveani.SetBool("isMoving", true);
        }
        if (move == false)
        {
            moveani.SetBool("isMoving", false);
        }

    }
    void FixedUpdate()
    {
        rb.MovePosition(new Vector2(transform.position.x + movement.x * speed * Time.fixedDeltaTime,transform.position.y + movement.y*speed*Time.fixedDeltaTime));
    }
}
