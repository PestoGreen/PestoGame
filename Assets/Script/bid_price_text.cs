using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bid_price_text : MonoBehaviour
{
    public int bid_price;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "當前標價：" + bid_price;
    }

    void plustwohun()
    {
        bid_price += 200;
    }

    void plusfivehun()
    {
        bid_price += 500;
    }

}
