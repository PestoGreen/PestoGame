using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloudd,cloudposition;
    Rigidbody2D rigid2D;
    
    public float speedx;
    void Start()
    {

        Invoke("Ins", 4f);
        rigid2D = this.GetComponent<Rigidbody2D>();
        rigid2D.velocity = new Vector2(speedx, rigid2D.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Ins()
    {
        Instantiate(cloudd, cloudposition.transform.position, Quaternion.identity);
    }
}
