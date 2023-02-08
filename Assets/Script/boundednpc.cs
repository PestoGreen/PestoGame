using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundednpc : MonoBehaviour
{
    private Vector3 directionVector;
    private Transform mytransform;
    private float spped;
    private Rigidbody2D myrigidbody;
    private Animator anim;
    public Collider2D bounds;
    private SpriteRenderer mysprite;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        mytransform = GetComponent<Transform>();
        myrigidbody = GetComponent<Rigidbody2D>();
        mysprite = GetComponent<SpriteRenderer>();
        changedirection();
        spped = 7;
    }

    // Update is called once per frame
    void Update()
    {
        if(directionVector.x == 1)
        {
            mysprite.flipX = true;
        }
        else if(directionVector.x == -1)
        {
            mysprite.flipX = false;
        }
        Move();
    }
    private void Move()
    {
        Vector3 temp = mytransform.position + directionVector * spped * Time.deltaTime;
        if (bounds.bounds.Contains(temp))
        myrigidbody.MovePosition(temp);
        else
        {
            changedirection();
        }
    }
    void changedirection()
    {
        int direction = Random.Range(0, 4);
        switch (direction)
        {
            case 0:
                directionVector = Vector3.right;
                break;
            case 1:
                directionVector = Vector3.up;
                break;
            case 2:
                directionVector = Vector3.left;
                break;
            case 3:
                directionVector = Vector3.down;
                break;
            default:
                break;
        }
        UpdateAnimation();
    }
    void UpdateAnimation()
    {
        anim.SetFloat("h", directionVector.x);
        anim.SetFloat("v", directionVector.y);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        changedirection();
        spped = 0;
        myrigidbody.bodyType = RigidbodyType2D.Static;
        anim.SetBool("idle1", true);
        //Vector3 temp = directionVector;
        //changedirection();
        //int loops = 0;
        //while(temp == directionVector && loops < 100)
        //{
        //    loops++;
        //    changedirection();
        //    spped = 0;
        //    myrigidbody.bodyType = RigidbodyType2D.Static;
        //}
    }
}
