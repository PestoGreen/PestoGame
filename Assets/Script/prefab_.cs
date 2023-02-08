using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_ : MonoBehaviour
{

    public GameObject house;
    public GameObject position123;
    public GameObject house1;
    public bool over;
    //public gameover spacenot;
    
    // Start is called before the first frame update
    void Start()
    {
        //over = true;
        //spacenot.over = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) /*&& spacenot.over  == true*/)
        {
            Instantiate(house, position123.transform.position, Quaternion.identity);
            house1.GetComponent<SpriteRenderer>().enabled = false;
            Invoke("test", 2f);
        }
        
    }

     void test()
    {
        house1.GetComponent<SpriteRenderer>().enabled = true;
        
    }
    
}
