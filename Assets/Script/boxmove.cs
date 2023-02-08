using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmove : MonoBehaviour
{
    public GameObject boxx;
    Rigidbody2D rigid2d;
    public float speedx;
   
    // Start is called before the first frame update
    void Start()
    {
        rigid2d = this.gameObject.GetComponent<Rigidbody2D>();
        rigid2d.velocity = new Vector2(speedx, rigid2d.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
